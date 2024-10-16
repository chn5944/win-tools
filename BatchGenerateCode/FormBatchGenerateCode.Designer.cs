
namespace BatchGenerateCode {
    partial class FormBatchGenerateCode {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.textTemplate = new System.Windows.Forms.TextBox();
            this.textStartNo = new System.Windows.Forms.TextBox();
            this.textEndNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.LabelTip = new System.Windows.Forms.Label();
            this.ChkNewLine = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // TxtCode
            // 
            this.TxtCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCode.Location = new System.Drawing.Point(41, 264);
            this.TxtCode.Multiline = true;
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtCode.Size = new System.Drawing.Size(725, 216);
            this.TxtCode.TabIndex = 3;
            // 
            // textTemplate
            // 
            this.textTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textTemplate.Location = new System.Drawing.Point(41, 28);
            this.textTemplate.Multiline = true;
            this.textTemplate.Name = "textTemplate";
            this.textTemplate.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textTemplate.Size = new System.Drawing.Size(725, 162);
            this.textTemplate.TabIndex = 4;
            // 
            // textStartNo
            // 
            this.textStartNo.Location = new System.Drawing.Point(139, 212);
            this.textStartNo.Name = "textStartNo";
            this.textStartNo.Size = new System.Drawing.Size(100, 25);
            this.textStartNo.TabIndex = 5;
            // 
            // textEndNo
            // 
            this.textEndNo.Location = new System.Drawing.Point(356, 212);
            this.textEndNo.Name = "textEndNo";
            this.textEndNo.Size = new System.Drawing.Size(100, 25);
            this.textEndNo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Template";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "StartNumber";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "EndNumber";
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnGenerate.Location = new System.Drawing.Point(656, 200);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(110, 44);
            this.BtnGenerate.TabIndex = 11;
            this.BtnGenerate.Text = "Generate";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // LabelTip
            // 
            this.LabelTip.AutoSize = true;
            this.LabelTip.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LabelTip.Location = new System.Drawing.Point(115, 9);
            this.LabelTip.Name = "LabelTip";
            this.LabelTip.Size = new System.Drawing.Size(31, 15);
            this.LabelTip.TabIndex = 12;
            this.LabelTip.Text = "tip";
            this.LabelTip.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ChkNewLine
            // 
            this.ChkNewLine.AutoSize = true;
            this.ChkNewLine.Checked = true;
            this.ChkNewLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkNewLine.Location = new System.Drawing.Point(476, 215);
            this.ChkNewLine.Name = "ChkNewLine";
            this.ChkNewLine.Size = new System.Drawing.Size(141, 19);
            this.ChkNewLine.TabIndex = 13;
            this.ChkNewLine.Text = "NewLineForLoop";
            this.ChkNewLine.UseVisualStyleBackColor = true;
            // 
            // FormBatchGenerateCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 515);
            this.Controls.Add(this.ChkNewLine);
            this.Controls.Add(this.LabelTip);
            this.Controls.Add(this.BtnGenerate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textEndNo);
            this.Controls.Add(this.textStartNo);
            this.Controls.Add(this.textTemplate);
            this.Controls.Add(this.TxtCode);
            this.Name = "FormBatchGenerateCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BatchGenerateCode";
            this.Load += new System.EventHandler(this.FormBatchGenerateCode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCode;
        private System.Windows.Forms.TextBox textTemplate;
        private System.Windows.Forms.TextBox textStartNo;
        private System.Windows.Forms.TextBox textEndNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.Label LabelTip;
        private System.Windows.Forms.CheckBox ChkNewLine;
    }
}

