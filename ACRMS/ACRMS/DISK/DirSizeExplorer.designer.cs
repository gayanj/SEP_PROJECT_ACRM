namespace ACRMS.DISK
{
    partial class DirSizeExplorer
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
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.treeView = new System.Windows.Forms.TreeView();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnStop = new MetroFramework.Controls.MetroButton();
            this.btnStart = new MetroFramework.Controls.MetroButton();
            this.cBoxDriveList = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(12, 39);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(365, 230);
            this.treeView.TabIndex = 4;
            this.treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseDoubleClick);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnClear);
            this.metroPanel1.Controls.Add(this.btnStop);
            this.metroPanel1.Controls.Add(this.btnStart);
            this.metroPanel1.Controls.Add(this.cBoxDriveList);
            this.metroPanel1.CustomBackground = false;
            this.metroPanel1.HorizontalScrollbar = false;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(-1, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(391, 286);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanel1.StyleManager = null;
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbar = false;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnClear
            // 
            this.btnClear.Highlight = false;
            this.btnClear.Location = new System.Drawing.Point(302, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 29);
            this.btnClear.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnClear.StyleManager = null;
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnClear.Click += new System.EventHandler(this.btnClear1_Click);
            // 
            // btnStop
            // 
            this.btnStop.Highlight = false;
            this.btnStop.Location = new System.Drawing.Point(221, 6);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 29);
            this.btnStop.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnStop.StyleManager = null;
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnStop.Click += new System.EventHandler(this.btnStop1_Click);
            // 
            // btnStart
            // 
            this.btnStart.Highlight = false;
            this.btnStart.Location = new System.Drawing.Point(140, 6);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 29);
            this.btnStart.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnStart.StyleManager = null;
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnStart.Click += new System.EventHandler(this.btnStart1_Click);
            // 
            // cBoxDriveList
            // 
            this.cBoxDriveList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBoxDriveList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxDriveList.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.cBoxDriveList.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.cBoxDriveList.FormattingEnabled = true;
            this.cBoxDriveList.ItemHeight = 23;
            this.cBoxDriveList.Location = new System.Drawing.Point(13, 6);
            this.cBoxDriveList.Name = "cBoxDriveList";
            this.cBoxDriveList.Size = new System.Drawing.Size(121, 29);
            this.cBoxDriveList.Style = MetroFramework.MetroColorStyle.Blue;
            this.cBoxDriveList.StyleManager = null;
            this.cBoxDriveList.TabIndex = 2;
            this.cBoxDriveList.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cBoxDriveList.SelectedIndexChanged += new System.EventHandler(this.cBoxDriveList_SelectedIndexChanged);
            // 
            // DirSizeExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 281);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 320);
            this.MinimumSize = new System.Drawing.Size(400, 320);
            this.Name = "DirSizeExplorer";
            this.ShowIcon = false;
            this.Text = "Directory Mapper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DirSizeExplorer_FormClosing);
            this.Load += new System.EventHandler(this.DirSizeExplorer_Load);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TreeView treeView;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnStart;
        private MetroFramework.Controls.MetroComboBox cBoxDriveList;
        private MetroFramework.Controls.MetroButton btnStop;
        private MetroFramework.Controls.MetroButton btnClear;
    }
}