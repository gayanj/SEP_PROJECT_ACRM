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
            this.logTxt = new System.Windows.Forms.RichTextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.fileTypeFilterTxt = new MetroFramework.Controls.MetroTextBox();
            this.dirTxt = new MetroFramework.Controls.MetroTextBox();
            this.stopBtn = new MetroFramework.Controls.MetroButton();
            this.startBtn = new MetroFramework.Controls.MetroButton();
            this.browseFolderBtn = new MetroFramework.Controls.MetroButton();
            this.subDirChkBox = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
            this.metroPanel1.SuspendLayout();
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
            // logTxt
            // 
            this.logTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logTxt.BackColor = System.Drawing.SystemColors.InfoText;
            this.logTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logTxt.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logTxt.ForeColor = System.Drawing.SystemColors.Window;
            this.logTxt.Location = new System.Drawing.Point(15, 140);
            this.logTxt.Name = "logTxt";
            this.logTxt.Size = new System.Drawing.Size(827, 428);
            this.logTxt.TabIndex = 5;
            this.logTxt.Text = "";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.fileTypeFilterTxt);
            this.metroPanel1.Controls.Add(this.dirTxt);
            this.metroPanel1.Controls.Add(this.stopBtn);
            this.metroPanel1.Controls.Add(this.startBtn);
            this.metroPanel1.Controls.Add(this.browseFolderBtn);
            this.metroPanel1.Controls.Add(this.subDirChkBox);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.CustomBackground = false;
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbar = false;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(854, 580);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanel1.StyleManager = null;
            this.metroPanel1.TabIndex = 9;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbar = false;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // fileTypeFilterTxt
            // 
            this.fileTypeFilterTxt.CustomBackground = false;
            this.fileTypeFilterTxt.CustomForeColor = false;
            this.fileTypeFilterTxt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.fileTypeFilterTxt.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.fileTypeFilterTxt.Location = new System.Drawing.Point(155, 49);
            this.fileTypeFilterTxt.Multiline = false;
            this.fileTypeFilterTxt.Name = "fileTypeFilterTxt";
            this.fileTypeFilterTxt.SelectedText = "";
            this.fileTypeFilterTxt.Size = new System.Drawing.Size(270, 23);
            this.fileTypeFilterTxt.Style = MetroFramework.MetroColorStyle.Blue;
            this.fileTypeFilterTxt.StyleManager = null;
            this.fileTypeFilterTxt.TabIndex = 14;
            this.fileTypeFilterTxt.Text = "*.*";
            this.fileTypeFilterTxt.Theme = MetroFramework.MetroThemeStyle.Light;
            this.fileTypeFilterTxt.UseStyleColors = false;
            // 
            // dirTxt
            // 
            this.dirTxt.CustomBackground = false;
            this.dirTxt.CustomForeColor = false;
            this.dirTxt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.dirTxt.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.dirTxt.Location = new System.Drawing.Point(155, 17);
            this.dirTxt.Multiline = false;
            this.dirTxt.Name = "dirTxt";
            this.dirTxt.SelectedText = "";
            this.dirTxt.Size = new System.Drawing.Size(270, 23);
            this.dirTxt.Style = MetroFramework.MetroColorStyle.Blue;
            this.dirTxt.StyleManager = null;
            this.dirTxt.TabIndex = 13;
            this.dirTxt.Text = "C:\\";
            this.dirTxt.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dirTxt.UseStyleColors = false;
            // 
            // stopBtn
            // 
            this.stopBtn.Highlight = false;
            this.stopBtn.Location = new System.Drawing.Point(743, 81);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(99, 35);
            this.stopBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.stopBtn.StyleManager = null;
            this.stopBtn.TabIndex = 12;
            this.stopBtn.Text = "Stop";
            this.stopBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.stopBtn.Click += new System.EventHandler(this.metroButton1_Click_2);
            // 
            // startBtn
            // 
            this.startBtn.Highlight = false;
            this.startBtn.Location = new System.Drawing.Point(617, 81);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(99, 35);
            this.startBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.startBtn.StyleManager = null;
            this.startBtn.TabIndex = 11;
            this.startBtn.Text = "Start";
            this.startBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.startBtn.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // browseFolderBtn
            // 
            this.browseFolderBtn.Highlight = false;
            this.browseFolderBtn.Location = new System.Drawing.Point(431, 17);
            this.browseFolderBtn.Name = "browseFolderBtn";
            this.browseFolderBtn.Size = new System.Drawing.Size(98, 23);
            this.browseFolderBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.browseFolderBtn.StyleManager = null;
            this.browseFolderBtn.TabIndex = 10;
            this.browseFolderBtn.Text = "Browse";
            this.browseFolderBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.browseFolderBtn.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // subDirChkBox
            // 
            this.subDirChkBox.AutoSize = true;
            this.subDirChkBox.CustomBackground = false;
            this.subDirChkBox.CustomForeColor = true;
            this.subDirChkBox.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.subDirChkBox.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.subDirChkBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.subDirChkBox.Location = new System.Drawing.Point(17, 91);
            this.subDirChkBox.Name = "subDirChkBox";
            this.subDirChkBox.Size = new System.Drawing.Size(198, 25);
            this.subDirChkBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.subDirChkBox.StyleManager = null;
            this.subDirChkBox.TabIndex = 9;
            this.subDirChkBox.Text = "Include Sub Directory";
            this.subDirChkBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.subDirChkBox.UseStyleColors = false;
            this.subDirChkBox.UseVisualStyleBackColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = false;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel2.Location = new System.Drawing.Point(17, 47);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(117, 25);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.StyleManager = null;
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "File Type Filter";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseStyleColors = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(17, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Directory";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = false;
            // 
            // FileSysMonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(854, 580);
            this.Controls.Add(this.logTxt);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(870, 619);
            this.MinimumSize = new System.Drawing.Size(870, 619);
            this.Name = "FileSysMonForm";
            this.ShowIcon = false;
            this.Text = "File System Monitor";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher;
        private System.Windows.Forms.RichTextBox logTxt;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton browseFolderBtn;
        private MetroFramework.Controls.MetroCheckBox subDirChkBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton startBtn;
        private MetroFramework.Controls.MetroButton stopBtn;
        private MetroFramework.Controls.MetroTextBox fileTypeFilterTxt;
        private MetroFramework.Controls.MetroTextBox dirTxt;
    }
}