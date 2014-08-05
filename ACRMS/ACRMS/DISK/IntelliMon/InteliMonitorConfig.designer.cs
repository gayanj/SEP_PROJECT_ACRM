namespace ACRMS.DISK.IntelliMon
{
    partial class InteliMonitorConfig
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dgvWatchList = new System.Windows.Forms.DataGridView();
            this.StartMonitor = new System.Windows.Forms.DataGridViewButtonColumn();
            this.removeRow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.chngStatus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dsWatchlist = new System.Data.DataSet();
            this.clientList = new System.Data.DataTable();
            this.clientName = new System.Data.DataColumn();
            this.clientIp = new System.Data.DataColumn();
            this.addedBy = new System.Data.DataColumn();
            this.addedOn = new System.Data.DataColumn();
            this.state = new System.Data.DataColumn();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.groupConfig = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddClientMnul = new MetroFramework.Controls.MetroButton();
            this.btnManSearch = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHostIp = new System.Windows.Forms.Label();
            this.lblHostName = new System.Windows.Forms.Label();
            this.txtClientAddrs = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddClient = new MetroFramework.Controls.MetroButton();
            this.btnScanNetwork = new MetroFramework.Controls.MetroButton();
            this.listBoxClientList = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWatchList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWatchlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientList)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.groupConfig.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Red;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(248, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStatus.Size = new System.Drawing.Size(286, 31);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Monitoring for 0 Clients";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvWatchList
            // 
            this.dgvWatchList.AllowUserToAddRows = false;
            this.dgvWatchList.AllowUserToOrderColumns = true;
            this.dgvWatchList.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvWatchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWatchList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StartMonitor,
            this.removeRow,
            this.chngStatus});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWatchList.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvWatchList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWatchList.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvWatchList.Location = new System.Drawing.Point(3, 16);
            this.dgvWatchList.Name = "dgvWatchList";
            this.dgvWatchList.Size = new System.Drawing.Size(791, 232);
            this.dgvWatchList.TabIndex = 5;
            this.dgvWatchList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWatchList_CellContentClick);
            // 
            // StartMonitor
            // 
            this.StartMonitor.HeaderText = "Start";
            this.StartMonitor.Name = "StartMonitor";
            this.StartMonitor.Width = 50;
            // 
            // removeRow
            // 
            this.removeRow.HeaderText = "Remove Entry";
            this.removeRow.Name = "removeRow";
            // 
            // chngStatus
            // 
            this.chngStatus.HeaderText = "Enable/Disable";
            this.chngStatus.Name = "chngStatus";
            // 
            // dsWatchlist
            // 
            this.dsWatchlist.DataSetName = "NewDataSet";
            this.dsWatchlist.Tables.AddRange(new System.Data.DataTable[] {
            this.clientList});
            // 
            // clientList
            // 
            this.clientList.Columns.AddRange(new System.Data.DataColumn[] {
            this.clientName,
            this.clientIp,
            this.addedBy,
            this.addedOn,
            this.state});
            this.clientList.TableName = "clientList";
            // 
            // clientName
            // 
            this.clientName.AllowDBNull = false;
            this.clientName.ColumnName = "Name";
            // 
            // clientIp
            // 
            this.clientIp.AllowDBNull = false;
            this.clientIp.ColumnName = "IP";
            // 
            // addedBy
            // 
            this.addedBy.AllowDBNull = false;
            this.addedBy.ColumnName = "Added By";
            // 
            // addedOn
            // 
            this.addedOn.AllowDBNull = false;
            this.addedOn.ColumnName = "Added On";
            // 
            // state
            // 
            this.state.AllowDBNull = false;
            this.state.ColumnName = "Monitoring";
            this.state.DataType = typeof(bool);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.groupBox2);
            this.metroPanel1.Controls.Add(this.groupConfig);
            this.metroPanel1.CustomBackground = false;
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbar = false;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(817, 579);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanel1.StyleManager = null;
            this.metroPanel1.TabIndex = 6;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbar = false;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // groupConfig
            // 
            this.groupConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupConfig.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupConfig.Controls.Add(this.groupBox3);
            this.groupConfig.Controls.Add(this.groupBox1);
            this.groupConfig.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupConfig.Location = new System.Drawing.Point(12, 43);
            this.groupConfig.Name = "groupConfig";
            this.groupConfig.Size = new System.Drawing.Size(797, 265);
            this.groupConfig.TabIndex = 4;
            this.groupConfig.TabStop = false;
            this.groupConfig.Text = "Configure";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnAddClientMnul);
            this.groupBox3.Controls.Add(this.btnManSearch);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lblHostIp);
            this.groupBox3.Controls.Add(this.lblHostName);
            this.groupBox3.Controls.Add(this.txtClientAddrs);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(414, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(377, 240);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Known Clients";
            // 
            // btnAddClientMnul
            // 
            this.btnAddClientMnul.Highlight = false;
            this.btnAddClientMnul.Location = new System.Drawing.Point(296, 185);
            this.btnAddClientMnul.Name = "btnAddClientMnul";
            this.btnAddClientMnul.Size = new System.Drawing.Size(75, 23);
            this.btnAddClientMnul.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAddClientMnul.StyleManager = null;
            this.btnAddClientMnul.TabIndex = 8;
            this.btnAddClientMnul.Text = "Add";
            this.btnAddClientMnul.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddClientMnul.Click += new System.EventHandler(this.btnAddClientMnul_Click);
            // 
            // btnManSearch
            // 
            this.btnManSearch.Highlight = false;
            this.btnManSearch.Location = new System.Drawing.Point(200, 20);
            this.btnManSearch.Name = "btnManSearch";
            this.btnManSearch.Size = new System.Drawing.Size(75, 23);
            this.btnManSearch.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnManSearch.StyleManager = null;
            this.btnManSearch.TabIndex = 7;
            this.btnManSearch.Text = "Validate";
            this.btnManSearch.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnManSearch.Click += new System.EventHandler(this.btnManSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Client IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Client Name";
            // 
            // lblHostIp
            // 
            this.lblHostIp.AutoSize = true;
            this.lblHostIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostIp.Location = new System.Drawing.Point(115, 136);
            this.lblHostIp.Name = "lblHostIp";
            this.lblHostIp.Size = new System.Drawing.Size(29, 20);
            this.lblHostIp.TabIndex = 3;
            this.lblHostIp.Text = "----";
            // 
            // lblHostName
            // 
            this.lblHostName.AutoSize = true;
            this.lblHostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostName.Location = new System.Drawing.Point(115, 83);
            this.lblHostName.Name = "lblHostName";
            this.lblHostName.Size = new System.Drawing.Size(29, 20);
            this.lblHostName.TabIndex = 2;
            this.lblHostName.Text = "----";
            // 
            // txtClientAddrs
            // 
            this.txtClientAddrs.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtClientAddrs.ForeColor = System.Drawing.SystemColors.Window;
            this.txtClientAddrs.Location = new System.Drawing.Point(7, 20);
            this.txtClientAddrs.Name = "txtClientAddrs";
            this.txtClientAddrs.Size = new System.Drawing.Size(187, 20);
            this.txtClientAddrs.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddClient);
            this.groupBox1.Controls.Add(this.btnScanNetwork);
            this.groupBox1.Controls.Add(this.listBoxClientList);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 240);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search For Clients";
            // 
            // btnAddClient
            // 
            this.btnAddClient.Highlight = false;
            this.btnAddClient.Location = new System.Drawing.Point(321, 185);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(75, 23);
            this.btnAddClient.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAddClient.StyleManager = null;
            this.btnAddClient.TabIndex = 7;
            this.btnAddClient.Text = "Add";
            this.btnAddClient.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnScanNetwork
            // 
            this.btnScanNetwork.Highlight = false;
            this.btnScanNetwork.Location = new System.Drawing.Point(6, 20);
            this.btnScanNetwork.Name = "btnScanNetwork";
            this.btnScanNetwork.Size = new System.Drawing.Size(75, 23);
            this.btnScanNetwork.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnScanNetwork.StyleManager = null;
            this.btnScanNetwork.TabIndex = 6;
            this.btnScanNetwork.Text = "Scan";
            this.btnScanNetwork.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnScanNetwork.Click += new System.EventHandler(this.btnScanNetwork_Click);
            // 
            // listBoxClientList
            // 
            this.listBoxClientList.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listBoxClientList.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxClientList.ForeColor = System.Drawing.SystemColors.Window;
            this.listBoxClientList.FormattingEnabled = true;
            this.listBoxClientList.ItemHeight = 18;
            this.listBoxClientList.Location = new System.Drawing.Point(6, 48);
            this.listBoxClientList.Name = "listBoxClientList";
            this.listBoxClientList.Size = new System.Drawing.Size(309, 148);
            this.listBoxClientList.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Controls.Add(this.dgvWatchList);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(12, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(797, 251);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Watchlist";
            // 
            // InteliMonitorConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(817, 579);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.metroPanel1);
            this.Name = "InteliMonitorConfig";
            this.ShowIcon = false;
            this.Text = "Intelli Monitor - Configure";
            this.Load += new System.EventHandler(this.InteliMonitorConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWatchList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWatchlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientList)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.groupConfig.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridView dgvWatchList;
        private System.Data.DataSet dsWatchlist;
        private System.Data.DataTable clientList;
        private System.Data.DataColumn clientName;
        private System.Data.DataColumn clientIp;
        private System.Data.DataColumn addedBy;
        private System.Data.DataColumn addedOn;
        private System.Data.DataColumn state;
        private System.Windows.Forms.DataGridViewButtonColumn StartMonitor;
        private System.Windows.Forms.DataGridViewButtonColumn removeRow;
        private System.Windows.Forms.DataGridViewButtonColumn chngStatus;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.GroupBox groupConfig;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroButton btnAddClientMnul;
        private MetroFramework.Controls.MetroButton btnManSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHostIp;
        private System.Windows.Forms.Label lblHostName;
        private System.Windows.Forms.TextBox txtClientAddrs;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnAddClient;
        private MetroFramework.Controls.MetroButton btnScanNetwork;
        private System.Windows.Forms.ListBox listBoxClientList;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}