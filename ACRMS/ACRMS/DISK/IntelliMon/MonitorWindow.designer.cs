namespace ACRMS.DISK.IntelliMon
{
    partial class MonitorWindow
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
            this.lblTimer = new MetroFramework.Controls.MetroLabel();
            this.lblClientIp = new MetroFramework.Controls.MetroLabel();
            this.lblClientName = new MetroFramework.Controls.MetroLabel();
            this.btnStop = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.lblTimer);
            this.metroPanel1.Controls.Add(this.lblClientIp);
            this.metroPanel1.Controls.Add(this.lblClientName);
            this.metroPanel1.Controls.Add(this.btnStop);
            this.metroPanel1.CustomBackground = false;
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbar = false;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(231, 115);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanel1.StyleManager = null;
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbar = false;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.CustomBackground = false;
            this.lblTimer.CustomForeColor = true;
            this.lblTimer.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTimer.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblTimer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTimer.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblTimer.Location = new System.Drawing.Point(83, 9);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(74, 25);
            this.lblTimer.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblTimer.StyleManager = null;
            this.lblTimer.TabIndex = 5;
            this.lblTimer.Text = "00:00:00";
            this.lblTimer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblTimer.UseStyleColors = false;
            // 
            // lblClientIp
            // 
            this.lblClientIp.AutoSize = true;
            this.lblClientIp.CustomBackground = false;
            this.lblClientIp.CustomForeColor = true;
            this.lblClientIp.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblClientIp.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblClientIp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblClientIp.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblClientIp.Location = new System.Drawing.Point(121, 40);
            this.lblClientIp.Name = "lblClientIp";
            this.lblClientIp.Size = new System.Drawing.Size(26, 25);
            this.lblClientIp.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblClientIp.StyleManager = null;
            this.lblClientIp.TabIndex = 4;
            this.lblClientIp.Text = "IP";
            this.lblClientIp.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblClientIp.UseStyleColors = false;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.CustomBackground = false;
            this.lblClientName.CustomForeColor = true;
            this.lblClientName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblClientName.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblClientName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblClientName.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblClientName.Location = new System.Drawing.Point(12, 40);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(46, 25);
            this.lblClientName.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblClientName.StyleManager = null;
            this.lblClientName.TabIndex = 3;
            this.lblClientName.Text = "Host";
            this.lblClientName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblClientName.UseStyleColors = false;
            // 
            // btnStop
            // 
            this.btnStop.Highlight = false;
            this.btnStop.Location = new System.Drawing.Point(82, 80);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnStop.StyleManager = null;
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnStop.Click += new System.EventHandler(this.btnStop1_Click);
            // 
            // MonitorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(231, 115);
            this.ControlBox = false;
            this.Controls.Add(this.metroPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MonitorWindow";
            this.ShowIcon = false;
            this.Text = "Monitor Window";
            this.Load += new System.EventHandler(this.MonitorWindow_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnStop;
        private MetroFramework.Controls.MetroLabel lblTimer;
        private MetroFramework.Controls.MetroLabel lblClientIp;
        private MetroFramework.Controls.MetroLabel lblClientName;
    }
}