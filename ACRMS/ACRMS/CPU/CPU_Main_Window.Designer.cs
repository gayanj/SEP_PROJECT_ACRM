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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
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
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Settings = new MetroFramework.Controls.MetroTabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.setTime = new MetroFramework.Controls.MetroButton();
            this.setUsage = new MetroFramework.Controls.MetroButton();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
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
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.Monitor);
            this.metroTabControl1.Controls.Add(this.Analysis);
            this.metroTabControl1.Controls.Add(this.Settings);
            this.metroTabControl1.CustomBackground = false;
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Medium;
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Light;
            this.metroTabControl1.Location = new System.Drawing.Point(12, 12);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(687, 510);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabControl1.StyleManager = null;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabControl1.UseStyleColors = false;
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
            chartArea1.Name = "ChartArea1";
            this.cpuChart.ChartAreas.Add(chartArea1);
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
            this.metroLabel1.Size = new System.Drawing.Size(166, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "High CPU Usage Processes";
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
            this.groupBox3.Controls.Add(this.setTime);
            this.groupBox3.Controls.Add(this.setUsage);
            this.groupBox3.Controls.Add(this.metroTextBox2);
            this.groupBox3.Controls.Add(this.metroLabel4);
            this.groupBox3.Controls.Add(this.metroCheckBox1);
            this.groupBox3.Controls.Add(this.metroTextBox1);
            this.groupBox3.Controls.Add(this.metroLabel3);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(680, 472);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
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
            this.setUsage.Location = new System.Drawing.Point(196, 12);
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
            this.metroCheckBox1.Location = new System.Drawing.Point(6, 122);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(170, 15);
            this.metroCheckBox1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroCheckBox1.StyleManager = null;
            this.metroCheckBox1.TabIndex = 3;
            this.metroCheckBox1.Text = "Automatically Kill Processes";
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
            this.metroTextBox1.Location = new System.Drawing.Point(145, 13);
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
            // CPU_Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 534);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "CPU_Main_Window";
            this.Text = "CPU_Main_Window";
            this.metroTabControl1.ResumeLayout(false);
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
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage Monitor;
        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}