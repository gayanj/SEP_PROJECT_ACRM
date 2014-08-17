namespace ACRMS.CPU
{
    partial class CPU_Main_Window
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.mainTabControl = new MetroFramework.Controls.MetroTabControl();
            this.Monitor = new MetroFramework.Controls.MetroTabPage();
            this.cpuChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Analysis = new MetroFramework.Controls.MetroTabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroButton8 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Settings = new MetroFramework.Controls.MetroTabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.setTime = new MetroFramework.Controls.MetroButton();
            this.setUsage = new MetroFramework.Controls.MetroButton();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.Browsers = new MetroFramework.Controls.MetroTabPage();
            this.metroButton7 = new MetroFramework.Controls.MetroButton();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.analyseData = new MetroFramework.Controls.MetroTabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.metroButton13 = new MetroFramework.Controls.MetroButton();
            this.metroButton10 = new MetroFramework.Controls.MetroButton();
            this.metroButton12 = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.metroButton11 = new MetroFramework.Controls.MetroButton();
            this.metroButton9 = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.metroButton14 = new MetroFramework.Controls.MetroButton();
            this.metroButton15 = new MetroFramework.Controls.MetroButton();
            this.mainTabControl.SuspendLayout();
            this.Monitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Analysis.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Settings.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Browsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.analyseData.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.Monitor);
            this.mainTabControl.Controls.Add(this.Analysis);
            this.mainTabControl.Controls.Add(this.Settings);
            this.mainTabControl.Controls.Add(this.Browsers);
            this.mainTabControl.Controls.Add(this.analyseData);
            this.mainTabControl.CustomBackground = false;
            this.mainTabControl.FontSize = MetroFramework.MetroTabControlSize.Medium;
            this.mainTabControl.FontWeight = MetroFramework.MetroTabControlWeight.Light;
            this.mainTabControl.Location = new System.Drawing.Point(12, 12);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 4;
            this.mainTabControl.Size = new System.Drawing.Size(687, 510);
            this.mainTabControl.Style = MetroFramework.MetroColorStyle.Blue;
            this.mainTabControl.StyleManager = null;
            this.mainTabControl.TabIndex = 0;
            this.mainTabControl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainTabControl.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mainTabControl.UseStyleColors = false;
            // 
            // Monitor
            // 
            this.Monitor.Controls.Add(this.cpuChart);
            this.Monitor.Controls.Add(this.dataGridView1);
            this.Monitor.CustomBackground = false;
            this.Monitor.HorizontalScrollbar = false;
            this.Monitor.HorizontalScrollbarBarColor = true;
            this.Monitor.HorizontalScrollbarHighlightOnWheel = false;
            this.Monitor.HorizontalScrollbarSize = 10;
            this.Monitor.Location = new System.Drawing.Point(4, 35);
            this.Monitor.Name = "Monitor";
            this.Monitor.Size = new System.Drawing.Size(679, 471);
            this.Monitor.Style = MetroFramework.MetroColorStyle.Blue;
            this.Monitor.StyleManager = null;
            this.Monitor.TabIndex = 0;
            this.Monitor.Text = "Monitor";
            this.Monitor.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Monitor.VerticalScrollbar = false;
            this.Monitor.VerticalScrollbarBarColor = true;
            this.Monitor.VerticalScrollbarHighlightOnWheel = false;
            this.Monitor.VerticalScrollbarSize = 10;
            // 
            // cpuChart
            // 
            chartArea6.Name = "ChartArea1";
            this.cpuChart.ChartAreas.Add(chartArea6);
            this.cpuChart.Location = new System.Drawing.Point(355, 3);
            this.cpuChart.Name = "cpuChart";
            this.cpuChart.Size = new System.Drawing.Size(324, 465);
            this.cpuChart.TabIndex = 3;
            this.cpuChart.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(349, 465);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Analysis
            // 
            this.Analysis.Controls.Add(this.groupBox2);
            this.Analysis.Controls.Add(this.groupBox1);
            this.Analysis.CustomBackground = false;
            this.Analysis.HorizontalScrollbar = false;
            this.Analysis.HorizontalScrollbarBarColor = true;
            this.Analysis.HorizontalScrollbarHighlightOnWheel = false;
            this.Analysis.HorizontalScrollbarSize = 10;
            this.Analysis.Location = new System.Drawing.Point(4, 35);
            this.Analysis.Name = "Analysis";
            this.Analysis.Size = new System.Drawing.Size(679, 471);
            this.Analysis.Style = MetroFramework.MetroColorStyle.Blue;
            this.Analysis.StyleManager = null;
            this.Analysis.TabIndex = 1;
            this.Analysis.Text = "Analysis";
            this.Analysis.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Analysis.VerticalScrollbar = false;
            this.Analysis.VerticalScrollbarBarColor = true;
            this.Analysis.VerticalScrollbarHighlightOnWheel = false;
            this.Analysis.VerticalScrollbarSize = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroButton6);
            this.groupBox2.Controls.Add(this.metroButton5);
            this.groupBox2.Controls.Add(this.metroButton4);
            this.groupBox2.Controls.Add(this.dataGridView3);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Location = new System.Drawing.Point(341, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 468);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // metroButton6
            // 
            this.metroButton6.Highlight = false;
            this.metroButton6.Location = new System.Drawing.Point(257, 38);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(75, 23);
            this.metroButton6.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton6.StyleManager = null;
            this.metroButton6.TabIndex = 4;
            this.metroButton6.Text = "Display All";
            this.metroButton6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // metroButton5
            // 
            this.metroButton5.Highlight = false;
            this.metroButton5.Location = new System.Drawing.Point(257, 96);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(75, 23);
            this.metroButton5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton5.StyleManager = null;
            this.metroButton5.TabIndex = 3;
            this.metroButton5.Text = "Clear All";
            this.metroButton5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Highlight = false;
            this.metroButton4.Location = new System.Drawing.Point(257, 67);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(75, 23);
            this.metroButton4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton4.StyleManager = null;
            this.metroButton4.TabIndex = 2;
            this.metroButton4.Text = "View Report";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 38);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(248, 421);
            this.dataGridView3.TabIndex = 1;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = false;
            this.metroLabel2.CustomForeColor = false;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel2.Location = new System.Drawing.Point(6, 16);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(123, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.StyleManager = null;
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Malicious Processes";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseStyleColors = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroButton8);
            this.groupBox1.Controls.Add(this.metroButton3);
            this.groupBox1.Controls.Add(this.metroButton2);
            this.groupBox1.Controls.Add(this.metroButton1);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 468);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // metroButton8
            // 
            this.metroButton8.Highlight = false;
            this.metroButton8.Location = new System.Drawing.Point(254, 125);
            this.metroButton8.Name = "metroButton8";
            this.metroButton8.Size = new System.Drawing.Size(75, 23);
            this.metroButton8.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton8.StyleManager = null;
            this.metroButton8.TabIndex = 5;
            this.metroButton8.Text = "Redis";
            this.metroButton8.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton8.Click += new System.EventHandler(this.metroButton8_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Highlight = false;
            this.metroButton3.Location = new System.Drawing.Point(254, 96);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(75, 23);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton3.StyleManager = null;
            this.metroButton3.TabIndex = 4;
            this.metroButton3.Text = "Clear All";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Highlight = false;
            this.metroButton2.Location = new System.Drawing.Point(254, 67);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton2.StyleManager = null;
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "All Time";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = false;
            this.metroButton1.Location = new System.Drawing.Point(254, 38);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.StyleManager = null;
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Past Hour";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 38);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(242, 421);
            this.dataGridView2.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.CustomForeColor = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(6, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(160, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "High CPU Usage Duration";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.groupBox3);
            this.Settings.CustomBackground = false;
            this.Settings.HorizontalScrollbar = false;
            this.Settings.HorizontalScrollbarBarColor = true;
            this.Settings.HorizontalScrollbarHighlightOnWheel = false;
            this.Settings.HorizontalScrollbarSize = 10;
            this.Settings.Location = new System.Drawing.Point(4, 35);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(679, 471);
            this.Settings.Style = MetroFramework.MetroColorStyle.Blue;
            this.Settings.StyleManager = null;
            this.Settings.TabIndex = 2;
            this.Settings.Text = "Settings";
            this.Settings.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Settings.VerticalScrollbar = false;
            this.Settings.VerticalScrollbarBarColor = true;
            this.Settings.VerticalScrollbarHighlightOnWheel = false;
            this.Settings.VerticalScrollbarSize = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroLabel7);
            this.groupBox3.Controls.Add(this.setTime);
            this.groupBox3.Controls.Add(this.setUsage);
            this.groupBox3.Controls.Add(this.metroTextBox2);
            this.groupBox3.Controls.Add(this.metroLabel4);
            this.groupBox3.Controls.Add(this.metroCheckBox1);
            this.groupBox3.Controls.Add(this.metroTextBox1);
            this.groupBox3.Controls.Add(this.metroLabel3);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(673, 465);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.CustomBackground = false;
            this.metroLabel7.CustomForeColor = false;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel7.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel7.Location = new System.Drawing.Point(6, 121);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(168, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel7.StyleManager = null;
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "Automatically Kill Processes";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel7.UseStyleColors = false;
            // 
            // setTime
            // 
            this.setTime.Highlight = false;
            this.setTime.Location = new System.Drawing.Point(227, 69);
            this.setTime.Name = "setTime";
            this.setTime.Size = new System.Drawing.Size(26, 23);
            this.setTime.Style = MetroFramework.MetroColorStyle.Blue;
            this.setTime.StyleManager = null;
            this.setTime.TabIndex = 7;
            this.setTime.Text = "Set";
            this.setTime.Theme = MetroFramework.MetroThemeStyle.Light;
            this.setTime.Click += new System.EventHandler(this.setTime_Click);
            // 
            // setUsage
            // 
            this.setUsage.Highlight = false;
            this.setUsage.Location = new System.Drawing.Point(227, 12);
            this.setUsage.Name = "setUsage";
            this.setUsage.Size = new System.Drawing.Size(26, 23);
            this.setUsage.Style = MetroFramework.MetroColorStyle.Blue;
            this.setUsage.StyleManager = null;
            this.setUsage.TabIndex = 6;
            this.setUsage.Text = "Set";
            this.setUsage.Theme = MetroFramework.MetroThemeStyle.Light;
            this.setUsage.Click += new System.EventHandler(this.setUsage_Click);
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.CustomBackground = false;
            this.metroTextBox2.CustomForeColor = false;
            this.metroTextBox2.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.metroTextBox2.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.metroTextBox2.Location = new System.Drawing.Point(176, 69);
            this.metroTextBox2.Multiline = false;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.Size = new System.Drawing.Size(45, 22);
            this.metroTextBox2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.StyleManager = null;
            this.metroTextBox2.TabIndex = 5;
            this.metroTextBox2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.UseStyleColors = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.CustomBackground = false;
            this.metroLabel4.CustomForeColor = false;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel4.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel4.Location = new System.Drawing.Point(6, 69);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(164, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel4.StyleManager = null;
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Wait Time For High Usage";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel4.UseStyleColors = false;
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.CustomBackground = false;
            this.metroCheckBox1.CustomForeColor = false;
            this.metroCheckBox1.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroCheckBox1.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroCheckBox1.Location = new System.Drawing.Point(176, 124);
            this.metroCheckBox1.MinimumSize = new System.Drawing.Size(16, 16);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(16, 16);
            this.metroCheckBox1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroCheckBox1.StyleManager = null;
            this.metroCheckBox1.TabIndex = 3;
            this.metroCheckBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroCheckBox1.UseStyleColors = false;
            this.metroCheckBox1.UseVisualStyleBackColor = true;
            this.metroCheckBox1.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.CustomBackground = false;
            this.metroTextBox1.CustomForeColor = false;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.metroTextBox1.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.metroTextBox1.Location = new System.Drawing.Point(176, 12);
            this.metroTextBox1.Multiline = false;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.Size = new System.Drawing.Size(45, 22);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.StyleManager = null;
            this.metroTextBox1.TabIndex = 1;
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.UseStyleColors = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.CustomBackground = false;
            this.metroLabel3.CustomForeColor = false;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel3.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel3.Location = new System.Drawing.Point(6, 16);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(133, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.StyleManager = null;
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "High CPU Uage Limit";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel3.UseStyleColors = false;
            // 
            // Browsers
            // 
            this.Browsers.Controls.Add(this.metroButton7);
            this.Browsers.Controls.Add(this.dataGridView4);
            this.Browsers.Controls.Add(this.metroLabel5);
            this.Browsers.CustomBackground = false;
            this.Browsers.HorizontalScrollbar = false;
            this.Browsers.HorizontalScrollbarBarColor = true;
            this.Browsers.HorizontalScrollbarHighlightOnWheel = false;
            this.Browsers.HorizontalScrollbarSize = 10;
            this.Browsers.Location = new System.Drawing.Point(4, 35);
            this.Browsers.Name = "Browsers";
            this.Browsers.Size = new System.Drawing.Size(679, 471);
            this.Browsers.Style = MetroFramework.MetroColorStyle.Blue;
            this.Browsers.StyleManager = null;
            this.Browsers.TabIndex = 3;
            this.Browsers.Text = "Browsers";
            this.Browsers.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Browsers.VerticalScrollbar = false;
            this.Browsers.VerticalScrollbarBarColor = true;
            this.Browsers.VerticalScrollbarHighlightOnWheel = false;
            this.Browsers.VerticalScrollbarSize = 10;
            // 
            // metroButton7
            // 
            this.metroButton7.Highlight = false;
            this.metroButton7.Location = new System.Drawing.Point(3, 441);
            this.metroButton7.Name = "metroButton7";
            this.metroButton7.Size = new System.Drawing.Size(122, 23);
            this.metroButton7.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton7.StyleManager = null;
            this.metroButton7.TabIndex = 4;
            this.metroButton7.Text = "Get Tab CPU Usage";
            this.metroButton7.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton7.Click += new System.EventHandler(this.metroButton7_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(3, 35);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(673, 400);
            this.dataGridView4.TabIndex = 3;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.CustomBackground = false;
            this.metroLabel5.CustomForeColor = false;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel5.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel5.Location = new System.Drawing.Point(3, 13);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(106, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel5.StyleManager = null;
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Internet Explorer";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel5.UseStyleColors = false;
            // 
            // analyseData
            // 
            this.analyseData.Controls.Add(this.groupBox5);
            this.analyseData.Controls.Add(this.groupBox4);
            this.analyseData.CustomBackground = false;
            this.analyseData.HorizontalScrollbar = false;
            this.analyseData.HorizontalScrollbarBarColor = true;
            this.analyseData.HorizontalScrollbarHighlightOnWheel = false;
            this.analyseData.HorizontalScrollbarSize = 10;
            this.analyseData.Location = new System.Drawing.Point(4, 35);
            this.analyseData.Name = "analyseData";
            this.analyseData.Size = new System.Drawing.Size(679, 471);
            this.analyseData.Style = MetroFramework.MetroColorStyle.Blue;
            this.analyseData.StyleManager = null;
            this.analyseData.TabIndex = 4;
            this.analyseData.Text = "Analyse Data";
            this.analyseData.Theme = MetroFramework.MetroThemeStyle.Light;
            this.analyseData.VerticalScrollbar = false;
            this.analyseData.VerticalScrollbarBarColor = true;
            this.analyseData.VerticalScrollbarHighlightOnWheel = false;
            this.analyseData.VerticalScrollbarSize = 10;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.metroButton15);
            this.groupBox5.Controls.Add(this.metroButton14);
            this.groupBox5.Controls.Add(this.dateTimePicker2);
            this.groupBox5.Controls.Add(this.metroLabel11);
            this.groupBox5.Controls.Add(this.metroLabel10);
            this.groupBox5.Controls.Add(this.metroLabel9);
            this.groupBox5.Controls.Add(this.dateTimePicker1);
            this.groupBox5.Controls.Add(this.metroButton13);
            this.groupBox5.Controls.Add(this.metroButton10);
            this.groupBox5.Controls.Add(this.metroButton12);
            this.groupBox5.Controls.Add(this.metroLabel8);
            this.groupBox5.Controls.Add(this.dataGridView6);
            this.groupBox5.Location = new System.Drawing.Point(328, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(348, 465);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(245, 239);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(70, 20);
            this.dateTimePicker2.TabIndex = 11;
            this.dateTimePicker2.Value = new System.DateTime(2014, 8, 24, 0, 0, 0, 0);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.CustomBackground = false;
            this.metroLabel11.CustomForeColor = false;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel11.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel11.Location = new System.Drawing.Point(245, 221);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(20, 15);
            this.metroLabel11.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel11.StyleManager = null;
            this.metroLabel11.TabIndex = 10;
            this.metroLabel11.Text = "To";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel11.UseStyleColors = false;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.CustomBackground = false;
            this.metroLabel10.CustomForeColor = false;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel10.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel10.Location = new System.Drawing.Point(245, 137);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(97, 19);
            this.metroLabel10.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel10.StyleManager = null;
            this.metroLabel10.TabIndex = 9;
            this.metroLabel10.Text = "Select Duration";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel10.UseStyleColors = false;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.CustomBackground = false;
            this.metroLabel9.CustomForeColor = false;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel9.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel9.Location = new System.Drawing.Point(245, 167);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(34, 15);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel9.StyleManager = null;
            this.metroLabel9.TabIndex = 8;
            this.metroLabel9.Text = "From";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel9.UseStyleColors = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(245, 185);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(70, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // metroButton13
            // 
            this.metroButton13.Highlight = false;
            this.metroButton13.Location = new System.Drawing.Point(245, 67);
            this.metroButton13.Name = "metroButton13";
            this.metroButton13.Size = new System.Drawing.Size(97, 23);
            this.metroButton13.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton13.StyleManager = null;
            this.metroButton13.TabIndex = 6;
            this.metroButton13.Text = "Past Month";
            this.metroButton13.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton13.Click += new System.EventHandler(this.metroButton13_Click);
            // 
            // metroButton10
            // 
            this.metroButton10.Highlight = false;
            this.metroButton10.Location = new System.Drawing.Point(245, 96);
            this.metroButton10.Name = "metroButton10";
            this.metroButton10.Size = new System.Drawing.Size(97, 23);
            this.metroButton10.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton10.StyleManager = null;
            this.metroButton10.TabIndex = 5;
            this.metroButton10.Text = "All Time";
            this.metroButton10.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton10.Click += new System.EventHandler(this.metroButton10_Click);
            // 
            // metroButton12
            // 
            this.metroButton12.Highlight = false;
            this.metroButton12.Location = new System.Drawing.Point(245, 38);
            this.metroButton12.Name = "metroButton12";
            this.metroButton12.Size = new System.Drawing.Size(97, 23);
            this.metroButton12.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton12.StyleManager = null;
            this.metroButton12.TabIndex = 4;
            this.metroButton12.Text = "Past Week";
            this.metroButton12.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton12.Click += new System.EventHandler(this.metroButton12_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.CustomBackground = false;
            this.metroLabel8.CustomForeColor = false;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel8.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel8.Location = new System.Drawing.Point(6, 16);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(148, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel8.StyleManager = null;
            this.metroLabel8.TabIndex = 3;
            this.metroLabel8.Text = "CPU Intensive Processes";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel8.UseStyleColors = false;
            // 
            // dataGridView6
            // 
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(6, 38);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(233, 421);
            this.dataGridView6.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.metroButton11);
            this.groupBox4.Controls.Add(this.metroButton9);
            this.groupBox4.Controls.Add(this.metroLabel6);
            this.groupBox4.Controls.Add(this.dataGridView5);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(319, 465);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // metroButton11
            // 
            this.metroButton11.Highlight = false;
            this.metroButton11.Location = new System.Drawing.Point(234, 67);
            this.metroButton11.Name = "metroButton11";
            this.metroButton11.Size = new System.Drawing.Size(75, 23);
            this.metroButton11.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton11.StyleManager = null;
            this.metroButton11.TabIndex = 5;
            this.metroButton11.Text = "All Time";
            this.metroButton11.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton11.Click += new System.EventHandler(this.metroButton11_Click);
            // 
            // metroButton9
            // 
            this.metroButton9.Highlight = false;
            this.metroButton9.Location = new System.Drawing.Point(234, 38);
            this.metroButton9.Name = "metroButton9";
            this.metroButton9.Size = new System.Drawing.Size(75, 23);
            this.metroButton9.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton9.StyleManager = null;
            this.metroButton9.TabIndex = 4;
            this.metroButton9.Text = "Past Week";
            this.metroButton9.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton9.Click += new System.EventHandler(this.metroButton9_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.CustomBackground = false;
            this.metroLabel6.CustomForeColor = false;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel6.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel6.Location = new System.Drawing.Point(6, 16);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(131, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel6.StyleManager = null;
            this.metroLabel6.TabIndex = 3;
            this.metroLabel6.Text = "Most Used Processes";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel6.UseStyleColors = false;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(6, 38);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(222, 421);
            this.dataGridView5.TabIndex = 2;
            // 
            // metroButton14
            // 
            this.metroButton14.Highlight = false;
            this.metroButton14.Location = new System.Drawing.Point(245, 294);
            this.metroButton14.Name = "metroButton14";
            this.metroButton14.Size = new System.Drawing.Size(97, 23);
            this.metroButton14.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton14.StyleManager = null;
            this.metroButton14.TabIndex = 17;
            this.metroButton14.Text = "Generate Graph";
            this.metroButton14.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton14.Click += new System.EventHandler(this.metroButton14_Click);
            // 
            // metroButton15
            // 
            this.metroButton15.Highlight = false;
            this.metroButton15.Location = new System.Drawing.Point(245, 265);
            this.metroButton15.Name = "metroButton15";
            this.metroButton15.Size = new System.Drawing.Size(97, 23);
            this.metroButton15.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton15.StyleManager = null;
            this.metroButton15.TabIndex = 18;
            this.metroButton15.Text = "Display Results";
            this.metroButton15.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton15.Click += new System.EventHandler(this.metroButton15_Click);
            // 
            // CPU_Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 534);
            this.Controls.Add(this.mainTabControl);
            this.Name = "CPU_Main_Window";
            this.Text = "CPU_Main_Window";
            this.mainTabControl.ResumeLayout(false);
            this.Monitor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Analysis.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Settings.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Browsers.ResumeLayout(false);
            this.Browsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.analyseData.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mainTabControl;
        private MetroFramework.Controls.MetroTabPage Monitor;
        private MetroFramework.Controls.MetroTabPage Analysis;
        private MetroFramework.Controls.MetroTabPage Settings;
        private System.Windows.Forms.DataVisualization.Charting.Chart cpuChart;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton setTime;
        private MetroFramework.Controls.MetroButton setUsage;
        private MetroFramework.Controls.MetroButton metroButton6;
        private MetroFramework.Controls.MetroTabPage Browsers;
        private MetroFramework.Controls.MetroButton metroButton7;
        private System.Windows.Forms.DataGridView dataGridView4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton metroButton8;
        private MetroFramework.Controls.MetroTabPage analyseData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.DataGridView dataGridView5;
        private MetroFramework.Controls.MetroButton metroButton11;
        private MetroFramework.Controls.MetroButton metroButton9;
        private System.Windows.Forms.GroupBox groupBox5;
        private MetroFramework.Controls.MetroButton metroButton10;
        private MetroFramework.Controls.MetroButton metroButton12;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroFramework.Controls.MetroButton metroButton13;
        private MetroFramework.Controls.MetroButton metroButton14;
        private MetroFramework.Controls.MetroButton metroButton15;
    }
}