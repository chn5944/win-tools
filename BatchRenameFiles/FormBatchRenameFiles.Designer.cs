
namespace BatchRenameFiles {
    partial class FormBatchRenameFiles {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            this.ChkContainSubFolder = new System.Windows.Forms.CheckBox();
            this.BtnRename = new System.Windows.Forms.Button();
            this.TxtFiles = new System.Windows.Forms.TextBox();
            this.TxtDirPath = new System.Windows.Forms.TextBox();
            this.BtnChooseDir = new System.Windows.Forms.Button();
            this.BtnPreview = new System.Windows.Forms.Button();
            this.TxtRegex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtReplace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbxUseRegex = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ChkContainSubFolder
            // 
            this.ChkContainSubFolder.AutoSize = true;
            this.ChkContainSubFolder.Font = new System.Drawing.Font("宋体", 10.8F);
            this.ChkContainSubFolder.Location = new System.Drawing.Point(29, 49);
            this.ChkContainSubFolder.Margin = new System.Windows.Forms.Padding(2);
            this.ChkContainSubFolder.Name = "ChkContainSubFolder";
            this.ChkContainSubFolder.Size = new System.Drawing.Size(116, 19);
            this.ChkContainSubFolder.TabIndex = 10;
            this.ChkContainSubFolder.Text = "包含子文件夹";
            this.ChkContainSubFolder.UseVisualStyleBackColor = true;
            // 
            // BtnRename
            // 
            this.BtnRename.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnRename.Font = new System.Drawing.Font("宋体", 10.8F);
            this.BtnRename.Location = new System.Drawing.Point(722, 409);
            this.BtnRename.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRename.Name = "BtnRename";
            this.BtnRename.Size = new System.Drawing.Size(136, 46);
            this.BtnRename.TabIndex = 9;
            this.BtnRename.Text = "重命名";
            this.BtnRename.UseVisualStyleBackColor = false;
            this.BtnRename.Click += new System.EventHandler(this.BtnRename_Click);
            // 
            // TxtFiles
            // 
            this.TxtFiles.Location = new System.Drawing.Point(29, 121);
            this.TxtFiles.Margin = new System.Windows.Forms.Padding(2);
            this.TxtFiles.Multiline = true;
            this.TxtFiles.Name = "TxtFiles";
            this.TxtFiles.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtFiles.Size = new System.Drawing.Size(829, 284);
            this.TxtFiles.TabIndex = 8;
            // 
            // TxtDirPath
            // 
            this.TxtDirPath.Location = new System.Drawing.Point(29, 25);
            this.TxtDirPath.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDirPath.Name = "TxtDirPath";
            this.TxtDirPath.Size = new System.Drawing.Size(361, 21);
            this.TxtDirPath.TabIndex = 7;
            // 
            // BtnChooseDir
            // 
            this.BtnChooseDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnChooseDir.Font = new System.Drawing.Font("宋体", 10.8F);
            this.BtnChooseDir.Location = new System.Drawing.Point(432, 11);
            this.BtnChooseDir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnChooseDir.Name = "BtnChooseDir";
            this.BtnChooseDir.Size = new System.Drawing.Size(90, 46);
            this.BtnChooseDir.TabIndex = 6;
            this.BtnChooseDir.Text = "选择文件夹";
            this.BtnChooseDir.UseVisualStyleBackColor = false;
            this.BtnChooseDir.Click += new System.EventHandler(this.BtnChooseDir_Click);
            // 
            // BtnPreview
            // 
            this.BtnPreview.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnPreview.Font = new System.Drawing.Font("宋体", 10.8F);
            this.BtnPreview.Location = new System.Drawing.Point(568, 409);
            this.BtnPreview.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPreview.Name = "BtnPreview";
            this.BtnPreview.Size = new System.Drawing.Size(136, 46);
            this.BtnPreview.TabIndex = 11;
            this.BtnPreview.Text = "预览";
            this.BtnPreview.UseVisualStyleBackColor = false;
            this.BtnPreview.Click += new System.EventHandler(this.BtnPreview_Click);
            // 
            // TxtRegex
            // 
            this.TxtRegex.Location = new System.Drawing.Point(630, 25);
            this.TxtRegex.Name = "TxtRegex";
            this.TxtRegex.Size = new System.Drawing.Size(228, 21);
            this.TxtRegex.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "Regex";
            // 
            // TxtReplace
            // 
            this.TxtReplace.Location = new System.Drawing.Point(630, 52);
            this.TxtReplace.Name = "TxtReplace";
            this.TxtReplace.Size = new System.Drawing.Size(228, 21);
            this.TxtReplace.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(577, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "Replace";
            // 
            // CbxUseRegex
            // 
            this.CbxUseRegex.AutoSize = true;
            this.CbxUseRegex.Location = new System.Drawing.Point(579, 88);
            this.CbxUseRegex.Name = "CbxUseRegex";
            this.CbxUseRegex.Size = new System.Drawing.Size(72, 16);
            this.CbxUseRegex.TabIndex = 16;
            this.CbxUseRegex.Text = "UseRegex";
            this.CbxUseRegex.UseVisualStyleBackColor = true;
            // 
            // FormBatchRenameFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 466);
            this.Controls.Add(this.CbxUseRegex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtReplace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtRegex);
            this.Controls.Add(this.BtnPreview);
            this.Controls.Add(this.ChkContainSubFolder);
            this.Controls.Add(this.BtnRename);
            this.Controls.Add(this.TxtFiles);
            this.Controls.Add(this.TxtDirPath);
            this.Controls.Add(this.BtnChooseDir);
            this.Name = "FormBatchRenameFiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BatchRenameFiles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox ChkContainSubFolder;
        private System.Windows.Forms.Button BtnRename;
        private System.Windows.Forms.TextBox TxtFiles;
        private System.Windows.Forms.TextBox TxtDirPath;
        private System.Windows.Forms.Button BtnChooseDir;
        private System.Windows.Forms.Button BtnPreview;
        private System.Windows.Forms.TextBox TxtRegex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtReplace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CbxUseRegex;
    }
}

