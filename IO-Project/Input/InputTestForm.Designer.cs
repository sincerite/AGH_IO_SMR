namespace IO_Project.Input
{
    partial class InputTestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.rtbFileContent = new System.Windows.Forms.RichTextBox();
            this.btAddSingleFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbInputFiles = new System.Windows.Forms.ListBox();
            this.btOpenFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tbProjectPath = new System.Windows.Forms.TextBox();
            this.btSetPath = new System.Windows.Forms.Button();
            this.btRemoveFile = new System.Windows.Forms.Button();
            this.btDetermineRootPath = new System.Windows.Forms.Button();
            this.btAcceptFiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbFileContent
            // 
            this.rtbFileContent.Location = new System.Drawing.Point(12, 12);
            this.rtbFileContent.Name = "rtbFileContent";
            this.rtbFileContent.Size = new System.Drawing.Size(387, 426);
            this.rtbFileContent.TabIndex = 0;
            this.rtbFileContent.Text = "(file preview)";
            // 
            // btAddSingleFile
            // 
            this.btAddSingleFile.Location = new System.Drawing.Point(405, 282);
            this.btAddSingleFile.Name = "btAddSingleFile";
            this.btAddSingleFile.Size = new System.Drawing.Size(170, 25);
            this.btAddSingleFile.TabIndex = 1;
            this.btAddSingleFile.Text = "Add single file";
            this.btAddSingleFile.UseVisualStyleBackColor = true;
            this.btAddSingleFile.Click += new System.EventHandler(this.btAddSingleFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // lbInputFiles
            // 
            this.lbInputFiles.FormattingEnabled = true;
            this.lbInputFiles.Location = new System.Drawing.Point(405, 77);
            this.lbInputFiles.Name = "lbInputFiles";
            this.lbInputFiles.Size = new System.Drawing.Size(383, 199);
            this.lbInputFiles.TabIndex = 2;
            this.lbInputFiles.SelectedIndexChanged += new System.EventHandler(this.lbInputFiles_SelectedIndexChanged);
            this.lbInputFiles.DoubleClick += new System.EventHandler(this.lbInputFiles_DoubleClick);
            // 
            // btOpenFolder
            // 
            this.btOpenFolder.Location = new System.Drawing.Point(405, 38);
            this.btOpenFolder.Name = "btOpenFolder";
            this.btOpenFolder.Size = new System.Drawing.Size(110, 20);
            this.btOpenFolder.TabIndex = 3;
            this.btOpenFolder.Text = "Open folder";
            this.btOpenFolder.UseVisualStyleBackColor = true;
            this.btOpenFolder.Click += new System.EventHandler(this.btOpenFolder_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // tbProjectPath
            // 
            this.tbProjectPath.Location = new System.Drawing.Point(405, 12);
            this.tbProjectPath.Name = "tbProjectPath";
            this.tbProjectPath.Size = new System.Drawing.Size(333, 20);
            this.tbProjectPath.TabIndex = 4;
            // 
            // btSetPath
            // 
            this.btSetPath.Location = new System.Drawing.Point(744, 12);
            this.btSetPath.Name = "btSetPath";
            this.btSetPath.Size = new System.Drawing.Size(44, 20);
            this.btSetPath.TabIndex = 5;
            this.btSetPath.Text = "Set as root path";
            this.btSetPath.UseVisualStyleBackColor = true;
            this.btSetPath.Click += new System.EventHandler(this.btSethPath_Click);
            // 
            // btRemoveFile
            // 
            this.btRemoveFile.Location = new System.Drawing.Point(704, 282);
            this.btRemoveFile.Name = "btRemoveFile";
            this.btRemoveFile.Size = new System.Drawing.Size(84, 25);
            this.btRemoveFile.TabIndex = 6;
            this.btRemoveFile.Text = "Remove";
            this.btRemoveFile.UseVisualStyleBackColor = true;
            this.btRemoveFile.Click += new System.EventHandler(this.btRemoveFile_Click);
            // 
            // btDetermineRootPath
            // 
            this.btDetermineRootPath.Location = new System.Drawing.Point(405, 313);
            this.btDetermineRootPath.Name = "btDetermineRootPath";
            this.btDetermineRootPath.Size = new System.Drawing.Size(170, 25);
            this.btDetermineRootPath.TabIndex = 7;
            this.btDetermineRootPath.Text = "Determine Root Path";
            this.btDetermineRootPath.UseVisualStyleBackColor = true;
            this.btDetermineRootPath.Click += new System.EventHandler(this.btDetermineRootPath_Click);
            // 
            // btAcceptFiles
            // 
            this.btAcceptFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btAcceptFiles.Location = new System.Drawing.Point(668, 401);
            this.btAcceptFiles.Name = "btAcceptFiles";
            this.btAcceptFiles.Size = new System.Drawing.Size(120, 37);
            this.btAcceptFiles.TabIndex = 8;
            this.btAcceptFiles.Text = "Accept files";
            this.btAcceptFiles.UseVisualStyleBackColor = true;
            this.btAcceptFiles.Click += new System.EventHandler(this.BtAcceptFiles_Click);
            // 
            // InputTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btAcceptFiles);
            this.Controls.Add(this.btDetermineRootPath);
            this.Controls.Add(this.btRemoveFile);
            this.Controls.Add(this.btSetPath);
            this.Controls.Add(this.tbProjectPath);
            this.Controls.Add(this.btOpenFolder);
            this.Controls.Add(this.lbInputFiles);
            this.Controls.Add(this.btAddSingleFile);
            this.Controls.Add(this.rtbFileContent);
            this.Name = "InputTestForm";
            this.Text = "InputTestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbFileContent;
        private System.Windows.Forms.Button btAddSingleFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lbInputFiles;
        private System.Windows.Forms.Button btOpenFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox tbProjectPath;
        private System.Windows.Forms.Button btSetPath;
        private System.Windows.Forms.Button btRemoveFile;
        private System.Windows.Forms.Button btDetermineRootPath;
        private System.Windows.Forms.Button btAcceptFiles;
    }
}