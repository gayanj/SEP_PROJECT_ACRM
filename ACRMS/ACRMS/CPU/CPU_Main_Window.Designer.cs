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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.Monitor = new MetroFramework.Controls.MetroTabPage();
            this.cpuChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Analysis = new MetroFramework.Controls.MetroTabPage();
            this.Settings = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl1.SuspendLayout();
            this.Monitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.metroTabControl1.SelectedIndex = 0;
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
            chartArea2.Name = "ChartArea1";
            this.cpuChart.ChartAreas.Add(chartArea2);
            this.cpuChart.Location = new System.Drawing.Point(355, 3);
            this.cpuChart.Name = "cpuChart";
            this.cpuChart.Size = new System.Drawing.Size(328, 465);
            this.cpuChart.TabIndex = 3;
            this.cpuChart.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(353, 465);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Analysis
            // 
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
            // Settings
            // 
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
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage Monitor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTabPage Analysis;
        private MetroFramework.Controls.MetroTabPage Settings;
        private System.Windows.Forms.DataVisualization.Charting.Chart cpuChart;
    }
}