namespace ACRMS.DISK
{
    partial class SmartDataViewer
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
            this.btnGetSmart = new MetroFramework.Controls.MetroButton();
            this.dgvSmartData = new System.Windows.Forms.DataGridView();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSmartData)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.dgvSmartData);
            this.metroPanel1.Controls.Add(this.btnGetSmart);
            this.metroPanel1.CustomBackground = false;
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbar = false;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(877, 435);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanel1.StyleManager = null;
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbar = false;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnGetSmart
            // 
            this.btnGetSmart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGetSmart.Highlight = false;
            this.btnGetSmart.Location = new System.Drawing.Point(12, 393);
            this.btnGetSmart.Name = "btnGetSmart";
            this.btnGetSmart.Size = new System.Drawing.Size(150, 30);
            this.btnGetSmart.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnGetSmart.StyleManager = null;
            this.btnGetSmart.TabIndex = 2;
            this.btnGetSmart.Text = "Get S.M.A.R.T. Data";
            this.btnGetSmart.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnGetSmart.Click += new System.EventHandler(this.btnGetSmart_Click);
            // 
            // dgvSmartData
            // 
            this.dgvSmartData.AllowUserToAddRows = false;
            this.dgvSmartData.AllowUserToDeleteRows = false;
            this.dgvSmartData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSmartData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSmartData.Location = new System.Drawing.Point(12, 12);
            this.dgvSmartData.Name = "dgvSmartData";
            this.dgvSmartData.ReadOnly = true;
            this.dgvSmartData.Size = new System.Drawing.Size(853, 375);
            this.dgvSmartData.TabIndex = 3;
            // 
            // SmartDataViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 435);
            this.Controls.Add(this.metroPanel1);
            this.Name = "SmartDataViewer";
            this.Text = "SmartDataViewer";
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSmartData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnGetSmart;
        private System.Windows.Forms.DataGridView dgvSmartData;
    }
}