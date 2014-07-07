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
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.processNameValue = new System.Windows.Forms.Label();
            this.processName = new System.Windows.Forms.Label();
            this.cpuChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.metroButton3);
            this.tabPage1.Controls.Add(this.metroButton2);
            this.tabPage1.Controls.Add(this.metroButton1);
            this.tabPage1.Controls.Add(this.processNameValue);
            this.tabPage1.Controls.Add(this.processName);
            this.tabPage1.Controls.Add(this.cpuChart);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(854, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CPU";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // cpuChart
            // 
            this.cpuChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.cpuChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.cpuChart.Legends.Add(legend4);
            this.cpuChart.Location = new System.Drawing.Point(376, 35);
            this.cpuChart.Name = "cpuChart";
            this.cpuChart.Size = new System.Drawing.Size(470, 494);
            this.cpuChart.TabIndex = 9;
            this.cpuChart.Text = "chart1";
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(862, 563);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = false;
            this.metroButton1.Location = new System.Drawing.Point(8, 6);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(104, 23);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.StyleManager = null;
            this.metroButton1.TabIndex = 12;
            this.metroButton1.Text = "Start Monitoring";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Highlight = false;
            this.metroButton2.Location = new System.Drawing.Point(127, 6);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(102, 23);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton2.StyleManager = null;
            this.metroButton2.TabIndex = 13;
            this.metroButton2.Text = "Stop Monitoring";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Highlight = false;
            this.metroButton3.Location = new System.Drawing.Point(245, 6);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(102, 23);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton3.StyleManager = null;
            this.metroButton3.TabIndex = 14;
            this.metroButton3.Text = "Monitor Browsers";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label processNameValue;
        private System.Windows.Forms.Label processName;
        private System.Windows.Forms.DataVisualization.Charting.Chart cpuChart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;

    }
}

