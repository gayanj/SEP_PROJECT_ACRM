﻿namespace ACRM.HDisk.IntelliMon
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.listBoxClientList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnScanNetwork = new System.Windows.Forms.Button();
            this.groupConfig = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnManSearch = new System.Windows.Forms.Button();
            this.lblHostIp = new System.Windows.Forms.Label();
            this.lblHostName = new System.Windows.Forms.Label();
            this.btnAddClientMnul = new System.Windows.Forms.Button();
            this.txtClientAddrs = new System.Windows.Forms.TextBox();
            this.dgvWatchList = new System.Windows.Forms.DataGridView();
            this.StartMonitor = new System.Windows.Forms.DataGridViewButtonColumn();
            this.removeRow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.chngStatus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupWatchList = new System.Windows.Forms.GroupBox();
            this.dsWatchlist = new System.Data.DataSet();
            this.clientList = new System.Data.DataTable();
            this.clientName = new System.Data.DataColumn();
            this.clientIp = new System.Data.DataColumn();
            this.addedBy = new System.Data.DataColumn();
            this.addedOn = new System.Data.DataColumn();
            this.state = new System.Data.DataColumn();
            this.groupBox1.SuspendLayout();
            this.groupConfig.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWatchList)).BeginInit();
            this.groupWatchList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsWatchlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
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
            // listBoxClientList
            // 
            this.listBoxClientList.FormattingEnabled = true;
            this.listBoxClientList.Location = new System.Drawing.Point(6, 48);
            this.listBoxClientList.Name = "listBoxClientList";
            this.listBoxClientList.Size = new System.Drawing.Size(188, 238);
            this.listBoxClientList.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnAddClient);
            this.groupBox1.Controls.Add(this.btnScanNetwork);
            this.groupBox1.Controls.Add(this.listBoxClientList);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 325);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search For Clients";
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(119, 296);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(75, 23);
            this.btnAddClient.TabIndex = 5;
            this.btnAddClient.Text = "Add";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnScanNetwork
            // 
            this.btnScanNetwork.Location = new System.Drawing.Point(6, 19);
            this.btnScanNetwork.Name = "btnScanNetwork";
            this.btnScanNetwork.Size = new System.Drawing.Size(75, 23);
            this.btnScanNetwork.TabIndex = 3;
            this.btnScanNetwork.Text = "Scan";
            this.btnScanNetwork.UseVisualStyleBackColor = true;
            this.btnScanNetwork.Click += new System.EventHandler(this.btnScanNetwork_Click);
            // 
            // groupConfig
            // 
            this.groupConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupConfig.Controls.Add(this.groupBox2);
            this.groupConfig.Controls.Add(this.groupBox3);
            this.groupConfig.Controls.Add(this.groupBox1);
            this.groupConfig.Location = new System.Drawing.Point(12, 48);
            this.groupConfig.Name = "groupConfig";
            this.groupConfig.Size = new System.Drawing.Size(777, 350);
            this.groupConfig.TabIndex = 4;
            this.groupConfig.TabStop = false;
            this.groupConfig.Text = "Configure";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(485, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 325);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search The Watchlist";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnManSearch);
            this.groupBox3.Controls.Add(this.lblHostIp);
            this.groupBox3.Controls.Add(this.lblHostName);
            this.groupBox3.Controls.Add(this.btnAddClientMnul);
            this.groupBox3.Controls.Add(this.txtClientAddrs);
            this.groupBox3.Location = new System.Drawing.Point(212, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 325);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Known Clients";
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
            // btnManSearch
            // 
            this.btnManSearch.Location = new System.Drawing.Point(119, 46);
            this.btnManSearch.Name = "btnManSearch";
            this.btnManSearch.Size = new System.Drawing.Size(75, 23);
            this.btnManSearch.TabIndex = 4;
            this.btnManSearch.Text = "Validate";
            this.btnManSearch.UseVisualStyleBackColor = true;
            this.btnManSearch.Click += new System.EventHandler(this.btnManSearch_Click);
            // 
            // lblHostIp
            // 
            this.lblHostIp.AutoSize = true;
            this.lblHostIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostIp.Location = new System.Drawing.Point(80, 163);
            this.lblHostIp.Name = "lblHostIp";
            this.lblHostIp.Size = new System.Drawing.Size(51, 20);
            this.lblHostIp.TabIndex = 3;
            this.lblHostIp.Text = "label1";
            // 
            // lblHostName
            // 
            this.lblHostName.AutoSize = true;
            this.lblHostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostName.Location = new System.Drawing.Point(80, 113);
            this.lblHostName.Name = "lblHostName";
            this.lblHostName.Size = new System.Drawing.Size(51, 20);
            this.lblHostName.TabIndex = 2;
            this.lblHostName.Text = "label1";
            // 
            // btnAddClientMnul
            // 
            this.btnAddClientMnul.Location = new System.Drawing.Point(119, 296);
            this.btnAddClientMnul.Name = "btnAddClientMnul";
            this.btnAddClientMnul.Size = new System.Drawing.Size(75, 23);
            this.btnAddClientMnul.TabIndex = 1;
            this.btnAddClientMnul.Text = "Add";
            this.btnAddClientMnul.UseVisualStyleBackColor = true;
            this.btnAddClientMnul.Click += new System.EventHandler(this.btnAddClientMnul_Click);
            // 
            // txtClientAddrs
            // 
            this.txtClientAddrs.Location = new System.Drawing.Point(7, 20);
            this.txtClientAddrs.Name = "txtClientAddrs";
            this.txtClientAddrs.Size = new System.Drawing.Size(187, 20);
            this.txtClientAddrs.TabIndex = 0;
            // 
            // dgvWatchList
            // 
            this.dgvWatchList.AllowUserToAddRows = false;
            this.dgvWatchList.AllowUserToOrderColumns = true;
            this.dgvWatchList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvWatchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWatchList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StartMonitor,
            this.removeRow,
            this.chngStatus});
            this.dgvWatchList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWatchList.Location = new System.Drawing.Point(3, 16);
            this.dgvWatchList.Name = "dgvWatchList";
            this.dgvWatchList.Size = new System.Drawing.Size(795, 233);
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
            // groupWatchList
            // 
            this.groupWatchList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupWatchList.Controls.Add(this.dgvWatchList);
            this.groupWatchList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupWatchList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupWatchList.Location = new System.Drawing.Point(0, 407);
            this.groupWatchList.Name = "groupWatchList";
            this.groupWatchList.Size = new System.Drawing.Size(801, 252);
            this.groupWatchList.TabIndex = 5;
            this.groupWatchList.TabStop = false;
            this.groupWatchList.Text = "Watchlist";
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
            // InteliMonitorConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(801, 659);
            this.Controls.Add(this.groupWatchList);
            this.Controls.Add(this.groupConfig);
            this.Controls.Add(this.lblStatus);
            this.Name = "InteliMonitorConfig";
            this.Text = "InteliMonitorConfig";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InteliMonitorConfig_FormClosing);
            this.Load += new System.EventHandler(this.InteliMonitorConfig_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupConfig.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWatchList)).EndInit();
            this.groupWatchList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsWatchlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ListBox listBoxClientList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnScanNetwork;
        private System.Windows.Forms.GroupBox groupConfig;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddClientMnul;
        private System.Windows.Forms.TextBox txtClientAddrs;
        private System.Windows.Forms.DataGridView dgvWatchList;
        private System.Windows.Forms.Label lblHostIp;
        private System.Windows.Forms.Label lblHostName;
        private System.Windows.Forms.GroupBox groupWatchList;
        private System.Data.DataSet dsWatchlist;
        private System.Data.DataTable clientList;
        private System.Data.DataColumn clientName;
        private System.Data.DataColumn clientIp;
        private System.Windows.Forms.Button btnManSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Data.DataColumn addedBy;
        private System.Data.DataColumn addedOn;
        private System.Data.DataColumn state;
        private System.Windows.Forms.DataGridViewButtonColumn StartMonitor;
        private System.Windows.Forms.DataGridViewButtonColumn removeRow;
        private System.Windows.Forms.DataGridViewButtonColumn chngStatus;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}