namespace ACRM
{
    partial class ACRMForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cpuChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.phyDiskInfGBox = new System.Windows.Forms.GroupBox();
            this.hdlb14 = new System.Windows.Forms.Label();
            this.hdlb13 = new System.Windows.Forms.Label();
            this.hdlb12 = new System.Windows.Forms.Label();
            this.hdlb11 = new System.Windows.Forms.Label();
            this.hdlb10 = new System.Windows.Forms.Label();
            this.hdlb9 = new System.Windows.Forms.Label();
            this.hdlb8 = new System.Windows.Forms.Label();
            this.hdlb7 = new System.Windows.Forms.Label();
            this.hdlb6 = new System.Windows.Forms.Label();
            this.hdlb5 = new System.Windows.Forms.Label();
            this.hdlb4 = new System.Windows.Forms.Label();
            this.hdlb3 = new System.Windows.Forms.Label();
            this.hdlb2 = new System.Windows.Forms.Label();
            this.hdlb1 = new System.Windows.Forms.Label();
            this.lblSig = new System.Windows.Forms.Label();
            this.lblTrackPerCyl = new System.Windows.Forms.Label();
            this.lblSecPerTrack = new System.Windows.Forms.Label();
            this.lblBperSec = new System.Windows.Forms.Label();
            this.lblTracks = new System.Windows.Forms.Label();
            this.lblHeads = new System.Windows.Forms.Label();
            this.lblSectors = new System.Windows.Forms.Label();
            this.lblCylinder = new System.Windows.Forms.Label();
            this.lblFirmware = new System.Windows.Forms.Label();
            this.lblPartitions = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblInterface = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblSerial = new System.Windows.Forms.Label();
            this.phyDiskComBox = new System.Windows.Forms.ComboBox();
            this.volInfGBox = new System.Windows.Forms.GroupBox();
            this.driveListCombo = new System.Windows.Forms.ComboBox();
            this.dStatLbl = new System.Windows.Forms.Label();
            this.hdlb15 = new System.Windows.Forms.Label();
            this.hdlb22 = new System.Windows.Forms.Label();
            this.hdlb16 = new System.Windows.Forms.Label();
            this.totAvaLbl = new System.Windows.Forms.Label();
            this.hdlb17 = new System.Windows.Forms.Label();
            this.totFreeLbl = new System.Windows.Forms.Label();
            this.hdlb18 = new System.Windows.Forms.Label();
            this.totSizeLbl = new System.Windows.Forms.Label();
            this.hdlb19 = new System.Windows.Forms.Label();
            this.dFormatLbl = new System.Windows.Forms.Label();
            this.hdlb20 = new System.Windows.Forms.Label();
            this.dTypeLbl = new System.Windows.Forms.Label();
            this.hdlb21 = new System.Windows.Forms.Label();
            this.volLbl = new System.Windows.Forms.Label();
            this.dNameLbl = new System.Windows.Forms.Label();
            this.xtraFuncGBox = new System.Windows.Forms.GroupBox();
            this.btnDiskPerf = new System.Windows.Forms.Button();
            this.fileSysMonBtn = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.processName = new System.Windows.Forms.Label();
            this.processNameValue = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.phyDiskInfGBox.SuspendLayout();
            this.volInfGBox.SuspendLayout();
            this.xtraFuncGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(862, 563);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.processNameValue);
            this.tabPage1.Controls.Add(this.processName);
            this.tabPage1.Controls.Add(this.cpuChart);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(854, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CPU";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cpuChart
            // 
            this.cpuChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.cpuChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.cpuChart.Legends.Add(legend1);
            this.cpuChart.Location = new System.Drawing.Point(376, 35);
            this.cpuChart.Name = "cpuChart";
            this.cpuChart.Size = new System.Drawing.Size(470, 494);
            this.cpuChart.TabIndex = 9;
            this.cpuChart.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Stop Monitoring";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(362, 494);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Start Monitoring";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(797, 537);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RAM";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.phyDiskInfGBox);
            this.tabPage3.Controls.Add(this.volInfGBox);
            this.tabPage3.Controls.Add(this.xtraFuncGBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(797, 537);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hard Disk";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // phyDiskInfGBox
            // 
            this.phyDiskInfGBox.Controls.Add(this.hdlb14);
            this.phyDiskInfGBox.Controls.Add(this.hdlb13);
            this.phyDiskInfGBox.Controls.Add(this.hdlb12);
            this.phyDiskInfGBox.Controls.Add(this.hdlb11);
            this.phyDiskInfGBox.Controls.Add(this.hdlb10);
            this.phyDiskInfGBox.Controls.Add(this.hdlb9);
            this.phyDiskInfGBox.Controls.Add(this.hdlb8);
            this.phyDiskInfGBox.Controls.Add(this.hdlb7);
            this.phyDiskInfGBox.Controls.Add(this.hdlb6);
            this.phyDiskInfGBox.Controls.Add(this.hdlb5);
            this.phyDiskInfGBox.Controls.Add(this.hdlb4);
            this.phyDiskInfGBox.Controls.Add(this.hdlb3);
            this.phyDiskInfGBox.Controls.Add(this.hdlb2);
            this.phyDiskInfGBox.Controls.Add(this.hdlb1);
            this.phyDiskInfGBox.Controls.Add(this.lblSig);
            this.phyDiskInfGBox.Controls.Add(this.lblTrackPerCyl);
            this.phyDiskInfGBox.Controls.Add(this.lblSecPerTrack);
            this.phyDiskInfGBox.Controls.Add(this.lblBperSec);
            this.phyDiskInfGBox.Controls.Add(this.lblTracks);
            this.phyDiskInfGBox.Controls.Add(this.lblHeads);
            this.phyDiskInfGBox.Controls.Add(this.lblSectors);
            this.phyDiskInfGBox.Controls.Add(this.lblCylinder);
            this.phyDiskInfGBox.Controls.Add(this.lblFirmware);
            this.phyDiskInfGBox.Controls.Add(this.lblPartitions);
            this.phyDiskInfGBox.Controls.Add(this.lblCapacity);
            this.phyDiskInfGBox.Controls.Add(this.lblInterface);
            this.phyDiskInfGBox.Controls.Add(this.lblModel);
            this.phyDiskInfGBox.Controls.Add(this.lblSerial);
            this.phyDiskInfGBox.Controls.Add(this.phyDiskComBox);
            this.phyDiskInfGBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.phyDiskInfGBox.Location = new System.Drawing.Point(3, 3);
            this.phyDiskInfGBox.Name = "phyDiskInfGBox";
            this.phyDiskInfGBox.Size = new System.Drawing.Size(402, 531);
            this.phyDiskInfGBox.TabIndex = 22;
            this.phyDiskInfGBox.TabStop = false;
            this.phyDiskInfGBox.Text = "Physical Disk Info";
            // 
            // hdlb14
            // 
            this.hdlb14.AutoSize = true;
            this.hdlb14.Location = new System.Drawing.Point(6, 347);
            this.hdlb14.Name = "hdlb14";
            this.hdlb14.Size = new System.Drawing.Size(99, 13);
            this.hdlb14.TabIndex = 49;
            this.hdlb14.Text = "Tracks Per Cylinder";
            // 
            // hdlb13
            // 
            this.hdlb13.AutoSize = true;
            this.hdlb13.Location = new System.Drawing.Point(6, 324);
            this.hdlb13.Name = "hdlb13";
            this.hdlb13.Size = new System.Drawing.Size(93, 13);
            this.hdlb13.TabIndex = 48;
            this.hdlb13.Text = "Sectors Per Track";
            // 
            // hdlb12
            // 
            this.hdlb12.AutoSize = true;
            this.hdlb12.Location = new System.Drawing.Point(6, 302);
            this.hdlb12.Name = "hdlb12";
            this.hdlb12.Size = new System.Drawing.Size(86, 13);
            this.hdlb12.TabIndex = 47;
            this.hdlb12.Text = "Bytes Per Sector";
            // 
            // hdlb11
            // 
            this.hdlb11.AutoSize = true;
            this.hdlb11.Location = new System.Drawing.Point(6, 279);
            this.hdlb11.Name = "hdlb11";
            this.hdlb11.Size = new System.Drawing.Size(72, 13);
            this.hdlb11.TabIndex = 46;
            this.hdlb11.Text = "No. of Tracks";
            // 
            // hdlb10
            // 
            this.hdlb10.AutoSize = true;
            this.hdlb10.Location = new System.Drawing.Point(6, 257);
            this.hdlb10.Name = "hdlb10";
            this.hdlb10.Size = new System.Drawing.Size(70, 13);
            this.hdlb10.TabIndex = 45;
            this.hdlb10.Text = "No. of Heads";
            // 
            // hdlb9
            // 
            this.hdlb9.AutoSize = true;
            this.hdlb9.Location = new System.Drawing.Point(6, 235);
            this.hdlb9.Name = "hdlb9";
            this.hdlb9.Size = new System.Drawing.Size(75, 13);
            this.hdlb9.TabIndex = 44;
            this.hdlb9.Text = "No. of Sectors";
            // 
            // hdlb8
            // 
            this.hdlb8.AutoSize = true;
            this.hdlb8.Location = new System.Drawing.Point(6, 211);
            this.hdlb8.Name = "hdlb8";
            this.hdlb8.Size = new System.Drawing.Size(81, 13);
            this.hdlb8.TabIndex = 43;
            this.hdlb8.Text = "No. of Cylinders";
            // 
            // hdlb7
            // 
            this.hdlb7.AutoSize = true;
            this.hdlb7.Location = new System.Drawing.Point(6, 189);
            this.hdlb7.Name = "hdlb7";
            this.hdlb7.Size = new System.Drawing.Size(93, 13);
            this.hdlb7.TabIndex = 42;
            this.hdlb7.Text = "Firmware Revision";
            // 
            // hdlb6
            // 
            this.hdlb6.AutoSize = true;
            this.hdlb6.Location = new System.Drawing.Point(6, 166);
            this.hdlb6.Name = "hdlb6";
            this.hdlb6.Size = new System.Drawing.Size(52, 13);
            this.hdlb6.TabIndex = 41;
            this.hdlb6.Text = "Signature";
            // 
            // hdlb5
            // 
            this.hdlb5.AutoSize = true;
            this.hdlb5.Location = new System.Drawing.Point(6, 143);
            this.hdlb5.Name = "hdlb5";
            this.hdlb5.Size = new System.Drawing.Size(82, 13);
            this.hdlb5.TabIndex = 40;
            this.hdlb5.Text = "No. of Partitions";
            // 
            // hdlb4
            // 
            this.hdlb4.AutoSize = true;
            this.hdlb4.Location = new System.Drawing.Point(6, 121);
            this.hdlb4.Name = "hdlb4";
            this.hdlb4.Size = new System.Drawing.Size(72, 13);
            this.hdlb4.TabIndex = 39;
            this.hdlb4.Text = "Disk Capacity";
            // 
            // hdlb3
            // 
            this.hdlb3.AutoSize = true;
            this.hdlb3.Location = new System.Drawing.Point(6, 99);
            this.hdlb3.Name = "hdlb3";
            this.hdlb3.Size = new System.Drawing.Size(76, 13);
            this.hdlb3.TabIndex = 38;
            this.hdlb3.Text = "Interface Type";
            // 
            // hdlb2
            // 
            this.hdlb2.AutoSize = true;
            this.hdlb2.Location = new System.Drawing.Point(6, 77);
            this.hdlb2.Name = "hdlb2";
            this.hdlb2.Size = new System.Drawing.Size(57, 13);
            this.hdlb2.TabIndex = 37;
            this.hdlb2.Text = "Disk Serial";
            // 
            // hdlb1
            // 
            this.hdlb1.AutoSize = true;
            this.hdlb1.Location = new System.Drawing.Point(6, 53);
            this.hdlb1.Name = "hdlb1";
            this.hdlb1.Size = new System.Drawing.Size(60, 13);
            this.hdlb1.TabIndex = 36;
            this.hdlb1.Text = "Disk Model";
            // 
            // lblSig
            // 
            this.lblSig.AutoSize = true;
            this.lblSig.Location = new System.Drawing.Point(165, 165);
            this.lblSig.Name = "lblSig";
<<<<<<< HEAD:ACRM/ACRM/ACRMForm.Designer.cs
            this.lblSig.Size = new System.Drawing.Size(16, 13);
            this.lblSig.TabIndex = 35;
            this.lblSig.Text = "---";
=======
            this.lblSig.Size = new System.Drawing.Size(19, 13);
            this.lblSig.TabIndex = 35;
            this.lblSig.Text = "----";
>>>>>>> 617b520078dc133d7b90c7b7dc2b12260abd04fc:ACRM/ACRM/Form1.Designer.cs
            // 
            // lblTrackPerCyl
            // 
            this.lblTrackPerCyl.AutoSize = true;
            this.lblTrackPerCyl.Location = new System.Drawing.Point(165, 347);
            this.lblTrackPerCyl.Name = "lblTrackPerCyl";
<<<<<<< HEAD:ACRM/ACRM/ACRMForm.Designer.cs
            this.lblTrackPerCyl.Size = new System.Drawing.Size(16, 13);
            this.lblTrackPerCyl.TabIndex = 34;
            this.lblTrackPerCyl.Text = "---";
=======
            this.lblTrackPerCyl.Size = new System.Drawing.Size(19, 13);
            this.lblTrackPerCyl.TabIndex = 34;
            this.lblTrackPerCyl.Text = "----";
>>>>>>> 617b520078dc133d7b90c7b7dc2b12260abd04fc:ACRM/ACRM/Form1.Designer.cs
            // 
            // lblSecPerTrack
            // 
            this.lblSecPerTrack.AutoSize = true;
            this.lblSecPerTrack.Location = new System.Drawing.Point(165, 324);
            this.lblSecPerTrack.Name = "lblSecPerTrack";
<<<<<<< HEAD:ACRM/ACRM/ACRMForm.Designer.cs
            this.lblSecPerTrack.Size = new System.Drawing.Size(16, 13);
            this.lblSecPerTrack.TabIndex = 33;
            this.lblSecPerTrack.Text = "---";
=======
            this.lblSecPerTrack.Size = new System.Drawing.Size(19, 13);
            this.lblSecPerTrack.TabIndex = 33;
            this.lblSecPerTrack.Text = "----";
>>>>>>> 617b520078dc133d7b90c7b7dc2b12260abd04fc:ACRM/ACRM/Form1.Designer.cs
            // 
            // lblBperSec
            // 
            this.lblBperSec.AutoSize = true;
            this.lblBperSec.Location = new System.Drawing.Point(165, 302);
            this.lblBperSec.Name = "lblBperSec";
<<<<<<< HEAD:ACRM/ACRM/ACRMForm.Designer.cs
            this.lblBperSec.Size = new System.Drawing.Size(16, 13);
            this.lblBperSec.TabIndex = 32;
            this.lblBperSec.Text = "---";
=======
            this.lblBperSec.Size = new System.Drawing.Size(19, 13);
            this.lblBperSec.TabIndex = 32;
            this.lblBperSec.Text = "----";
>>>>>>> 617b520078dc133d7b90c7b7dc2b12260abd04fc:ACRM/ACRM/Form1.Designer.cs
            // 
            // lblTracks
            // 
            this.lblTracks.AutoSize = true;
            this.lblTracks.Location = new System.Drawing.Point(165, 279);
            this.lblTracks.Name = "lblTracks";
<<<<<<< HEAD:ACRM/ACRM/ACRMForm.Designer.cs
            this.lblTracks.Size = new System.Drawing.Size(16, 13);
            this.lblTracks.TabIndex = 31;
            this.lblTracks.Text = "---";
=======
            this.lblTracks.Size = new System.Drawing.Size(19, 13);
            this.lblTracks.TabIndex = 31;
            this.lblTracks.Text = "----";
>>>>>>> 617b520078dc133d7b90c7b7dc2b12260abd04fc:ACRM/ACRM/Form1.Designer.cs
            // 
            // lblHeads
            // 
            this.lblHeads.AutoSize = true;
            this.lblHeads.Location = new System.Drawing.Point(165, 257);
            this.lblHeads.Name = "lblHeads";
<<<<<<< HEAD:ACRM/ACRM/ACRMForm.Designer.cs
            this.lblHeads.Size = new System.Drawing.Size(16, 13);
            this.lblHeads.TabIndex = 30;
            this.lblHeads.Text = "---";
=======
            this.lblHeads.Size = new System.Drawing.Size(19, 13);
            this.lblHeads.TabIndex = 30;
            this.lblHeads.Text = "----";
>>>>>>> 617b520078dc133d7b90c7b7dc2b12260abd04fc:ACRM/ACRM/Form1.Designer.cs
            // 
            // lblSectors
            // 
            this.lblSectors.AutoSize = true;
            this.lblSectors.Location = new System.Drawing.Point(165, 235);
            this.lblSectors.Name = "lblSectors";
<<<<<<< HEAD:ACRM/ACRM/ACRMForm.Designer.cs
            this.lblSectors.Size = new System.Drawing.Size(16, 13);
            this.lblSectors.TabIndex = 29;
            this.lblSectors.Text = "---";
=======
            this.lblSectors.Size = new System.Drawing.Size(19, 13);
            this.lblSectors.TabIndex = 29;
            this.lblSectors.Text = "----";
>>>>>>> 617b520078dc133d7b90c7b7dc2b12260abd04fc:ACRM/ACRM/Form1.Designer.cs
            // 
            // lblCylinder
            // 
            this.lblCylinder.AutoSize = true;
            this.lblCylinder.Location = new System.Drawing.Point(165, 210);
            this.lblCylinder.Name = "lblCylinder";
<<<<<<< HEAD:ACRM/ACRM/ACRMForm.Designer.cs
            this.lblCylinder.Size = new System.Drawing.Size(16, 13);
            this.lblCylinder.TabIndex = 28;
            this.lblCylinder.Text = "---";
=======
            this.lblCylinder.Size = new System.Drawing.Size(19, 13);
            this.lblCylinder.TabIndex = 28;
            this.lblCylinder.Text = "----";
>>>>>>> 617b520078dc133d7b90c7b7dc2b12260abd04fc:ACRM/ACRM/Form1.Designer.cs
            // 
            // lblFirmware
            // 
            this.lblFirmware.AutoSize = true;
            this.lblFirmware.Location = new System.Drawing.Point(165, 188);
            this.lblFirmware.Name = "lblFirmware";
<<<<<<< HEAD:ACRM/ACRM/ACRMForm.Designer.cs
            this.lblFirmware.Size = new System.Drawing.Size(16, 13);
            this.lblFirmware.TabIndex = 27;
            this.lblFirmware.Text = "---";
=======
            this.lblFirmware.Size = new System.Drawing.Size(19, 13);
            this.lblFirmware.TabIndex = 27;
            this.lblFirmware.Text = "----";
>>>>>>> 617b520078dc133d7b90c7b7dc2b12260abd04fc:ACRM/ACRM/Form1.Designer.cs
            // 
            // lblPartitions
            // 
            this.lblPartitions.AutoSize = true;
            this.lblPartitions.Location = new System.Drawing.Point(165, 142);
            this.lblPartitions.Name = "lblPartitions";
<<<<<<< HEAD:ACRM/ACRM/ACRMForm.Designer.cs
            this.lblPartitions.Size = new System.Drawing.Size(16, 13);
            this.lblPartitions.TabIndex = 26;
            this.lblPartitions.Text = "---";
=======
            this.lblPartitions.Size = new System.Drawing.Size(19, 13);
            this.lblPartitions.TabIndex = 26;
            this.lblPartitions.Text = "----";
>>>>>>> 617b520078dc133d7b90c7b7dc2b12260abd04fc:ACRM/ACRM/Form1.Designer.cs
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(165, 120);
            this.lblCapacity.Name = "lblCapacity";
<<<<<<< HEAD:ACRM/ACRM/ACRMForm.Designer.cs
            this.lblCapacity.Size = new System.Drawing.Size(16, 13);
            this.lblCapacity.TabIndex = 25;
            this.lblCapacity.Text = "---";
=======
            this.lblCapacity.Size = new System.Drawing.Size(19, 13);
            this.lblCapacity.TabIndex = 25;
            this.lblCapacity.Text = "----";
>>>>>>> 617b520078dc133d7b90c7b7dc2b12260abd04fc:ACRM/ACRM/Form1.Designer.cs
            // 
            // lblInterface
            // 
            this.lblInterface.AutoSize = true;
            this.lblInterface.Location = new System.Drawing.Point(165, 98);
            this.lblInterface.Name = "lblInterface";
<<<<<<< HEAD:ACRM/ACRM/ACRMForm.Designer.cs
            this.lblInterface.Size = new System.Drawing.Size(16, 13);
            this.lblInterface.TabIndex = 24;
            this.lblInterface.Text = "---";
=======
            this.lblInterface.Size = new System.Drawing.Size(19, 13);
            this.lblInterface.TabIndex = 24;
            this.lblInterface.Text = "----";
>>>>>>> 617b520078dc133d7b90c7b7dc2b12260abd04fc:ACRM/ACRM/Form1.Designer.cs
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(165, 52);
            this.lblModel.Name = "lblModel";
<<<<<<< HEAD:ACRM/ACRM/ACRMForm.Designer.cs
            this.lblModel.Size = new System.Drawing.Size(16, 13);
            this.lblModel.TabIndex = 23;
            this.lblModel.Text = "---";
=======
            this.lblModel.Size = new System.Drawing.Size(19, 13);
            this.lblModel.TabIndex = 23;
            this.lblModel.Text = "----";
>>>>>>> 617b520078dc133d7b90c7b7dc2b12260abd04fc:ACRM/ACRM/Form1.Designer.cs
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.Location = new System.Drawing.Point(165, 76);
            this.lblSerial.Name = "lblSerial";
<<<<<<< HEAD:ACRM/ACRM/ACRMForm.Designer.cs
            this.lblSerial.Size = new System.Drawing.Size(16, 13);
            this.lblSerial.TabIndex = 22;
            this.lblSerial.Text = "---";
=======
            this.lblSerial.Size = new System.Drawing.Size(19, 13);
            this.lblSerial.TabIndex = 22;
            this.lblSerial.Text = "----";
>>>>>>> 617b520078dc133d7b90c7b7dc2b12260abd04fc:ACRM/ACRM/Form1.Designer.cs
            // 
            // phyDiskComBox
            // 
            this.phyDiskComBox.DisplayMember = "0";
            this.phyDiskComBox.FormattingEnabled = true;
            this.phyDiskComBox.Location = new System.Drawing.Point(6, 19);
            this.phyDiskComBox.Name = "phyDiskComBox";
            this.phyDiskComBox.Size = new System.Drawing.Size(200, 21);
            this.phyDiskComBox.TabIndex = 21;
            this.phyDiskComBox.SelectedIndexChanged += new System.EventHandler(this.phyDiskComBox_SelectedIndexChanged);
            // 
            // volInfGBox
            // 
            this.volInfGBox.Controls.Add(this.driveListCombo);
            this.volInfGBox.Controls.Add(this.dStatLbl);
            this.volInfGBox.Controls.Add(this.hdlb15);
            this.volInfGBox.Controls.Add(this.hdlb22);
            this.volInfGBox.Controls.Add(this.hdlb16);
            this.volInfGBox.Controls.Add(this.totAvaLbl);
            this.volInfGBox.Controls.Add(this.hdlb17);
            this.volInfGBox.Controls.Add(this.totFreeLbl);
            this.volInfGBox.Controls.Add(this.hdlb18);
            this.volInfGBox.Controls.Add(this.totSizeLbl);
            this.volInfGBox.Controls.Add(this.hdlb19);
            this.volInfGBox.Controls.Add(this.dFormatLbl);
            this.volInfGBox.Controls.Add(this.hdlb20);
            this.volInfGBox.Controls.Add(this.dTypeLbl);
            this.volInfGBox.Controls.Add(this.hdlb21);
            this.volInfGBox.Controls.Add(this.volLbl);
            this.volInfGBox.Controls.Add(this.dNameLbl);
            this.volInfGBox.Location = new System.Drawing.Point(411, 3);
            this.volInfGBox.Name = "volInfGBox";
            this.volInfGBox.Size = new System.Drawing.Size(383, 248);
            this.volInfGBox.TabIndex = 20;
            this.volInfGBox.TabStop = false;
            this.volInfGBox.Text = "Volume Info";
            // 
            // driveListCombo
            // 
            this.driveListCombo.FormattingEnabled = true;
            this.driveListCombo.Location = new System.Drawing.Point(6, 19);
            this.driveListCombo.Name = "driveListCombo";
            this.driveListCombo.Size = new System.Drawing.Size(200, 21);
            this.driveListCombo.TabIndex = 1;
            this.driveListCombo.SelectedIndexChanged += new System.EventHandler(this.driveListCombo_SelectedIndexChanged);
            // 
            // dStatLbl
            // 
            this.dStatLbl.AutoSize = true;
            this.dStatLbl.Location = new System.Drawing.Point(163, 211);
            this.dStatLbl.Name = "dStatLbl";
<<<<<<< HEAD:ACRM/ACRM/ACRMForm.Designer.cs
            this.dStatLbl.Size = new System.Drawing.Size(16, 13);
            this.dStatLbl.TabIndex = 18;
            this.dStatLbl.Text = "---";
=======
            this.dStatLbl.Size = new System.Drawing.Size(19, 13);
            this.dStatLbl.TabIndex = 18;
            this.dStatLbl.Text = "----";
>>>>>>> 617b520078dc133d7b90c7b7dc2b12260abd04fc:ACRM/ACRM/Form1.Designer.cs
            // 
            // hdlb15
            // 
            this.hdlb15.AutoSize = true;
            this.hdlb15.Location = new System.Drawing.Point(3, 53);
            this.hdlb15.Name = "hdlb15";
            this.hdlb15.Size = new System.Drawing.Size(73, 13);
            this.hdlb15.TabIndex = 3;
            this.hdlb15.Text = "Volume Name";
            // 
            // hdlb22
            // 
            this.hdlb22.AutoSize = true;
            this.hdlb22.Location = new System.Drawing.Point(3, 211);
            this.hdlb22.Name = "hdlb22";
            this.hdlb22.Size = new System.Drawing.Size(75, 13);
            this.hdlb22.TabIndex = 17;
            this.hdlb22.Text = "Volume Status";
            // 
            // hdlb16
            // 
            this.hdlb16.AutoSize = true;
            this.hdlb16.Location = new System.Drawing.Point(3, 77);
            this.hdlb16.Name = "hdlb16";
            this.hdlb16.Size = new System.Drawing.Size(71, 13);
            this.hdlb16.TabIndex = 4;
            this.hdlb16.Text = "Volume Label";
            // 
            // totAvaLbl
            // 
            this.totAvaLbl.AutoSize = true;
            this.totAvaLbl.Location = new System.Drawing.Point(163, 189);
            this.totAvaLbl.Name = "totAvaLbl";
<<<<<<< HEAD:ACRM/ACRM/ACRMForm.Designer.cs
            this.totAvaLbl.Size = new System.Drawing.Size(16, 13);
            this.totAvaLbl.TabIndex = 16;
            this.totAvaLbl.Text = "---";
=======
            this.totAvaLbl.Size = new System.Drawing.Size(19, 13);
            this.totAvaLbl.TabIndex = 16;
            this.totAvaLbl.Text = "----";
>>>>>>> 617b520078dc133d7b90c7b7dc2b12260abd04fc:ACRM/ACRM/Form1.Designer.cs
            // 
            // hdlb17
            // 
            this.hdlb17.AutoSize = true;
            this.hdlb17.Location = new System.Drawing.Point(3, 99);
            this.hdlb17.Name = "hdlb17";
            this.hdlb17.Size = new System.Drawing.Size(69, 13);
            this.hdlb17.TabIndex = 5;
            this.hdlb17.Text = "Volume Type";
            // 
            // totFreeLbl
            // 
            this.totFreeLbl.AutoSize = true;
            this.totFreeLbl.Location = new System.Drawing.Point(163, 166);
            this.totFreeLbl.Name = "totFreeLbl";
<<<<<<< HEAD:ACRM/ACRM/ACRMForm.Designer.cs
            this.totFreeLbl.Size = new System.Drawing.Size(16, 13);
            this.totFreeLbl.TabIndex = 15;
            this.totFreeLbl.Text = "---";
=======
            this.totFreeLbl.Size = new System.Drawing.Size(19, 13);
            this.totFreeLbl.TabIndex = 15;
            this.totFreeLbl.Text = "----";
>>>>>>> 617b520078dc133d7b90c7b7dc2b12260abd04fc:ACRM/ACRM/Form1.Designer.cs
            // 
            // hdlb18
            // 
            this.hdlb18.AutoSize = true;
            this.hdlb18.Location = new System.Drawing.Point(3, 121);
            this.hdlb18.Name = "hdlb18";
            this.hdlb18.Size = new System.Drawing.Size(77, 13);
            this.hdlb18.TabIndex = 6;
            this.hdlb18.Text = "Volume Format";
            // 
            // totSizeLbl
            // 
            this.totSizeLbl.AutoSize = true;
            this.totSizeLbl.Location = new System.Drawing.Point(163, 143);
            this.totSizeLbl.Name = "totSizeLbl";
<<<<<<< HEAD:ACRM/ACRM/ACRMForm.Designer.cs
            this.totSizeLbl.Size = new System.Drawing.Size(16, 13);
            this.totSizeLbl.TabIndex = 14;
            this.totSizeLbl.Text = "---";
=======
            this.totSizeLbl.Size = new System.Drawing.Size(19, 13);
            this.totSizeLbl.TabIndex = 14;
            this.totSizeLbl.Text = "----";
>>>>>>> 617b520078dc133d7b90c7b7dc2b12260abd04fc:ACRM/ACRM/Form1.Designer.cs
            // 
            // hdlb19
            // 
            this.hdlb19.AutoSize = true;
            this.hdlb19.Location = new System.Drawing.Point(3, 143);
            this.hdlb19.Name = "hdlb19";
            this.hdlb19.Size = new System.Drawing.Size(54, 13);
            this.hdlb19.TabIndex = 7;
            this.hdlb19.Text = "Total Size";
            // 
            // dFormatLbl
            // 
            this.dFormatLbl.AutoSize = true;
            this.dFormatLbl.Location = new System.Drawing.Point(163, 121);
            this.dFormatLbl.Name = "dFormatLbl";
<<<<<<< HEAD:ACRM/ACRM/ACRMForm.Designer.cs
            this.dFormatLbl.Size = new System.Drawing.Size(16, 13);
            this.dFormatLbl.TabIndex = 13;
            this.dFormatLbl.Text = "---";
=======
            this.dFormatLbl.Size = new System.Drawing.Size(19, 13);
            this.dFormatLbl.TabIndex = 13;
            this.dFormatLbl.Text = "----";
>>>>>>> 617b520078dc133d7b90c7b7dc2b12260abd04fc:ACRM/ACRM/Form1.Designer.cs
            // 
            // hdlb20
            // 
            this.hdlb20.AutoSize = true;
            this.hdlb20.Location = new System.Drawing.Point(3, 166);
            this.hdlb20.Name = "hdlb20";
            this.hdlb20.Size = new System.Drawing.Size(89, 13);
            this.hdlb20.TabIndex = 8;
            this.hdlb20.Text = "Total Free Space";
            // 
            // dTypeLbl
            // 
            this.dTypeLbl.AutoSize = true;
            this.dTypeLbl.Location = new System.Drawing.Point(163, 99);
            this.dTypeLbl.Name = "dTypeLbl";
<<<<<<< HEAD:ACRM/ACRM/ACRMForm.Designer.cs
            this.dTypeLbl.Size = new System.Drawing.Size(16, 13);
            this.dTypeLbl.TabIndex = 12;
            this.dTypeLbl.Text = "---";
=======
            this.dTypeLbl.Size = new System.Drawing.Size(19, 13);
            this.dTypeLbl.TabIndex = 12;
            this.dTypeLbl.Text = "----";
>>>>>>> 617b520078dc133d7b90c7b7dc2b12260abd04fc:ACRM/ACRM/Form1.Designer.cs
            // 
            // hdlb21
            // 
            this.hdlb21.AutoSize = true;
            this.hdlb21.Location = new System.Drawing.Point(3, 189);
            this.hdlb21.Name = "hdlb21";
            this.hdlb21.Size = new System.Drawing.Size(108, 13);
            this.hdlb21.TabIndex = 9;
            this.hdlb21.Text = "Available Free Space";
            // 
            // volLbl
            // 
            this.volLbl.AutoSize = true;
            this.volLbl.Location = new System.Drawing.Point(163, 77);
            this.volLbl.Name = "volLbl";
<<<<<<< HEAD:ACRM/ACRM/ACRMForm.Designer.cs
            this.volLbl.Size = new System.Drawing.Size(16, 13);
            this.volLbl.TabIndex = 11;
            this.volLbl.Text = "---";
=======
            this.volLbl.Size = new System.Drawing.Size(19, 13);
            this.volLbl.TabIndex = 11;
            this.volLbl.Text = "----";
>>>>>>> 617b520078dc133d7b90c7b7dc2b12260abd04fc:ACRM/ACRM/Form1.Designer.cs
            // 
            // dNameLbl
            // 
            this.dNameLbl.AutoSize = true;
            this.dNameLbl.Location = new System.Drawing.Point(163, 53);
            this.dNameLbl.Name = "dNameLbl";
<<<<<<< HEAD:ACRM/ACRM/ACRMForm.Designer.cs
            this.dNameLbl.Size = new System.Drawing.Size(16, 13);
            this.dNameLbl.TabIndex = 10;
            this.dNameLbl.Text = "---";
=======
            this.dNameLbl.Size = new System.Drawing.Size(19, 13);
            this.dNameLbl.TabIndex = 10;
            this.dNameLbl.Text = "----";
>>>>>>> 617b520078dc133d7b90c7b7dc2b12260abd04fc:ACRM/ACRM/Form1.Designer.cs
            // 
            // xtraFuncGBox
            // 
            this.xtraFuncGBox.Controls.Add(this.btnDiskPerf);
            this.xtraFuncGBox.Controls.Add(this.fileSysMonBtn);
            this.xtraFuncGBox.Location = new System.Drawing.Point(411, 257);
            this.xtraFuncGBox.Name = "xtraFuncGBox";
            this.xtraFuncGBox.Size = new System.Drawing.Size(383, 277);
            this.xtraFuncGBox.TabIndex = 19;
            this.xtraFuncGBox.TabStop = false;
            this.xtraFuncGBox.Text = "Extra Functions";
            // 
            // btnDiskPerf
            // 
            this.btnDiskPerf.Location = new System.Drawing.Point(6, 84);
            this.btnDiskPerf.Name = "btnDiskPerf";
            this.btnDiskPerf.Size = new System.Drawing.Size(142, 30);
            this.btnDiskPerf.TabIndex = 1;
            this.btnDiskPerf.Text = "Disk Performance";
            this.btnDiskPerf.UseVisualStyleBackColor = true;
            this.btnDiskPerf.Click += new System.EventHandler(this.btnDiskPerf_Click);
            // 
            // fileSysMonBtn
            // 
            this.fileSysMonBtn.Location = new System.Drawing.Point(6, 31);
            this.fileSysMonBtn.Name = "fileSysMonBtn";
            this.fileSysMonBtn.Size = new System.Drawing.Size(142, 30);
            this.fileSysMonBtn.TabIndex = 0;
            this.fileSysMonBtn.Text = "File System Monitor";
            this.fileSysMonBtn.UseVisualStyleBackColor = true;
            this.fileSysMonBtn.Click += new System.EventHandler(this.fileSysMonBtn_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(797, 537);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Network";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // processName
            // 
            this.processName.AutoSize = true;
            this.processName.Location = new System.Drawing.Point(376, 15);
            this.processName.Name = "processName";
            this.processName.Size = new System.Drawing.Size(62, 13);
            this.processName.TabIndex = 10;
            this.processName.Text = "Monitoring :";
            this.processName.Visible = false;
            // 
            // processNameValue
            // 
            this.processNameValue.AutoSize = true;
            this.processNameValue.Location = new System.Drawing.Point(445, 14);
            this.processNameValue.Name = "processNameValue";
            this.processNameValue.Size = new System.Drawing.Size(35, 13);
            this.processNameValue.TabIndex = 11;
            this.processNameValue.Text = "label1";
            this.processNameValue.Visible = false;
            // 
            // ACRMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 563);
            this.Controls.Add(this.tabControl1);
            this.Name = "ACRMForm";
            this.Text = "Automated Computer Resource Management System";
            this.Load += new System.EventHandler(this.ACRMForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.phyDiskInfGBox.ResumeLayout(false);
            this.phyDiskInfGBox.PerformLayout();
            this.volInfGBox.ResumeLayout(false);
            this.volInfGBox.PerformLayout();
            this.xtraFuncGBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button fileSysMonBtn;
        private System.Windows.Forms.ComboBox driveListCombo;
        private System.Windows.Forms.Label totAvaLbl;
        private System.Windows.Forms.Label totFreeLbl;
        private System.Windows.Forms.Label totSizeLbl;
        private System.Windows.Forms.Label dFormatLbl;
        private System.Windows.Forms.Label dTypeLbl;
        private System.Windows.Forms.Label volLbl;
        private System.Windows.Forms.Label dNameLbl;
        private System.Windows.Forms.Label hdlb21;
        private System.Windows.Forms.Label hdlb20;
        private System.Windows.Forms.Label hdlb19;
        private System.Windows.Forms.Label hdlb18;
        private System.Windows.Forms.Label hdlb17;
        private System.Windows.Forms.Label hdlb16;
        private System.Windows.Forms.Label hdlb15;
        private System.Windows.Forms.Label dStatLbl;
        private System.Windows.Forms.Label hdlb22;
        private System.Windows.Forms.GroupBox phyDiskInfGBox;
        private System.Windows.Forms.ComboBox phyDiskComBox;
        private System.Windows.Forms.GroupBox volInfGBox;
        private System.Windows.Forms.GroupBox xtraFuncGBox;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.Label lblSig;
        private System.Windows.Forms.Label lblTrackPerCyl;
        private System.Windows.Forms.Label lblSecPerTrack;
        private System.Windows.Forms.Label lblBperSec;
        private System.Windows.Forms.Label lblTracks;
        private System.Windows.Forms.Label lblHeads;
        private System.Windows.Forms.Label lblSectors;
        private System.Windows.Forms.Label lblCylinder;
        private System.Windows.Forms.Label lblFirmware;
        private System.Windows.Forms.Label lblPartitions;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblInterface;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label hdlb14;
        private System.Windows.Forms.Label hdlb13;
        private System.Windows.Forms.Label hdlb12;
        private System.Windows.Forms.Label hdlb11;
        private System.Windows.Forms.Label hdlb10;
        private System.Windows.Forms.Label hdlb9;
        private System.Windows.Forms.Label hdlb8;
        private System.Windows.Forms.Label hdlb7;
        private System.Windows.Forms.Label hdlb6;
        private System.Windows.Forms.Label hdlb5;
        private System.Windows.Forms.Label hdlb4;
        private System.Windows.Forms.Label hdlb3;
        private System.Windows.Forms.Label hdlb2;
        private System.Windows.Forms.Label hdlb1;
        private System.Windows.Forms.Button btnDiskPerf;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart cpuChart;
        private System.Windows.Forms.Label processNameValue;
        private System.Windows.Forms.Label processName;
    }
}

