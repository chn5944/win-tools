using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using TraverseFiles.Properties;

namespace TraverseFiles {
    public partial class FormTraverseFiles : Form {

        private static Color ColorFromHexByArgb(string colorCode) {
            if(colorCode [0] != '#')
                throw new ArgumentException("Invalid color code format");

            int alpha = int.Parse(colorCode.Substring(1, 2), System.Globalization.NumberStyles.HexNumber);
            int red = int.Parse(colorCode.Substring(3, 2), System.Globalization.NumberStyles.HexNumber);
            int green = int.Parse(colorCode.Substring(5, 2), System.Globalization.NumberStyles.HexNumber);
            int blue = int.Parse(colorCode.Substring(7, 2), System.Globalization.NumberStyles.HexNumber);

            return Color.FromArgb(alpha, red, green, blue);
        }

        private static Color ColorFromHexByRgb(string colorCode) {
            if(colorCode [0] != '#')
                throw new ArgumentException("Invalid color code format");

            int red = int.Parse(colorCode.Substring(1, 2), System.Globalization.NumberStyles.HexNumber);
            int green = int.Parse(colorCode.Substring(3, 2), System.Globalization.NumberStyles.HexNumber);
            int blue = int.Parse(colorCode.Substring(5, 2), System.Globalization.NumberStyles.HexNumber);

            return Color.FromArgb(red,green,blue);
        }

        private const int rgbColorHexCodeLength = 7;
        private const int argbColorHexCodeLength = 9;

        private const int subFilePadLeftNumber = 2;

        private static Color ColorFromHexCode(string colorCode) {
            if(!colorCode.StartsWith("#"))
                colorCode = colorCode.Insert(0, "#");
            
            if(colorCode.Length != rgbColorHexCodeLength && colorCode.Length != argbColorHexCodeLength)
                throw new ArgumentException("Invalid color code format");

            if(colorCode.Length == rgbColorHexCodeLength)
                return ColorFromHexByRgb(colorCode);
            else
                return ColorFromHexByArgb(colorCode);
        }

        private static string TraverseFolder(string folderPath, bool containSubFolder = false, bool notFullPath = false, int addBlankNumber = 0) {
            StringBuilder stringBuilder = new StringBuilder();
            // 获取文件夹中的所有文件名
            // Get all file names in the folder
            string [] fileNames = Directory.GetFiles(folderPath);

            stringBuilder.Append(string.Empty.PadLeft(addBlankNumber * subFilePadLeftNumber));
            // 遍历文件名
            // Traverse file names
            foreach(string fileName in fileNames) {
                if(notFullPath) {
                    string fixedfileName = fileName.Remove(0, folderPath.Length + 1);
                    stringBuilder.Append(fixedfileName);
                } else {
                    stringBuilder.Append(fileName);
                }
                stringBuilder.Append(Environment.NewLine);
            }


            if(containSubFolder) {
                // 获取文件夹中的所有子文件夹
                // Get all sub folders in the folder
                string [] subDirectories = Directory.GetDirectories(folderPath);

                // 递归遍历每个子文件夹
                // Recursively traverse each sub folder
                foreach(string subDirectory in subDirectories) {
                    stringBuilder.Append(Environment.NewLine).Append(string.Empty.PadLeft(addBlankNumber * subFilePadLeftNumber));
                    if(notFullPath) {
                        string fixedfileName = subDirectory.Remove(0, folderPath.Length + 1);
                        stringBuilder.Append(fixedfileName);
                    } else {
                        stringBuilder.Append(subDirectory);
                    }
                    stringBuilder.Append(':').Append(Environment.NewLine);
                    string childFileNames = TraverseFolder(subDirectory, containSubFolder, notFullPath, addBlankNumber + 1);
                    stringBuilder.Append(childFileNames).Append(Environment.NewLine);                   
                }
            }
            return stringBuilder.ToString();
        }

        public void ClearCtrl(Control parContainer) {
            for(int index = 0; index < parContainer.Controls.Count; index++) {
                // 如果是容器类控件，递归调用
                // If it is a container control, recursively call
                if(parContainer.Controls [index].HasChildren) {
                    ClearCtrl(parContainer.Controls [index]);
                } else {
                    switch(parContainer.Controls [index].GetType().Name) {
                        case "TextBox":
                            parContainer.Controls [index].Text = "";
                            break;
                        case "RadioButton":
                            break;
                        case "CheckBox":
                            break;
                        case "ComboBox":
                            break;
                    }
                }
            }
        }

        public void SetCtrl(Control fatherControl) {
            foreach(Control childControl in fatherControl.Controls) {
                string text = GetResourceString(childControl.Name + "Text");
                if(!string.IsNullOrEmpty(text)) {
                    childControl.Text = text;
                }
                if(childControl.HasChildren) {
                    SetCtrl(childControl);
                } else {
                    switch(childControl.GetType().Name) {
                        case "Button":
                            ((Button)childControl).BackColor = ColorFromHexCode("8E8F90");
                            break;
                    }
                }
            }
        }

        static ResourceManager resourceManager;

        private string GetResourceString(string name) {
            return resourceManager.GetString(this.Name + "." + name, Thread.CurrentThread.CurrentUICulture);
        }

        static FormTraverseFiles() {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentUICulture;
            if(cultureInfo.Name.Contains("CN")) {
                resourceManager = new ResourceManager("TraverseFiles.Properties.Resource_zh-CN", typeof(Resource_zh_CN).Assembly);
            } else {
                resourceManager = new ResourceManager("TraverseFiles.Properties.Resource_en-US", typeof(Resource_en_US).Assembly);
            }
        }

        public FormTraverseFiles() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
            this.Text = GetResourceString("FormText");
            this.BackColor = ColorFromHexCode("F7F7F7");            
        }

        private void FormTraverseFiles_Load(object sender, EventArgs e) {
            SetCtrl(this);
            this.TxtFiles.ScrollBars = ScrollBars.Both;
        }

        private void BtnChooseDir_Click(object sender, EventArgs e) {
            ClearCtrl(this);
            using(FolderBrowserDialog folderDialog = new FolderBrowserDialog()) {
                DialogResult dialogResult = folderDialog.ShowDialog(this);
                if(dialogResult == DialogResult.OK) {
                    TxtDirPath.Text = folderDialog.SelectedPath;
                    // 遍历文件夹及其所有子文件夹中的文件名
                    // Traverse the file names in a folder and all its subfolders
                    string subFileNames = TraverseFolder(folderDialog.SelectedPath, ChkContainSubFolder.Checked, ChkNotFullPath.Checked);
                    TxtFiles.Text = subFileNames;
                }
            }
        }

        private void BtnCopy_Click(object sender, EventArgs e) {
            if(!string.IsNullOrEmpty(TxtFiles.Text))
                Clipboard.SetText(TxtFiles.Text);
            MessageBox.Show(GetResourceString("BtnCopyText"));
        }
    }
}
