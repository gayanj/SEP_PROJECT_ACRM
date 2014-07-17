namespace SEPMetro
{
    partial class Configuration
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
            this.ram_alertTime = new MetroFramework.Controls.MetroTextBox();
            this.ram_alertPercentage = new MetroFramework.Controls.MetroTextBox();
            this.ram_apply = new MetroFramework.Controls.MetroButton();
            this.ram_alertHighMemory = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.ram_alertTime);
            this.metroPanel1.Controls.Add(this.ram_alertPercentage);
            this.metroPanel1.Controls.Add(this.ram_apply);
            this.metroPanel1.Controls.Add(this.ram_alertHighMemory);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.CustomBackground = false;
            this.metroPanel1.HorizontalScrollbar = false;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, -2);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(446, 233);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanel1.StyleManager = null;
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbar = false;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // ram_alertTime
            // 
            this.ram_alertTime.BackColor = System.Drawing.SystemColors.WindowText;
            this.ram_alertTime.CustomBackground = true;
            this.ram_alertTime.CustomForeColor = true;
            this.ram_alertTime.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.ram_alertTime.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.ram_alertTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ram_alertTime.Location = new System.Drawing.Point(318, 64);
            this.ram_alertTime.Multiline = false;
            this.ram_alertTime.Name = "ram_alertTime";
            this.ram_alertTime.SelectedText = "";
            this.ram_alertTime.Size = new System.Drawing.Size(116, 23);
            this.ram_alertTime.Style = MetroFramework.MetroColorStyle.Blue;
            this.ram_alertTime.StyleManager = null;
            this.ram_alertTime.TabIndex = 7;
            this.ram_alertTime.Text = "9999999";
            this.ram_alertTime.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ram_alertTime.UseStyleColors = false;
            // 
            // ram_alertPercentage
            // 
            this.ram_alertPercentage.BackColor = System.Drawing.SystemColors.WindowText;
            this.ram_alertPercentage.CustomBackground = true;
            this.ram_alertPercentage.CustomForeColor = true;
            this.ram_alertPercentage.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.ram_alertPercentage.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.ram_alertPercentage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ram_alertPercentage.Location = new System.Drawing.Point(318, 15);
            this.ram_alertPercentage.Multiline = false;
            this.ram_alertPercentage.Name = "ram_alertPercentage";
            this.ram_alertPercentage.SelectedText = "";
            this.ram_alertPercentage.Size = new System.Drawing.Size(116, 23);
            this.ram_alertPercentage.Style = MetroFramework.MetroColorStyle.Blue;
            this.ram_alertPercentage.StyleManager = null;
            this.ram_alertPercentage.TabIndex = 6;
            this.ram_alertPercentage.Text = "9999999";
            this.ram_alertPercentage.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ram_alertPercentage.UseStyleColors = false;
            // 
            // ram_apply
            // 
            this.ram_apply.Highlight = false;
            this.ram_apply.Location = new System.Drawing.Point(329, 157);
            this.ram_apply.Name = "ram_apply";
            this.ram_apply.Size = new System.Drawing.Size(75, 23);
            this.ram_apply.Style = MetroFramework.MetroColorStyle.Blue;
            this.ram_apply.StyleManager = null;
            this.ram_apply.TabIndex = 5;
            this.ram_apply.Text = "Apply";
            this.ram_apply.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ram_apply.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // ram_alertHighMemory
            // 
            this.ram_alertHighMemory.AutoSize = true;
            this.ram_alertHighMemory.BackColor = System.Drawing.SystemColors.WindowText;
            this.ram_alertHighMemory.CustomBackground = true;
            this.ram_alertHighMemory.CustomForeColor = true;
            this.ram_alertHighMemory.FontSize = MetroFramework.MetroLinkSize.Small;
            this.ram_alertHighMemory.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.ram_alertHighMemory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ram_alertHighMemory.Location = new System.Drawing.Point(12, 126);
            this.ram_alertHighMemory.Name = "ram_alertHighMemory";
            this.ram_alertHighMemory.Size = new System.Drawing.Size(242, 15);
            this.ram_alertHighMemory.Style = MetroFramework.MetroColorStyle.Blue;
            this.ram_alertHighMemory.StyleManager = null;
            this.ram_alertHighMemory.TabIndex = 4;
            this.ram_alertHighMemory.Text = "Alert for highest memory consuming app";
            this.ram_alertHighMemory.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ram_alertHighMemory.UseStyleColors = false;
            this.ram_alertHighMemory.UseVisualStyleBackColor = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.SystemColors.WindowText;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel2.Location = new System.Drawing.Point(12, 69);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(113, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.StyleManager = null;
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Alert time interval";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseStyleColors = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.SystemColors.WindowText;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(13, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(272, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Generate alert whenever RAM usage exceeds";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 228);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Configuration";
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.Configuration_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox ram_alertTime;
        private MetroFramework.Controls.MetroTextBox ram_alertPercentage;
        private MetroFramework.Controls.MetroButton ram_apply;
        private MetroFramework.Controls.MetroCheckBox ram_alertHighMemory;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}