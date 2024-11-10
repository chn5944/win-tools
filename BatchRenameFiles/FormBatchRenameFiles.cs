using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BatchRenameFiles {
    public partial class FormBatchRenameFiles : Form {
        public FormBatchRenameFiles() {
            InitializeComponent();
        }

        private List<String> validImageExtensions = new List<string>() {
            ".jpg" ,".jpeg" ,".png" ,".gif" ,".bmp" ,".ico" ,".tiff" ,".tif", ".webp"
        };

        private void RenameFolder(string folderPath, string destinationFolder, bool containSubFolder = false, string renamedFolderSuffix = "Renamed") {
            DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);
            FileInfo[] fileInfos = directoryInfo.GetFiles();
            int filesCountDigit = fileInfos.Length.ToString().Length;

            string pattern = TxtRegex.Text.Trim();
            string replace = TxtReplace.Text.Trim();
            int fileNameDigit = 0;
            MatchEvaluator incrementMatch = match => {
                string replaced = match.Groups[1].Value;
                fileNameDigit = replaced.Length;
                if (fileNameDigit < filesCountDigit) {
                    replaced = replaced.PadLeft(filesCountDigit, '0');
                }
                replaced = "1" + replaced;
                return replace.Replace("$1", replaced);
            };

            Directory.CreateDirectory(destinationFolder);
            foreach (FileInfo fileInfo in fileInfos) {

                string suffix = Path.GetExtension(fileInfo.Name).ToLowerInvariant();
                string fileName = Path.GetFileNameWithoutExtension(fileInfo.Name);

                if (!validImageExtensions.Contains(suffix)) {
                    continue;
                }
                fileNameDigit = fileName.Length;
                string renamedFileName = fileName;
                if(CbxUseRegex.Checked){
                    renamedFileName = Regex.Replace(fileName, pattern, incrementMatch);
                } else {
                    if (fileNameDigit < filesCountDigit) {
                        renamedFileName = renamedFileName.PadLeft(filesCountDigit, '0');
                    }
                    renamedFileName = "1" + renamedFileName;
                }

                fileInfo.CopyTo(destinationFolder + @"\" + renamedFileName + suffix);
            }
            if (containSubFolder) {
                // 获取文件夹中的所有子文件夹
                // Get all sub folders in the folder
                DirectoryInfo[] subDirectories = directoryInfo.GetDirectories();
                // 递归遍历每个子文件夹
                // Recursively traverse each sub folder
                foreach (DirectoryInfo subDirectory in subDirectories) {
                    RenameFolder(subDirectory.FullName, destinationFolder + @"\" + subDirectory.Name + renamedFolderSuffix, containSubFolder, renamedFolderSuffix);
                }
            }
        }


        private void BtnRename_Click(object sender, EventArgs e) {
            BtnRename.Enabled = false;
            try {
                if (!Directory.Exists(TxtDirPath.Text.Trim())) {
                    throw new Exception("Unable to find folder!");
                }
                Stopwatch stopwatch = Stopwatch.StartNew();
                string newFolderSuffix = "Renamed";
                RenameFolder(TxtDirPath.Text.Trim(), TxtDirPath.Text.Trim() + newFolderSuffix, ChkContainSubFolder.Checked, newFolderSuffix);
                stopwatch.Stop();
                MessageBox.Show($"Success! Renamed files saved to origin directory name with suffix '{newFolderSuffix}', execution time: {stopwatch.ElapsedMilliseconds} ms");
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);

            }
            BtnRename.Enabled = true;
        }

        private void BtnPreview_Click(object sender, EventArgs e) {
            BtnPreview.Enabled = false;
            string subFileNames = PreviewRenameFolder(TxtDirPath.Text.Trim());
            TxtFiles.Text = subFileNames;
            BtnPreview.Enabled = true;
        }

        private void BtnChooseDir_Click(object sender, EventArgs e) {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog()) {
                DialogResult dialogResult = folderDialog.ShowDialog(this);
                if (dialogResult == DialogResult.OK) {
                    TxtDirPath.Text = folderDialog.SelectedPath;
                    // 遍历文件夹及其所有子文件夹中的文件名
                    // Traverse the file names in a folder and all its subfolders
                }
            }
        }

        private string PreviewRenameFolder(string folderPath) {
            StringBuilder fileNameMap = new StringBuilder();
            DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);
            FileInfo[] fileInfos = directoryInfo.GetFiles();
            int filesCountDigit = fileInfos.Length.ToString().Length;
            foreach(FileInfo fileInfo in fileInfos) {
                string fileName = fileInfo.Name.Substring(0, fileInfo.Name.IndexOf('.'));
                string suffix = fileInfo.Name.Substring(fileInfo.Name.IndexOf('.'));
                int fileNameDigit = fileName.Length;
                string renamedFileName = fileName;
                if (fileNameDigit < filesCountDigit) {
                    renamedFileName = renamedFileName.PadLeft(filesCountDigit, '0');
                }
                renamedFileName = "1" + renamedFileName;
                fileNameMap.Append(fileInfo.Name).Append(" -> ").Append(renamedFileName).Append(suffix).Append(Environment.NewLine);
            }
            return fileNameMap.ToString();
        }
    }
}
