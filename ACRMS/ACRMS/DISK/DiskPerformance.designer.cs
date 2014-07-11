namespace ACRMS.DISK
{
    partial class DiskPerformance
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnAvgTrans = new System.Windows.Forms.Button();
            this.btnDiskQueue = new System.Windows.Forms.Button();
            this.btnDiskTime = new System.Windows.Forms.Button();
            this.btnIdleTime = new System.Windows.Forms.Button();
            this.HDchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnStart = new MetroFramework.Controls.MetroButton();
            this.btnStop = new MetroFramework.Controls.MetroButton();
            this.hostListComboBox = new MetroFramework.Controls.MetroComboBox();
            this.lblElapsedTime = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lblDiskWrites = new MetroFramework.Controls.MetroLabel();
            this.lblDiskTrans = new MetroFramework.Controls.MetroLabel();
            this.lblTransMax = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.lblAvgRead = new MetroFramework.Controls.MetroLabel();
            this.lblAvgWrite = new MetroFramework.Controls.MetroLabel();
            this.lblDiskReads = new MetroFramework.Controls.MetroLabel();
            this.lblCurrQLen = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.lblAvgDiskQ = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.lblAvgReadQ = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.lblAvgWriteQ = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.lblDiskReadsBytes = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.lblDiskWriteBytes = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.lblDiskTransByte = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.lblAvgReadB = new MetroFramework.Controls.MetroLabel();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.lblAvgWriteB = new MetroFramework.Controls.MetroLabel();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.lblAvgTransB = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.lblIdleTime = new MetroFramework.Controls.MetroLabel();
            this.lblDiskTime = new MetroFramework.Controls.MetroLabel();
            this.lblIOSplit = new MetroFramework.Controls.MetroLabel();
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.lblReadTime = new MetroFramework.Controls.MetroLabel();
            this.metroLabel23 = new MetroFramework.Controls.MetroLabel();
            this.lblWriteTime = new MetroFramework.Controls.MetroLabel();
            this.statusStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HDchart)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 706);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1084, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.btnAvgTrans);
            this.groupBox5.Controls.Add(this.btnDiskQueue);
            this.groupBox5.Controls.Add(this.btnDiskTime);
            this.groupBox5.Controls.Add(this.btnIdleTime);
            this.groupBox5.Controls.Add(this.HDchart);
            this.groupBox5.Location = new System.Drawing.Point(12, 41);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1069, 254);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "% Disk Times";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(951, 146);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(100, 13);
            this.label26.TabIndex = 8;
            this.label26.Text = "Avg. Transfers/Sec";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(957, 104);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(88, 13);
            this.label23.TabIndex = 7;
            this.label23.Text = "Avg. Disk Queue";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(969, 62);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 13);
            this.label22.TabIndex = 6;
            this.label22.Text = "% Disk Time";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(971, 20);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 13);
            this.label21.TabIndex = 5;
            this.label21.Text = "% Idle Time";
            // 
            // btnAvgTrans
            // 
            this.btnAvgTrans.BackColor = System.Drawing.Color.Green;
            this.btnAvgTrans.Location = new System.Drawing.Point(964, 162);
            this.btnAvgTrans.Name = "btnAvgTrans";
            this.btnAvgTrans.Size = new System.Drawing.Size(75, 23);
            this.btnAvgTrans.TabIndex = 4;
            this.btnAvgTrans.Text = "Showing";
            this.btnAvgTrans.UseVisualStyleBackColor = false;
            this.btnAvgTrans.Click += new System.EventHandler(this.btnAvgTrans_Click);
            // 
            // btnDiskQueue
            // 
            this.btnDiskQueue.BackColor = System.Drawing.Color.Green;
            this.btnDiskQueue.Location = new System.Drawing.Point(964, 120);
            this.btnDiskQueue.Name = "btnDiskQueue";
            this.btnDiskQueue.Size = new System.Drawing.Size(75, 23);
            this.btnDiskQueue.TabIndex = 3;
            this.btnDiskQueue.Text = "Showing";
            this.btnDiskQueue.UseVisualStyleBackColor = false;
            this.btnDiskQueue.Click += new System.EventHandler(this.btnDiskQueue_Click);
            // 
            // btnDiskTime
            // 
            this.btnDiskTime.BackColor = System.Drawing.Color.Green;
            this.btnDiskTime.Location = new System.Drawing.Point(964, 78);
            this.btnDiskTime.Name = "btnDiskTime";
            this.btnDiskTime.Size = new System.Drawing.Size(75, 23);
            this.btnDiskTime.TabIndex = 2;
            this.btnDiskTime.Text = "Showing";
            this.btnDiskTime.UseVisualStyleBackColor = false;
            this.btnDiskTime.Click += new System.EventHandler(this.btnDiskTime_Click);
            // 
            // btnIdleTime
            // 
            this.btnIdleTime.BackColor = System.Drawing.Color.Green;
            this.btnIdleTime.Location = new System.Drawing.Point(964, 36);
            this.btnIdleTime.Name = "btnIdleTime";
            this.btnIdleTime.Size = new System.Drawing.Size(75, 23);
            this.btnIdleTime.TabIndex = 1;
            this.btnIdleTime.Text = "Showing";
            this.btnIdleTime.UseVisualStyleBackColor = false;
            this.btnIdleTime.Click += new System.EventHandler(this.btnIdleTime_Click);
            // 
            // HDchart
            // 
            chartArea1.Name = "ChartArea1";
            this.HDchart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.HDchart.Legends.Add(legend1);
            this.HDchart.Location = new System.Drawing.Point(9, 20);
            this.HDchart.Name = "HDchart";
            this.HDchart.Size = new System.Drawing.Size(901, 228);
            this.HDchart.TabIndex = 0;
            this.HDchart.Text = "chart1";
            this.HDchart.Click += new System.EventHandler(this.HDchart_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.lblWriteTime);
            this.metroPanel1.Controls.Add(this.metroLabel23);
            this.metroPanel1.Controls.Add(this.lblReadTime);
            this.metroPanel1.Controls.Add(this.metroLabel22);
            this.metroPanel1.Controls.Add(this.lblIOSplit);
            this.metroPanel1.Controls.Add(this.lblDiskTime);
            this.metroPanel1.Controls.Add(this.lblIdleTime);
            this.metroPanel1.Controls.Add(this.metroLabel21);
            this.metroPanel1.Controls.Add(this.metroLabel20);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.lblAvgTransB);
            this.metroPanel1.Controls.Add(this.metroLabel19);
            this.metroPanel1.Controls.Add(this.lblAvgWriteB);
            this.metroPanel1.Controls.Add(this.metroLabel18);
            this.metroPanel1.Controls.Add(this.lblAvgReadB);
            this.metroPanel1.Controls.Add(this.metroLabel17);
            this.metroPanel1.Controls.Add(this.lblDiskTransByte);
            this.metroPanel1.Controls.Add(this.metroLabel16);
            this.metroPanel1.Controls.Add(this.lblDiskWriteBytes);
            this.metroPanel1.Controls.Add(this.metroLabel15);
            this.metroPanel1.Controls.Add(this.lblDiskReadsBytes);
            this.metroPanel1.Controls.Add(this.metroLabel14);
            this.metroPanel1.Controls.Add(this.lblAvgWriteQ);
            this.metroPanel1.Controls.Add(this.metroLabel13);
            this.metroPanel1.Controls.Add(this.lblAvgReadQ);
            this.metroPanel1.Controls.Add(this.metroLabel12);
            this.metroPanel1.Controls.Add(this.lblAvgDiskQ);
            this.metroPanel1.Controls.Add(this.metroLabel11);
            this.metroPanel1.Controls.Add(this.lblCurrQLen);
            this.metroPanel1.Controls.Add(this.lblDiskReads);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel10);
            this.metroPanel1.Controls.Add(this.lblAvgWrite);
            this.metroPanel1.Controls.Add(this.lblAvgRead);
            this.metroPanel1.Controls.Add(this.metroLabel9);
            this.metroPanel1.Controls.Add(this.lblElapsedTime);
            this.metroPanel1.Controls.Add(this.hostListComboBox);
            this.metroPanel1.Controls.Add(this.btnStop);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.btnStart);
            this.metroPanel1.Controls.Add(this.lblTransMax);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.lblDiskTrans);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.lblDiskWrites);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.CustomBackground = false;
            this.metroPanel1.HorizontalScrollbar = false;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, -1);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1084, 839);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanel1.StyleManager = null;
            this.metroPanel1.TabIndex = 24;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbar = false;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // btnStart
            // 
            this.btnStart.Highlight = false;
            this.btnStart.Location = new System.Drawing.Point(12, 13);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnStart.StyleManager = null;
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start";
            this.btnStart.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnStart.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnStop
            // 
            this.btnStop.Highlight = false;
            this.btnStop.Location = new System.Drawing.Point(93, 13);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnStop.StyleManager = null;
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnStop.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // hostListComboBox
            // 
            this.hostListComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.hostListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hostListComboBox.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.hostListComboBox.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.hostListComboBox.FormattingEnabled = true;
            this.hostListComboBox.ItemHeight = 23;
            this.hostListComboBox.Location = new System.Drawing.Point(195, 9);
            this.hostListComboBox.Name = "hostListComboBox";
            this.hostListComboBox.Size = new System.Drawing.Size(121, 29);
            this.hostListComboBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.hostListComboBox.StyleManager = null;
            this.hostListComboBox.TabIndex = 9;
            this.hostListComboBox.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblElapsedTime
            // 
            this.lblElapsedTime.AutoSize = true;
            this.lblElapsedTime.CustomBackground = false;
            this.lblElapsedTime.CustomForeColor = true;
            this.lblElapsedTime.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblElapsedTime.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblElapsedTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblElapsedTime.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblElapsedTime.Location = new System.Drawing.Point(904, 10);
            this.lblElapsedTime.Name = "lblElapsedTime";
            this.lblElapsedTime.Size = new System.Drawing.Size(74, 25);
            this.lblElapsedTime.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblElapsedTime.StyleManager = null;
            this.lblElapsedTime.TabIndex = 10;
            this.lblElapsedTime.Text = "00:00:00";
            this.lblElapsedTime.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblElapsedTime.UseStyleColors = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(21, 321);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(122, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Disk reads/Sec";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = false;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel2.Location = new System.Drawing.Point(21, 379);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(128, 25);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.StyleManager = null;
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Disk Writes/Sec";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseStyleColors = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.CustomBackground = false;
            this.metroLabel3.CustomForeColor = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel3.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel3.Location = new System.Drawing.Point(21, 434);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(142, 25);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.StyleManager = null;
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Disk Transfer/Sec";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseStyleColors = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.CustomBackground = false;
            this.metroLabel4.CustomForeColor = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel4.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel4.Location = new System.Drawing.Point(12, 541);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(150, 25);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel4.StyleManager = null;
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Disk Transfer Peak";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseStyleColors = false;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.CustomBackground = false;
            this.metroLabel5.CustomForeColor = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel5.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel5.Location = new System.Drawing.Point(287, 327);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(183, 25);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel5.StyleManager = null;
            this.metroLabel5.TabIndex = 13;
            this.metroLabel5.Text = "Current Queue Length";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel5.UseStyleColors = false;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.CustomBackground = false;
            this.metroLabel7.CustomForeColor = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel7.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel7.Location = new System.Drawing.Point(178, 326);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(19, 25);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel7.StyleManager = null;
            this.metroLabel7.TabIndex = 15;
            this.metroLabel7.Text = "-";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel7.UseStyleColors = false;
            // 
            // lblDiskWrites
            // 
            this.lblDiskWrites.AutoSize = true;
            this.lblDiskWrites.CustomBackground = false;
            this.lblDiskWrites.CustomForeColor = true;
            this.lblDiskWrites.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDiskWrites.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblDiskWrites.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDiskWrites.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblDiskWrites.Location = new System.Drawing.Point(178, 379);
            this.lblDiskWrites.Name = "lblDiskWrites";
            this.lblDiskWrites.Size = new System.Drawing.Size(19, 25);
            this.lblDiskWrites.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDiskWrites.StyleManager = null;
            this.lblDiskWrites.TabIndex = 16;
            this.lblDiskWrites.Text = "-";
            this.lblDiskWrites.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblDiskWrites.UseStyleColors = false;
            // 
            // lblDiskTrans
            // 
            this.lblDiskTrans.AutoSize = true;
            this.lblDiskTrans.CustomBackground = false;
            this.lblDiskTrans.CustomForeColor = true;
            this.lblDiskTrans.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDiskTrans.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblDiskTrans.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDiskTrans.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblDiskTrans.Location = new System.Drawing.Point(178, 434);
            this.lblDiskTrans.Name = "lblDiskTrans";
            this.lblDiskTrans.Size = new System.Drawing.Size(19, 25);
            this.lblDiskTrans.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDiskTrans.StyleManager = null;
            this.lblDiskTrans.TabIndex = 17;
            this.lblDiskTrans.Text = "-";
            this.lblDiskTrans.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblDiskTrans.UseStyleColors = false;
            // 
            // lblTransMax
            // 
            this.lblTransMax.AutoSize = true;
            this.lblTransMax.CustomBackground = false;
            this.lblTransMax.CustomForeColor = true;
            this.lblTransMax.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTransMax.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblTransMax.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTransMax.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblTransMax.Location = new System.Drawing.Point(178, 541);
            this.lblTransMax.Name = "lblTransMax";
            this.lblTransMax.Size = new System.Drawing.Size(19, 25);
            this.lblTransMax.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblTransMax.StyleManager = null;
            this.lblTransMax.TabIndex = 18;
            this.lblTransMax.Text = "-";
            this.lblTransMax.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblTransMax.UseStyleColors = false;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.CustomBackground = false;
            this.metroLabel8.CustomForeColor = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel8.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel8.Location = new System.Drawing.Point(15, 597);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(128, 25);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel8.StyleManager = null;
            this.metroLabel8.TabIndex = 19;
            this.metroLabel8.Text = "Avg. Reads/Sec";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel8.UseStyleColors = false;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.CustomBackground = false;
            this.metroLabel9.CustomForeColor = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel9.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel9.Location = new System.Drawing.Point(13, 658);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(130, 25);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel9.StyleManager = null;
            this.metroLabel9.TabIndex = 20;
            this.metroLabel9.Text = "Avg. Writes/Sec";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel9.UseStyleColors = false;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.CustomBackground = false;
            this.metroLabel10.CustomForeColor = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel10.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel10.Location = new System.Drawing.Point(13, 487);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(151, 25);
            this.metroLabel10.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel10.StyleManager = null;
            this.metroLabel10.TabIndex = 21;
            this.metroLabel10.Text = "Avg. Transfers/Sec";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel10.UseStyleColors = false;
            // 
            // lblAvgRead
            // 
            this.lblAvgRead.AutoSize = true;
            this.lblAvgRead.CustomBackground = false;
            this.lblAvgRead.CustomForeColor = true;
            this.lblAvgRead.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAvgRead.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblAvgRead.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAvgRead.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblAvgRead.Location = new System.Drawing.Point(178, 597);
            this.lblAvgRead.Name = "lblAvgRead";
            this.lblAvgRead.Size = new System.Drawing.Size(19, 25);
            this.lblAvgRead.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblAvgRead.StyleManager = null;
            this.lblAvgRead.TabIndex = 22;
            this.lblAvgRead.Text = "-";
            this.lblAvgRead.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblAvgRead.UseStyleColors = false;
            // 
            // lblAvgWrite
            // 
            this.lblAvgWrite.AutoSize = true;
            this.lblAvgWrite.CustomBackground = false;
            this.lblAvgWrite.CustomForeColor = true;
            this.lblAvgWrite.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAvgWrite.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblAvgWrite.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAvgWrite.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblAvgWrite.Location = new System.Drawing.Point(178, 658);
            this.lblAvgWrite.Name = "lblAvgWrite";
            this.lblAvgWrite.Size = new System.Drawing.Size(19, 25);
            this.lblAvgWrite.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblAvgWrite.StyleManager = null;
            this.lblAvgWrite.TabIndex = 23;
            this.lblAvgWrite.Text = "-";
            this.lblAvgWrite.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblAvgWrite.UseStyleColors = false;
            // 
            // lblDiskReads
            // 
            this.lblDiskReads.AutoSize = true;
            this.lblDiskReads.CustomBackground = false;
            this.lblDiskReads.CustomForeColor = true;
            this.lblDiskReads.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDiskReads.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblDiskReads.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDiskReads.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblDiskReads.Location = new System.Drawing.Point(178, 487);
            this.lblDiskReads.Name = "lblDiskReads";
            this.lblDiskReads.Size = new System.Drawing.Size(19, 25);
            this.lblDiskReads.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDiskReads.StyleManager = null;
            this.lblDiskReads.TabIndex = 24;
            this.lblDiskReads.Text = "-";
            this.lblDiskReads.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblDiskReads.UseStyleColors = false;
            this.lblDiskReads.Click += new System.EventHandler(this.lblDiskReads_Click);
            // 
            // lblCurrQLen
            // 
            this.lblCurrQLen.AutoSize = true;
            this.lblCurrQLen.CustomBackground = false;
            this.lblCurrQLen.CustomForeColor = true;
            this.lblCurrQLen.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCurrQLen.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblCurrQLen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCurrQLen.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblCurrQLen.Location = new System.Drawing.Point(512, 327);
            this.lblCurrQLen.Name = "lblCurrQLen";
            this.lblCurrQLen.Size = new System.Drawing.Size(19, 25);
            this.lblCurrQLen.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblCurrQLen.StyleManager = null;
            this.lblCurrQLen.TabIndex = 25;
            this.lblCurrQLen.Text = "-";
            this.lblCurrQLen.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblCurrQLen.UseStyleColors = false;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.CustomBackground = false;
            this.metroLabel11.CustomForeColor = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel11.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel11.Location = new System.Drawing.Point(287, 373);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(138, 25);
            this.metroLabel11.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel11.StyleManager = null;
            this.metroLabel11.TabIndex = 26;
            this.metroLabel11.Text = "Avg. Disk Queue";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel11.UseStyleColors = false;
            // 
            // lblAvgDiskQ
            // 
            this.lblAvgDiskQ.AutoSize = true;
            this.lblAvgDiskQ.CustomBackground = false;
            this.lblAvgDiskQ.CustomForeColor = true;
            this.lblAvgDiskQ.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAvgDiskQ.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblAvgDiskQ.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAvgDiskQ.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblAvgDiskQ.Location = new System.Drawing.Point(512, 373);
            this.lblAvgDiskQ.Name = "lblAvgDiskQ";
            this.lblAvgDiskQ.Size = new System.Drawing.Size(19, 25);
            this.lblAvgDiskQ.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblAvgDiskQ.StyleManager = null;
            this.lblAvgDiskQ.TabIndex = 27;
            this.lblAvgDiskQ.Text = "-";
            this.lblAvgDiskQ.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblAvgDiskQ.UseStyleColors = false;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.CustomBackground = false;
            this.metroLabel12.CustomForeColor = true;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel12.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel12.Location = new System.Drawing.Point(287, 434);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(145, 25);
            this.metroLabel12.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel12.StyleManager = null;
            this.metroLabel12.TabIndex = 28;
            this.metroLabel12.Text = "Avg. Read Queue";
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel12.UseStyleColors = false;
            // 
            // lblAvgReadQ
            // 
            this.lblAvgReadQ.AutoSize = true;
            this.lblAvgReadQ.CustomBackground = false;
            this.lblAvgReadQ.CustomForeColor = true;
            this.lblAvgReadQ.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAvgReadQ.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblAvgReadQ.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAvgReadQ.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblAvgReadQ.Location = new System.Drawing.Point(512, 434);
            this.lblAvgReadQ.Name = "lblAvgReadQ";
            this.lblAvgReadQ.Size = new System.Drawing.Size(19, 25);
            this.lblAvgReadQ.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblAvgReadQ.StyleManager = null;
            this.lblAvgReadQ.TabIndex = 29;
            this.lblAvgReadQ.Text = "-";
            this.lblAvgReadQ.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblAvgReadQ.UseStyleColors = false;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.CustomBackground = false;
            this.metroLabel13.CustomForeColor = true;
            this.metroLabel13.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel13.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel13.Location = new System.Drawing.Point(287, 487);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(147, 25);
            this.metroLabel13.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel13.StyleManager = null;
            this.metroLabel13.TabIndex = 30;
            this.metroLabel13.Text = "Avg. Write Queue";
            this.metroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel13.UseStyleColors = false;
            // 
            // lblAvgWriteQ
            // 
            this.lblAvgWriteQ.AutoSize = true;
            this.lblAvgWriteQ.CustomBackground = false;
            this.lblAvgWriteQ.CustomForeColor = true;
            this.lblAvgWriteQ.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAvgWriteQ.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblAvgWriteQ.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAvgWriteQ.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblAvgWriteQ.Location = new System.Drawing.Point(512, 487);
            this.lblAvgWriteQ.Name = "lblAvgWriteQ";
            this.lblAvgWriteQ.Size = new System.Drawing.Size(19, 25);
            this.lblAvgWriteQ.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblAvgWriteQ.StyleManager = null;
            this.lblAvgWriteQ.TabIndex = 31;
            this.lblAvgWriteQ.Text = "-";
            this.lblAvgWriteQ.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblAvgWriteQ.UseStyleColors = false;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.CustomBackground = false;
            this.metroLabel14.CustomForeColor = true;
            this.metroLabel14.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel14.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel14.Location = new System.Drawing.Point(287, 541);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(141, 25);
            this.metroLabel14.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel14.StyleManager = null;
            this.metroLabel14.TabIndex = 32;
            this.metroLabel14.Text = "Disk Reads B/Sec";
            this.metroLabel14.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel14.UseStyleColors = false;
            // 
            // lblDiskReadsBytes
            // 
            this.lblDiskReadsBytes.AutoSize = true;
            this.lblDiskReadsBytes.CustomBackground = false;
            this.lblDiskReadsBytes.CustomForeColor = true;
            this.lblDiskReadsBytes.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDiskReadsBytes.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblDiskReadsBytes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDiskReadsBytes.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblDiskReadsBytes.Location = new System.Drawing.Point(512, 541);
            this.lblDiskReadsBytes.Name = "lblDiskReadsBytes";
            this.lblDiskReadsBytes.Size = new System.Drawing.Size(19, 25);
            this.lblDiskReadsBytes.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDiskReadsBytes.StyleManager = null;
            this.lblDiskReadsBytes.TabIndex = 33;
            this.lblDiskReadsBytes.Text = "-";
            this.lblDiskReadsBytes.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblDiskReadsBytes.UseStyleColors = false;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.CustomBackground = false;
            this.metroLabel15.CustomForeColor = true;
            this.metroLabel15.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel15.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel15.Location = new System.Drawing.Point(287, 597);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(143, 25);
            this.metroLabel15.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel15.StyleManager = null;
            this.metroLabel15.TabIndex = 34;
            this.metroLabel15.Text = "Disk Writes B/Sec";
            this.metroLabel15.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel15.UseStyleColors = false;
            // 
            // lblDiskWriteBytes
            // 
            this.lblDiskWriteBytes.AutoSize = true;
            this.lblDiskWriteBytes.CustomBackground = false;
            this.lblDiskWriteBytes.CustomForeColor = true;
            this.lblDiskWriteBytes.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDiskWriteBytes.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblDiskWriteBytes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDiskWriteBytes.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblDiskWriteBytes.Location = new System.Drawing.Point(512, 597);
            this.lblDiskWriteBytes.Name = "lblDiskWriteBytes";
            this.lblDiskWriteBytes.Size = new System.Drawing.Size(19, 25);
            this.lblDiskWriteBytes.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDiskWriteBytes.StyleManager = null;
            this.lblDiskWriteBytes.TabIndex = 35;
            this.lblDiskWriteBytes.Text = "-";
            this.lblDiskWriteBytes.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblDiskWriteBytes.UseStyleColors = false;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.CustomBackground = false;
            this.metroLabel16.CustomForeColor = true;
            this.metroLabel16.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel16.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel16.Location = new System.Drawing.Point(287, 658);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(152, 25);
            this.metroLabel16.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel16.StyleManager = null;
            this.metroLabel16.TabIndex = 36;
            this.metroLabel16.Text = "DiskTransfer B/Sec";
            this.metroLabel16.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel16.UseStyleColors = false;
            // 
            // lblDiskTransByte
            // 
            this.lblDiskTransByte.AutoSize = true;
            this.lblDiskTransByte.CustomBackground = false;
            this.lblDiskTransByte.CustomForeColor = true;
            this.lblDiskTransByte.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDiskTransByte.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblDiskTransByte.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDiskTransByte.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblDiskTransByte.Location = new System.Drawing.Point(512, 658);
            this.lblDiskTransByte.Name = "lblDiskTransByte";
            this.lblDiskTransByte.Size = new System.Drawing.Size(19, 25);
            this.lblDiskTransByte.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDiskTransByte.StyleManager = null;
            this.lblDiskTransByte.TabIndex = 37;
            this.lblDiskTransByte.Text = "-";
            this.lblDiskTransByte.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblDiskTransByte.UseStyleColors = false;
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.CustomBackground = false;
            this.metroLabel17.CustomForeColor = true;
            this.metroLabel17.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel17.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel17.Location = new System.Drawing.Point(849, 327);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(170, 25);
            this.metroLabel17.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel17.StyleManager = null;
            this.metroLabel17.TabIndex = 38;
            this.metroLabel17.Text = "Avg. Read B/Request";
            this.metroLabel17.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel17.UseStyleColors = false;
            // 
            // lblAvgReadB
            // 
            this.lblAvgReadB.AutoSize = true;
            this.lblAvgReadB.CustomBackground = false;
            this.lblAvgReadB.CustomForeColor = true;
            this.lblAvgReadB.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAvgReadB.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblAvgReadB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAvgReadB.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblAvgReadB.Location = new System.Drawing.Point(1044, 327);
            this.lblAvgReadB.Name = "lblAvgReadB";
            this.lblAvgReadB.Size = new System.Drawing.Size(19, 25);
            this.lblAvgReadB.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblAvgReadB.StyleManager = null;
            this.lblAvgReadB.TabIndex = 39;
            this.lblAvgReadB.Text = "-";
            this.lblAvgReadB.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblAvgReadB.UseStyleColors = false;
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.CustomBackground = false;
            this.metroLabel18.CustomForeColor = true;
            this.metroLabel18.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel18.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel18.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel18.Location = new System.Drawing.Point(579, 327);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(172, 25);
            this.metroLabel18.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel18.StyleManager = null;
            this.metroLabel18.TabIndex = 40;
            this.metroLabel18.Text = "Avg. Write B/Request";
            this.metroLabel18.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel18.UseStyleColors = false;
            // 
            // lblAvgWriteB
            // 
            this.lblAvgWriteB.AutoSize = true;
            this.lblAvgWriteB.CustomBackground = false;
            this.lblAvgWriteB.CustomForeColor = true;
            this.lblAvgWriteB.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAvgWriteB.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblAvgWriteB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAvgWriteB.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblAvgWriteB.Location = new System.Drawing.Point(808, 326);
            this.lblAvgWriteB.Name = "lblAvgWriteB";
            this.lblAvgWriteB.Size = new System.Drawing.Size(19, 25);
            this.lblAvgWriteB.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblAvgWriteB.StyleManager = null;
            this.lblAvgWriteB.TabIndex = 41;
            this.lblAvgWriteB.Text = "-";
            this.lblAvgWriteB.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblAvgWriteB.UseStyleColors = false;
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.CustomBackground = false;
            this.metroLabel19.CustomForeColor = true;
            this.metroLabel19.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel19.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel19.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel19.Location = new System.Drawing.Point(579, 379);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(193, 25);
            this.metroLabel19.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel19.StyleManager = null;
            this.metroLabel19.TabIndex = 42;
            this.metroLabel19.Text = "Avg. Transfer B/Request";
            this.metroLabel19.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel19.UseStyleColors = false;
            // 
            // lblAvgTransB
            // 
            this.lblAvgTransB.AutoSize = true;
            this.lblAvgTransB.CustomBackground = false;
            this.lblAvgTransB.CustomForeColor = true;
            this.lblAvgTransB.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAvgTransB.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblAvgTransB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAvgTransB.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblAvgTransB.Location = new System.Drawing.Point(808, 379);
            this.lblAvgTransB.Name = "lblAvgTransB";
            this.lblAvgTransB.Size = new System.Drawing.Size(19, 25);
            this.lblAvgTransB.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblAvgTransB.StyleManager = null;
            this.lblAvgTransB.TabIndex = 43;
            this.lblAvgTransB.Text = "-";
            this.lblAvgTransB.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblAvgTransB.UseStyleColors = false;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.CustomBackground = false;
            this.metroLabel6.CustomForeColor = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel6.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel6.Location = new System.Drawing.Point(583, 434);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(100, 25);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel6.StyleManager = null;
            this.metroLabel6.TabIndex = 44;
            this.metroLabel6.Text = "% Idle Time";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel6.UseStyleColors = false;
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.CustomBackground = false;
            this.metroLabel20.CustomForeColor = true;
            this.metroLabel20.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel20.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel20.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel20.Location = new System.Drawing.Point(583, 487);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(104, 25);
            this.metroLabel20.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel20.StyleManager = null;
            this.metroLabel20.TabIndex = 45;
            this.metroLabel20.Text = "% Disk Time";
            this.metroLabel20.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel20.UseStyleColors = false;
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.CustomBackground = false;
            this.metroLabel21.CustomForeColor = true;
            this.metroLabel21.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel21.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel21.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel21.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel21.Location = new System.Drawing.Point(583, 541);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(79, 25);
            this.metroLabel21.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel21.StyleManager = null;
            this.metroLabel21.TabIndex = 46;
            this.metroLabel21.Text = "I/O splits";
            this.metroLabel21.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel21.UseStyleColors = false;
            // 
            // lblIdleTime
            // 
            this.lblIdleTime.AutoSize = true;
            this.lblIdleTime.CustomBackground = false;
            this.lblIdleTime.CustomForeColor = true;
            this.lblIdleTime.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblIdleTime.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblIdleTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIdleTime.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblIdleTime.Location = new System.Drawing.Point(808, 434);
            this.lblIdleTime.Name = "lblIdleTime";
            this.lblIdleTime.Size = new System.Drawing.Size(19, 25);
            this.lblIdleTime.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblIdleTime.StyleManager = null;
            this.lblIdleTime.TabIndex = 47;
            this.lblIdleTime.Text = "-";
            this.lblIdleTime.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblIdleTime.UseStyleColors = false;
            // 
            // lblDiskTime
            // 
            this.lblDiskTime.AutoSize = true;
            this.lblDiskTime.CustomBackground = false;
            this.lblDiskTime.CustomForeColor = true;
            this.lblDiskTime.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDiskTime.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblDiskTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDiskTime.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblDiskTime.Location = new System.Drawing.Point(808, 487);
            this.lblDiskTime.Name = "lblDiskTime";
            this.lblDiskTime.Size = new System.Drawing.Size(19, 25);
            this.lblDiskTime.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDiskTime.StyleManager = null;
            this.lblDiskTime.TabIndex = 48;
            this.lblDiskTime.Text = "-";
            this.lblDiskTime.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblDiskTime.UseStyleColors = false;
            // 
            // lblIOSplit
            // 
            this.lblIOSplit.AutoSize = true;
            this.lblIOSplit.CustomBackground = false;
            this.lblIOSplit.CustomForeColor = true;
            this.lblIOSplit.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblIOSplit.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblIOSplit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIOSplit.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblIOSplit.Location = new System.Drawing.Point(808, 541);
            this.lblIOSplit.Name = "lblIOSplit";
            this.lblIOSplit.Size = new System.Drawing.Size(19, 25);
            this.lblIOSplit.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblIOSplit.StyleManager = null;
            this.lblIOSplit.TabIndex = 49;
            this.lblIOSplit.Text = "-";
            this.lblIOSplit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblIOSplit.UseStyleColors = false;
            // 
            // metroLabel22
            // 
            this.metroLabel22.AutoSize = true;
            this.metroLabel22.CustomBackground = false;
            this.metroLabel22.CustomForeColor = true;
            this.metroLabel22.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel22.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel22.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel22.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel22.Location = new System.Drawing.Point(579, 597);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(111, 25);
            this.metroLabel22.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel22.StyleManager = null;
            this.metroLabel22.TabIndex = 50;
            this.metroLabel22.Text = "% Read Time";
            this.metroLabel22.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel22.UseStyleColors = false;
            // 
            // lblReadTime
            // 
            this.lblReadTime.AutoSize = true;
            this.lblReadTime.CustomBackground = false;
            this.lblReadTime.CustomForeColor = true;
            this.lblReadTime.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblReadTime.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblReadTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblReadTime.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblReadTime.Location = new System.Drawing.Point(808, 597);
            this.lblReadTime.Name = "lblReadTime";
            this.lblReadTime.Size = new System.Drawing.Size(19, 25);
            this.lblReadTime.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblReadTime.StyleManager = null;
            this.lblReadTime.TabIndex = 51;
            this.lblReadTime.Text = "-";
            this.lblReadTime.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblReadTime.UseStyleColors = false;
            // 
            // metroLabel23
            // 
            this.metroLabel23.AutoSize = true;
            this.metroLabel23.CustomBackground = false;
            this.metroLabel23.CustomForeColor = true;
            this.metroLabel23.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel23.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel23.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel23.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel23.Location = new System.Drawing.Point(583, 658);
            this.metroLabel23.Name = "metroLabel23";
            this.metroLabel23.Size = new System.Drawing.Size(113, 25);
            this.metroLabel23.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel23.StyleManager = null;
            this.metroLabel23.TabIndex = 52;
            this.metroLabel23.Text = "% Write Time";
            this.metroLabel23.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel23.UseStyleColors = false;
            // 
            // lblWriteTime
            // 
            this.lblWriteTime.AutoSize = true;
            this.lblWriteTime.CustomBackground = false;
            this.lblWriteTime.CustomForeColor = true;
            this.lblWriteTime.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblWriteTime.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblWriteTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWriteTime.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblWriteTime.Location = new System.Drawing.Point(808, 649);
            this.lblWriteTime.Name = "lblWriteTime";
            this.lblWriteTime.Size = new System.Drawing.Size(19, 25);
            this.lblWriteTime.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblWriteTime.StyleManager = null;
            this.lblWriteTime.TabIndex = 53;
            this.lblWriteTime.Text = "-";
            this.lblWriteTime.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblWriteTime.UseStyleColors = false;
            // 
            // DiskPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1084, 728);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.Name = "DiskPerformance";
            this.ShowIcon = false;
            this.Text = "Disk Performance Monitor";
            this.Load += new System.EventHandler(this.DiskPerformance_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HDchart)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataVisualization.Charting.Chart HDchart;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnAvgTrans;
        private System.Windows.Forms.Button btnDiskQueue;
        private System.Windows.Forms.Button btnDiskTime;
        private System.Windows.Forms.Button btnIdleTime;
        private MetroFramework.Controls.MetroButton btnStart;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnStop;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblElapsedTime;
        private MetroFramework.Controls.MetroComboBox hostListComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblDiskReads;
        private MetroFramework.Controls.MetroLabel lblAvgWrite;
        private MetroFramework.Controls.MetroLabel lblAvgRead;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel lblTransMax;
        private MetroFramework.Controls.MetroLabel lblDiskTrans;
        private MetroFramework.Controls.MetroLabel lblDiskWrites;
        private MetroFramework.Controls.MetroLabel lblWriteTime;
        private MetroFramework.Controls.MetroLabel metroLabel23;
        private MetroFramework.Controls.MetroLabel lblReadTime;
        private MetroFramework.Controls.MetroLabel metroLabel22;
        private MetroFramework.Controls.MetroLabel lblIOSplit;
        private MetroFramework.Controls.MetroLabel lblDiskTime;
        private MetroFramework.Controls.MetroLabel lblIdleTime;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel lblAvgTransB;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel lblAvgWriteB;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel lblAvgReadB;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel lblDiskTransByte;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel lblDiskWriteBytes;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel lblDiskReadsBytes;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel lblAvgWriteQ;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel lblAvgReadQ;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel lblAvgDiskQ;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel lblCurrQLen;
    }
}