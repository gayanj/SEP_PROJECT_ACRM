namespace ACRMS
{
    partial class ConnectToClient
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
            this.client_IPs = new MetroFramework.Controls.MetroTextBox();
            this.connect_Client = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // client_IPs
            // 
            this.client_IPs.CustomBackground = false;
            this.client_IPs.CustomForeColor = false;
            this.client_IPs.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.client_IPs.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.client_IPs.Location = new System.Drawing.Point(51, 63);
            this.client_IPs.Multiline = false;
            this.client_IPs.Name = "client_IPs";
            this.client_IPs.SelectedText = "";
            this.client_IPs.Size = new System.Drawing.Size(187, 23);
            this.client_IPs.Style = MetroFramework.MetroColorStyle.Blue;
            this.client_IPs.StyleManager = null;
            this.client_IPs.TabIndex = 0;
            this.client_IPs.Text = "localhost";
            this.client_IPs.Theme = MetroFramework.MetroThemeStyle.Light;
            this.client_IPs.UseStyleColors = false;
            // 
            // connect_Client
            // 
            this.connect_Client.Highlight = false;
            this.connect_Client.Location = new System.Drawing.Point(106, 103);
            this.connect_Client.Name = "connect_Client";
            this.connect_Client.Size = new System.Drawing.Size(75, 23);
            this.connect_Client.Style = MetroFramework.MetroColorStyle.Blue;
            this.connect_Client.StyleManager = null;
            this.connect_Client.TabIndex = 1;
            this.connect_Client.Text = "Connect";
            this.connect_Client.Theme = MetroFramework.MetroThemeStyle.Light;
            this.connect_Client.Click += new System.EventHandler(this.connect_Client_Click);
            // 
            // ConnectToClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.connect_Client);
            this.Controls.Add(this.client_IPs);
            this.Name = "ConnectToClient";
            this.Text = "ConnectToClient";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox client_IPs;
        private MetroFramework.Controls.MetroButton connect_Client;
    }
}