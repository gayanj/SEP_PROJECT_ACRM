namespace ACRMS.DISK
{
    partial class FileSysMonForm
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
        private void InitializeComponent()
        {
            this.fileSystemWatcher = new System.IO.FileSystemWatcher();
            this.label1 = new System.Windows.Forms.Label();
            this.dirTxt = new System.Windows.Forms.TextBox();
            this.fileTypeFilterTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.subDirChkBox = new System.Windows.Forms.CheckBox();
            this.logTxt = new System.Windows.Forms.RichTextBox();
            this.stopBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.browseFolderBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher
            // 
            this.fileSystemWatcher.EnableRaisingEvents = true;
            this.fileSystemWatcher.SynchronizingObject = this;
            this.fileSystemWatcher.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Changed);
            this.fileSystemWatcher.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Created);
            this.fileSystemWatcher.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Deleted);
            this.fileSystemWatcher.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher_Renamed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Directory";
            // 
            // dirTxt
            // 
            this.dirTxt.Location = new System.Drawing.Point(93, 13);
            this.dirTxt.Name = "dirTxt";
            this.dirTxt.Size = new System.Drawing.Size(100, 20);
            this.dirTxt.TabIndex = 1;
            this.dirTxt.Text = "C:\\";
            // 
            // fileTypeFilterTxt
            // 
            this.fileTypeFilterTxt.Location = new System.Drawing.Point(93, 40);
            this.fileTypeFilterTxt.Name = "fileTypeFilterTxt";
            this.fileTypeFilterTxt.Size = new System.Drawing.Size(100, 20);
            this.fileTypeFilterTxt.TabIndex = 2;
            this.fileTypeFilterTxt.Text = "*.*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "File Type Filter";
            // 
            // subDirChkBox
            // 
            this.subDirChkBox.AutoSize = true;
            this.subDirChkBox.Location = new System.Drawing.Point(93, 67);
            this.subDirChkBox.Name = "subDirChkBox";
            this.subDirChkBox.Size = new System.Drawing.Size(128, 17);
            this.subDirChkBox.TabIndex = 4;
            this.subDirChkBox.Text = "Include Sub Directory";
            this.subDirChkBox.UseVisualStyleBackColor = true;
            // 
            // logTxt
            // 
            this.logTxt.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logTxt.Location = new System.Drawing.Point(15, 90);
            this.logTxt.Name = "logTxt";
            this.logTxt.Size = new System.Drawing.Size(657, 429);
            this.logTxt.TabIndex = 5;
            this.logTxt.Text = "";
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(597, 63);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 6;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(516, 63);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 7;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // browseFolderBtn
            // 
            this.browseFolderBtn.Location = new System.Drawing.Point(199, 11);
            this.browseFolderBtn.Name = "browseFolderBtn";
            this.browseFolderBtn.Size = new System.Drawing.Size(75, 23);
            this.browseFolderBtn.TabIndex = 8;
            this.browseFolderBtn.Text = "Browse";
            this.browseFolderBtn.UseVisualStyleBackColor = true;
            this.browseFolderBtn.Click += new System.EventHandler(this.browseFolderBtn_Click);
            // 
            // FileSysMonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(684, 531);
            this.Controls.Add(this.browseFolderBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.logTxt);
            this.Controls.Add(this.subDirChkBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileTypeFilterTxt);
            this.Controls.Add(this.dirTxt);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 570);
            this.MinimumSize = new System.Drawing.Size(700, 570);
            this.Name = "FileSysMonForm";
            this.ShowIcon = false;
            this.Text = "File System Monitor";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.RichTextBox logTxt;
        private System.Windows.Forms.CheckBox subDirChkBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fileTypeFilterTxt;
        private System.Windows.Forms.TextBox dirTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browseFolderBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}