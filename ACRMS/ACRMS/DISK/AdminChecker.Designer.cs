namespace ACRMS.DISK
{
    partial class AdminChecker
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
            this.btnElevate = new MetroFramework.Controls.MetroButton();
            this.isUsrInAdminGroup = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblIntegrityLevel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lblIsProcessElevated = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.lblRunAsAdmin = new MetroFramework.Controls.MetroLabel();
            this.lblInAdminGroup = new MetroFramework.Controls.MetroLabel();
            this.btnLaunchWcf = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnElevate
            // 
            this.btnElevate.Highlight = false;
            this.btnElevate.Location = new System.Drawing.Point(43, 159);
            this.btnElevate.Name = "btnElevate";
            this.btnElevate.Size = new System.Drawing.Size(90, 30);
            this.btnElevate.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnElevate.StyleManager = null;
            this.btnElevate.TabIndex = 0;
            this.btnElevate.Text = "Elevate";
            this.btnElevate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnElevate.Click += new System.EventHandler(this.btnElevate_Click);
            // 
            // isUsrInAdminGroup
            // 
            this.isUsrInAdminGroup.AutoSize = true;
            this.isUsrInAdminGroup.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.isUsrInAdminGroup.CustomBackground = false;
            this.isUsrInAdminGroup.CustomForeColor = false;
            this.isUsrInAdminGroup.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.isUsrInAdminGroup.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.isUsrInAdminGroup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.isUsrInAdminGroup.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.isUsrInAdminGroup.Location = new System.Drawing.Point(12, 9);
            this.isUsrInAdminGroup.Name = "isUsrInAdminGroup";
            this.isUsrInAdminGroup.Size = new System.Drawing.Size(149, 19);
            this.isUsrInAdminGroup.Style = MetroFramework.MetroColorStyle.Blue;
            this.isUsrInAdminGroup.StyleManager = null;
            this.isUsrInAdminGroup.TabIndex = 1;
            this.isUsrInAdminGroup.Text = "User In Admin Group";
            this.isUsrInAdminGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.isUsrInAdminGroup.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.isUsrInAdminGroup.UseStyleColors = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel2.CustomBackground = false;
            this.metroLabel2.CustomForeColor = false;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel2.Location = new System.Drawing.Point(12, 115);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(105, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.StyleManager = null;
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Integrity Level";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseStyleColors = false;
            // 
            // lblIntegrityLevel
            // 
            this.lblIntegrityLevel.AutoSize = true;
            this.lblIntegrityLevel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIntegrityLevel.CustomBackground = false;
            this.lblIntegrityLevel.CustomForeColor = false;
            this.lblIntegrityLevel.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblIntegrityLevel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblIntegrityLevel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIntegrityLevel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblIntegrityLevel.Location = new System.Drawing.Point(181, 115);
            this.lblIntegrityLevel.Name = "lblIntegrityLevel";
            this.lblIntegrityLevel.Size = new System.Drawing.Size(94, 19);
            this.lblIntegrityLevel.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblIntegrityLevel.StyleManager = null;
            this.lblIntegrityLevel.TabIndex = 3;
            this.lblIntegrityLevel.Text = "metroLabel3";
            this.lblIntegrityLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIntegrityLevel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblIntegrityLevel.UseStyleColors = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel4.CustomBackground = false;
            this.metroLabel4.CustomForeColor = false;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel4.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel4.Location = new System.Drawing.Point(12, 77);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(121, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel4.StyleManager = null;
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Process Elevated";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseStyleColors = false;
            // 
            // lblIsProcessElevated
            // 
            this.lblIsProcessElevated.AutoSize = true;
            this.lblIsProcessElevated.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIsProcessElevated.CustomBackground = false;
            this.lblIsProcessElevated.CustomForeColor = false;
            this.lblIsProcessElevated.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblIsProcessElevated.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblIsProcessElevated.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIsProcessElevated.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblIsProcessElevated.Location = new System.Drawing.Point(181, 77);
            this.lblIsProcessElevated.Name = "lblIsProcessElevated";
            this.lblIsProcessElevated.Size = new System.Drawing.Size(94, 19);
            this.lblIsProcessElevated.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblIsProcessElevated.StyleManager = null;
            this.lblIsProcessElevated.TabIndex = 5;
            this.lblIsProcessElevated.Text = "metroLabel5";
            this.lblIsProcessElevated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIsProcessElevated.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblIsProcessElevated.UseStyleColors = false;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel6.CustomBackground = false;
            this.metroLabel6.CustomForeColor = false;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel6.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel6.Location = new System.Drawing.Point(12, 43);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(145, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel6.StyleManager = null;
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "Is Running As Admin";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel6.UseStyleColors = false;
            // 
            // lblRunAsAdmin
            // 
            this.lblRunAsAdmin.AutoSize = true;
            this.lblRunAsAdmin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRunAsAdmin.CustomBackground = false;
            this.lblRunAsAdmin.CustomForeColor = false;
            this.lblRunAsAdmin.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblRunAsAdmin.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblRunAsAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRunAsAdmin.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblRunAsAdmin.Location = new System.Drawing.Point(181, 43);
            this.lblRunAsAdmin.Name = "lblRunAsAdmin";
            this.lblRunAsAdmin.Size = new System.Drawing.Size(94, 19);
            this.lblRunAsAdmin.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblRunAsAdmin.StyleManager = null;
            this.lblRunAsAdmin.TabIndex = 7;
            this.lblRunAsAdmin.Text = "metroLabel7";
            this.lblRunAsAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRunAsAdmin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblRunAsAdmin.UseStyleColors = false;
            // 
            // lblInAdminGroup
            // 
            this.lblInAdminGroup.AutoSize = true;
            this.lblInAdminGroup.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblInAdminGroup.CustomBackground = false;
            this.lblInAdminGroup.CustomForeColor = false;
            this.lblInAdminGroup.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblInAdminGroup.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblInAdminGroup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInAdminGroup.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblInAdminGroup.Location = new System.Drawing.Point(181, 9);
            this.lblInAdminGroup.Name = "lblInAdminGroup";
            this.lblInAdminGroup.Size = new System.Drawing.Size(94, 19);
            this.lblInAdminGroup.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblInAdminGroup.StyleManager = null;
            this.lblInAdminGroup.TabIndex = 8;
            this.lblInAdminGroup.Text = "metroLabel8";
            this.lblInAdminGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInAdminGroup.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblInAdminGroup.UseStyleColors = false;
            // 
            // btnLaunchWcf
            // 
            this.btnLaunchWcf.Highlight = false;
            this.btnLaunchWcf.Location = new System.Drawing.Point(156, 159);
            this.btnLaunchWcf.Name = "btnLaunchWcf";
            this.btnLaunchWcf.Size = new System.Drawing.Size(90, 30);
            this.btnLaunchWcf.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnLaunchWcf.StyleManager = null;
            this.btnLaunchWcf.TabIndex = 9;
            this.btnLaunchWcf.Text = "WCF";
            this.btnLaunchWcf.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnLaunchWcf.Click += new System.EventHandler(this.btnLaunchWcf_Click);
            // 
            // AdminChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(309, 201);
            this.Controls.Add(this.btnLaunchWcf);
            this.Controls.Add(this.lblInAdminGroup);
            this.Controls.Add(this.lblRunAsAdmin);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.lblIsProcessElevated);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.lblIntegrityLevel);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.isUsrInAdminGroup);
            this.Controls.Add(this.btnElevate);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminChecker";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Admin Checker";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AdminChecker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnElevate;
        private MetroFramework.Controls.MetroLabel isUsrInAdminGroup;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblIntegrityLevel;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel lblIsProcessElevated;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel lblRunAsAdmin;
        private MetroFramework.Controls.MetroLabel lblInAdminGroup;
        private MetroFramework.Controls.MetroButton btnLaunchWcf;
    }
}