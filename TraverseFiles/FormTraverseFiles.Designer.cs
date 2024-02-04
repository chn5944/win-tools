
namespace TraverseFiles {
    partial class FormTraverseFiles {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTraverseFiles));
            this.BtnChooseDir = new System.Windows.Forms.Button();
            this.TxtDirPath = new System.Windows.Forms.TextBox();
            this.TxtFiles = new System.Windows.Forms.TextBox();
            this.BtnCopy = new System.Windows.Forms.Button();
            this.ChkContainSubFolder = new System.Windows.Forms.CheckBox();
            this.ChkNotFullPath = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnChooseDir
            // 
            this.BtnChooseDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnChooseDir.Font = new System.Drawing.Font("宋体", 10.8F);
            this.BtnChooseDir.Location = new System.Drawing.Point(629, 58);
            this.BtnChooseDir.Name = "BtnChooseDir";
            this.BtnChooseDir.Size = new System.Drawing.Size(120, 58);
            this.BtnChooseDir.TabIndex = 0;
            this.BtnChooseDir.Text = "选择文件夹";
            this.BtnChooseDir.UseVisualStyleBackColor = false;
            this.BtnChooseDir.Click += new System.EventHandler(this.BtnChooseDir_Click);
            // 
            // TxtDirPath
            // 
            this.TxtDirPath.Location = new System.Drawing.Point(59, 77);
            this.TxtDirPath.Name = "TxtDirPath";
            this.TxtDirPath.Size = new System.Drawing.Size(480, 25);
            this.TxtDirPath.TabIndex = 1;
            // 
            // TxtFiles
            // 
            this.TxtFiles.Location = new System.Drawing.Point(59, 150);
            this.TxtFiles.Multiline = true;
            this.TxtFiles.Name = "TxtFiles";
            this.TxtFiles.Size = new System.Drawing.Size(670, 216);
            this.TxtFiles.TabIndex = 2;
            // 
            // BtnCopy
            // 
            this.BtnCopy.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnCopy.Font = new System.Drawing.Font("宋体", 10.8F);
            this.BtnCopy.Location = new System.Drawing.Point(59, 378);
            this.BtnCopy.Name = "BtnCopy";
            this.BtnCopy.Size = new System.Drawing.Size(182, 58);
            this.BtnCopy.TabIndex = 3;
            this.BtnCopy.Text = "复制到剪切板";
            this.BtnCopy.UseVisualStyleBackColor = false;
            this.BtnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // ChkContainSubFolder
            // 
            this.ChkContainSubFolder.AutoSize = true;
            this.ChkContainSubFolder.Font = new System.Drawing.Font("宋体", 10.8F);
            this.ChkContainSubFolder.Location = new System.Drawing.Point(59, 108);
            this.ChkContainSubFolder.Name = "ChkContainSubFolder";
            this.ChkContainSubFolder.Size = new System.Drawing.Size(145, 23);
            this.ChkContainSubFolder.TabIndex = 4;
            this.ChkContainSubFolder.Text = "包含子文件夹";
            this.ChkContainSubFolder.UseVisualStyleBackColor = true;
            // 
            // ChkNotFullPath
            // 
            this.ChkNotFullPath.AutoSize = true;
            this.ChkNotFullPath.Font = new System.Drawing.Font("宋体", 10.8F);
            this.ChkNotFullPath.Location = new System.Drawing.Point(336, 108);
            this.ChkNotFullPath.Name = "ChkNotFullPath";
            this.ChkNotFullPath.Size = new System.Drawing.Size(145, 23);
            this.ChkNotFullPath.TabIndex = 5;
            this.ChkNotFullPath.Text = "不输出全路径";
            this.ChkNotFullPath.UseVisualStyleBackColor = true;
            // 
            // FormTraverseFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChkNotFullPath);
            this.Controls.Add(this.ChkContainSubFolder);
            this.Controls.Add(this.BtnCopy);
            this.Controls.Add(this.TxtFiles);
            this.Controls.Add(this.TxtDirPath);
            this.Controls.Add(this.BtnChooseDir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTraverseFiles";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormTraverseFiles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnChooseDir;
        private System.Windows.Forms.TextBox TxtDirPath;
        private System.Windows.Forms.TextBox TxtFiles;
        private System.Windows.Forms.Button BtnCopy;
        private System.Windows.Forms.CheckBox ChkContainSubFolder;
        private System.Windows.Forms.CheckBox ChkNotFullPath;
    }
}

