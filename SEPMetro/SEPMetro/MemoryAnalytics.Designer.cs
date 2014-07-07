namespace SEPMetro
{
    partial class MemoryAnalytics
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.ram_analytics = new System.Windows.Forms.TextBox();
            this.ram_RunningApps = new MetroFramework.Controls.MetroButton();
            this.ram_ViewProcesses = new MetroFramework.Controls.MetroButton();
            this.ram_ViewImages = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.ram_ViewImages);
            this.metroPanel1.Controls.Add(this.ram_ViewProcesses);
            this.metroPanel1.Controls.Add(this.ram_RunningApps);
            this.metroPanel1.Controls.Add(this.ram_analytics);
            this.metroPanel1.CustomBackground = false;
            this.metroPanel1.HorizontalScrollbar = false;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(-1, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(563, 412);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanel1.StyleManager = null;
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPanel1.VerticalScrollbar = false;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // ram_analytics
            // 
            this.ram_analytics.BackColor = System.Drawing.SystemColors.Info;
            this.ram_analytics.Location = new System.Drawing.Point(13, 12);
            this.ram_analytics.Multiline = true;
            this.ram_analytics.Name = "ram_analytics";
            this.ram_analytics.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ram_analytics.Size = new System.Drawing.Size(536, 338);
            this.ram_analytics.TabIndex = 2;
            // 
            // ram_RunningApps
            // 
            this.ram_RunningApps.Highlight = false;
            this.ram_RunningApps.Location = new System.Drawing.Point(72, 357);
            this.ram_RunningApps.Name = "ram_RunningApps";
            this.ram_RunningApps.Size = new System.Drawing.Size(125, 43);
            this.ram_RunningApps.Style = MetroFramework.MetroColorStyle.Blue;
            this.ram_RunningApps.StyleManager = null;
            this.ram_RunningApps.TabIndex = 3;
            this.ram_RunningApps.Text = "Running applications";
            this.ram_RunningApps.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ram_RunningApps.Click += new System.EventHandler(this.ram_RunningApps_Click);
            // 
            // ram_ViewProcesses
            // 
            this.ram_ViewProcesses.Highlight = false;
            this.ram_ViewProcesses.Location = new System.Drawing.Point(224, 357);
            this.ram_ViewProcesses.Name = "ram_ViewProcesses";
            this.ram_ViewProcesses.Size = new System.Drawing.Size(113, 43);
            this.ram_ViewProcesses.Style = MetroFramework.MetroColorStyle.Blue;
            this.ram_ViewProcesses.StyleManager = null;
            this.ram_ViewProcesses.TabIndex = 4;
            this.ram_ViewProcesses.Text = "View Processes";
            this.ram_ViewProcesses.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ram_ViewProcesses.Click += new System.EventHandler(this.ram_ViewProcesses_Click);
            // 
            // ram_ViewImages
            // 
            this.ram_ViewImages.Highlight = false;
            this.ram_ViewImages.Location = new System.Drawing.Point(365, 357);
            this.ram_ViewImages.Name = "ram_ViewImages";
            this.ram_ViewImages.Size = new System.Drawing.Size(115, 43);
            this.ram_ViewImages.Style = MetroFramework.MetroColorStyle.Blue;
            this.ram_ViewImages.StyleManager = null;
            this.ram_ViewImages.TabIndex = 5;
            this.ram_ViewImages.Text = "View Images";
            this.ram_ViewImages.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ram_ViewImages.Click += new System.EventHandler(this.ram_ViewImages_Click);
            // 
            // MemoryAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 411);
            this.Controls.Add(this.metroPanel1);
            this.Name = "MemoryAnalytics";
            this.Text = "MemoryAnalytics";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton ram_ViewImages;
        private MetroFramework.Controls.MetroButton ram_ViewProcesses;
        private MetroFramework.Controls.MetroButton ram_RunningApps;
        private System.Windows.Forms.TextBox ram_analytics;
    }
}