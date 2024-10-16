using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BatchGenerateCode {
    public partial class FormBatchGenerateCode : Form {
        public FormBatchGenerateCode() {
            InitializeComponent();
        }

        private const string x = "x";

        private void FormBatchGenerateCode_Load(object sender, EventArgs e) {
            LabelTip.Text = "Number Position should be surround by ${} also allow formula like '${x-1}' loop to 2 equal '1'";
        }

        private void BtnGenerate_Click(object sender, EventArgs e) {
            try {
                int.TryParse(textStartNo.Text.Trim(), out int startNo);
                int.TryParse(textEndNo.Text.Trim(), out int endNo);
                if(startNo > endNo) {
                    startNo ^= endNo;
                    endNo ^= startNo;
                    startNo ^= endNo;
                }
                string template = textTemplate.Text;
                StringBuilder code = new StringBuilder();
                DataTable table = new DataTable();
                for(int i = startNo; i <= endNo; i++) {
                    string pattern = @"\$\{([^}]+)\}";
                    string result = Regex.Replace(template, pattern, match => {
                        string expression = match.Groups [1].Value.ToLower();
                        if(!expression.Contains(x) || x.Equals(expression)) {
                            return i.ToString();
                        } else {
                            try {
                                return table.Compute(expression.Replace(x, i.ToString()), "").ToString();
                            } catch(Exception) {
                                throw new Exception("invalid expression definition in ${}!");
                            }
                        }
                    });
                    code.Append(result);
                    if(ChkNewLine.Checked && i < endNo) {
                        code.Append(Environment.NewLine);
                    }
                }
                TxtCode.Text = code.ToString();
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
