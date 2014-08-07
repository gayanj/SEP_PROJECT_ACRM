namespace ACRMS
{
    partial class ACRMS_Main
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
            this.CPU_Button = new MetroFramework.Controls.MetroButton();
            this.RAM_Button = new MetroFramework.Controls.MetroButton();
            this.DISK_Button = new MetroFramework.Controls.MetroButton();
            this.NETWORK_Button = new MetroFramework.Controls.MetroButton();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // CPU_Button
            // 
            this.CPU_Button.Highlight = false;
            this.CPU_Button.Location = new System.Drawing.Point(12, 12);
            this.CPU_Button.Name = "CPU_Button";
            this.CPU_Button.Size = new System.Drawing.Size(260, 44);
            this.CPU_Button.Style = MetroFramework.MetroColorStyle.Blue;
            this.CPU_Button.StyleManager = null;
            this.CPU_Button.TabIndex = 0;
            this.CPU_Button.Text = "CPU";
            this.CPU_Button.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CPU_Button.Click += new System.EventHandler(this.CPU_Button_Click);
            // 
            // RAM_Button
            // 
            this.RAM_Button.Highlight = false;
            this.RAM_Button.Location = new System.Drawing.Point(12, 62);
            this.RAM_Button.Name = "RAM_Button";
            this.RAM_Button.Size = new System.Drawing.Size(260, 44);
            this.RAM_Button.Style = MetroFramework.MetroColorStyle.Blue;
            this.RAM_Button.StyleManager = null;
            this.RAM_Button.TabIndex = 1;
            this.RAM_Button.Text = "RAM";
            this.RAM_Button.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // DISK_Button
            // 
            this.DISK_Button.Highlight = false;
            this.DISK_Button.Location = new System.Drawing.Point(12, 112);
            this.DISK_Button.Name = "DISK_Button";
            this.DISK_Button.Size = new System.Drawing.Size(260, 44);
            this.DISK_Button.Style = MetroFramework.MetroColorStyle.Blue;
            this.DISK_Button.StyleManager = null;
            this.DISK_Button.TabIndex = 2;
            this.DISK_Button.Text = "DISK";
            this.DISK_Button.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DISK_Button.Click += new System.EventHandler(this.DISK_Button_Click);
            // 
            // NETWORK_Button
            // 
            this.NETWORK_Button.Highlight = false;
            this.NETWORK_Button.Location = new System.Drawing.Point(12, 162);
            this.NETWORK_Button.Name = "NETWORK_Button";
            this.NETWORK_Button.Size = new System.Drawing.Size(260, 44);
            this.NETWORK_Button.Style = MetroFramework.MetroColorStyle.Blue;
            this.NETWORK_Button.StyleManager = null;
            this.NETWORK_Button.TabIndex = 3;
            this.NETWORK_Button.Text = "NETWORK";
            this.NETWORK_Button.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.CustomBackground = false;
            this.metroTile1.CustomForeColor = false;
            this.metroTile1.Location = new System.Drawing.Point(0, -1);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.PaintTileCount = true;
            this.metroTile1.Size = new System.Drawing.Size(284, 223);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile1.StyleManager = null;
            this.metroTile1.TabIndex = 4;
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile1.TileCount = 0;
            // 
            // ACRMS_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 222);
            this.Controls.Add(this.NETWORK_Button);
            this.Controls.Add(this.DISK_Button);
            this.Controls.Add(this.RAM_Button);
            this.Controls.Add(this.CPU_Button);
            this.Controls.Add(this.metroTile1);
            this.Name = "ACRMS_Main";
            this.ShowIcon = false;
            this.Text = "ACRMS";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton CPU_Button;
        private MetroFramework.Controls.MetroButton RAM_Button;
        private MetroFramework.Controls.MetroButton DISK_Button;
        private MetroFramework.Controls.MetroButton NETWORK_Button;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}

