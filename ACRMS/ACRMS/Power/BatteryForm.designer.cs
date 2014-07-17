namespace SEPMetro
{
    partial class BatteryForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.percentLeftProgressBar = new MetroFramework.Controls.MetroPanel();
            this.deviceState = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.diskStatus = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.batteryTimeLeft = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.powerBatteryState = new MetroFramework.Controls.MetroLabel();
            this.powerSource = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.batteryInfoButton = new MetroFramework.Controls.MetroButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.percentLeftProgressBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // percentLeftProgressBar
            // 
            this.percentLeftProgressBar.Controls.Add(this.deviceState);
            this.percentLeftProgressBar.Controls.Add(this.metroComboBox1);
            this.percentLeftProgressBar.Controls.Add(this.metroLabel6);
            this.percentLeftProgressBar.Controls.Add(this.metroButton4);
            this.percentLeftProgressBar.Controls.Add(this.metroButton3);
            this.percentLeftProgressBar.Controls.Add(this.diskStatus);
            this.percentLeftProgressBar.Controls.Add(this.metroLabel5);
            this.percentLeftProgressBar.Controls.Add(this.metroButton2);
            this.percentLeftProgressBar.Controls.Add(this.metroButton1);
            this.percentLeftProgressBar.Controls.Add(this.batteryTimeLeft);
            this.percentLeftProgressBar.Controls.Add(this.metroLabel4);
            this.percentLeftProgressBar.Controls.Add(this.metroProgressBar1);
            this.percentLeftProgressBar.Controls.Add(this.powerBatteryState);
            this.percentLeftProgressBar.Controls.Add(this.powerSource);
            this.percentLeftProgressBar.Controls.Add(this.metroLabel3);
            this.percentLeftProgressBar.Controls.Add(this.metroLabel2);
            this.percentLeftProgressBar.Controls.Add(this.metroLabel1);
            this.percentLeftProgressBar.Controls.Add(this.batteryInfoButton);
            this.percentLeftProgressBar.Controls.Add(this.chart1);
            this.percentLeftProgressBar.CustomBackground = false;
            this.percentLeftProgressBar.HorizontalScrollbar = false;
            this.percentLeftProgressBar.HorizontalScrollbarBarColor = true;
            this.percentLeftProgressBar.HorizontalScrollbarHighlightOnWheel = false;
            this.percentLeftProgressBar.HorizontalScrollbarSize = 10;
            this.percentLeftProgressBar.Location = new System.Drawing.Point(-1, 0);
            this.percentLeftProgressBar.Name = "percentLeftProgressBar";
            this.percentLeftProgressBar.Size = new System.Drawing.Size(1353, 742);
            this.percentLeftProgressBar.Style = MetroFramework.MetroColorStyle.Blue;
            this.percentLeftProgressBar.StyleManager = null;
            this.percentLeftProgressBar.TabIndex = 0;
            this.percentLeftProgressBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.percentLeftProgressBar.VerticalScrollbar = false;
            this.percentLeftProgressBar.VerticalScrollbarBarColor = true;
            this.percentLeftProgressBar.VerticalScrollbarHighlightOnWheel = false;
            this.percentLeftProgressBar.VerticalScrollbarSize = 10;
            // 
            // deviceState
            // 
            this.deviceState.AutoSize = true;
            this.deviceState.CustomBackground = false;
            this.deviceState.CustomForeColor = true;
            this.deviceState.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.deviceState.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.deviceState.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deviceState.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.deviceState.Location = new System.Drawing.Point(778, 571);
            this.deviceState.Name = "deviceState";
            this.deviceState.Size = new System.Drawing.Size(33, 25);
            this.deviceState.Style = MetroFramework.MetroColorStyle.Blue;
            this.deviceState.StyleManager = null;
            this.deviceState.TabIndex = 20;
            this.deviceState.Text = "---";
            this.deviceState.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.deviceState.UseStyleColors = false;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroComboBox1.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroComboBox1.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(635, 571);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroComboBox1.StyleManager = null;
            this.metroComboBox1.TabIndex = 19;
            this.metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
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
            this.metroLabel6.Location = new System.Drawing.Point(498, 571);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(116, 25);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel6.StyleManager = null;
            this.metroLabel6.TabIndex = 18;
            this.metroLabel6.Text = "Device Status:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel6.UseStyleColors = false;
            // 
            // metroButton4
            // 
            this.metroButton4.Highlight = false;
            this.metroButton4.Location = new System.Drawing.Point(215, 676);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(108, 42);
            this.metroButton4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton4.StyleManager = null;
            this.metroButton4.TabIndex = 17;
            this.metroButton4.Text = "SystemPowerInfo";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Highlight = false;
            this.metroButton3.Location = new System.Drawing.Point(382, 676);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(108, 42);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton3.StyleManager = null;
            this.metroButton3.TabIndex = 16;
            this.metroButton3.Text = "SystemPowerCap";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // diskStatus
            // 
            this.diskStatus.AutoSize = true;
            this.diskStatus.CustomBackground = false;
            this.diskStatus.CustomForeColor = true;
            this.diskStatus.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.diskStatus.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.diskStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.diskStatus.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.diskStatus.Location = new System.Drawing.Point(635, 525);
            this.diskStatus.Name = "diskStatus";
            this.diskStatus.Size = new System.Drawing.Size(33, 25);
            this.diskStatus.Style = MetroFramework.MetroColorStyle.Blue;
            this.diskStatus.StyleManager = null;
            this.diskStatus.TabIndex = 15;
            this.diskStatus.Text = "---";
            this.diskStatus.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.diskStatus.UseStyleColors = false;
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
            this.metroLabel5.Location = new System.Drawing.Point(498, 525);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(95, 25);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel5.StyleManager = null;
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "Disk status:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel5.UseStyleColors = false;
            // 
            // metroButton2
            // 
            this.metroButton2.Highlight = false;
            this.metroButton2.Location = new System.Drawing.Point(715, 676);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(108, 42);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton2.StyleManager = null;
            this.metroButton2.TabIndex = 13;
            this.metroButton2.Text = "Power scheme";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = false;
            this.metroButton1.Location = new System.Drawing.Point(546, 676);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(108, 42);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.StyleManager = null;
            this.metroButton1.TabIndex = 12;
            this.metroButton1.Text = "Power Info";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // batteryTimeLeft
            // 
            this.batteryTimeLeft.AutoSize = true;
            this.batteryTimeLeft.CustomBackground = false;
            this.batteryTimeLeft.CustomForeColor = true;
            this.batteryTimeLeft.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.batteryTimeLeft.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.batteryTimeLeft.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.batteryTimeLeft.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.batteryTimeLeft.Location = new System.Drawing.Point(635, 619);
            this.batteryTimeLeft.Name = "batteryTimeLeft";
            this.batteryTimeLeft.Size = new System.Drawing.Size(33, 25);
            this.batteryTimeLeft.Style = MetroFramework.MetroColorStyle.Blue;
            this.batteryTimeLeft.StyleManager = null;
            this.batteryTimeLeft.TabIndex = 11;
            this.batteryTimeLeft.Text = "---";
            this.batteryTimeLeft.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.batteryTimeLeft.UseStyleColors = false;
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
            this.metroLabel4.Location = new System.Drawing.Point(54, 619);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(138, 25);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel4.StyleManager = null;
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Battery Time Left";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseStyleColors = false;
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.FontSize = MetroFramework.MetroProgressBarSize.Medium;
            this.metroProgressBar1.FontWeight = MetroFramework.MetroProgressBarWeight.Light;
            this.metroProgressBar1.HideProgressText = true;
            this.metroProgressBar1.Location = new System.Drawing.Point(232, 619);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.metroProgressBar1.Size = new System.Drawing.Size(116, 23);
            this.metroProgressBar1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroProgressBar1.StyleManager = null;
            this.metroProgressBar1.TabIndex = 9;
            this.metroProgressBar1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroProgressBar1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // powerBatteryState
            // 
            this.powerBatteryState.AutoSize = true;
            this.powerBatteryState.CustomBackground = false;
            this.powerBatteryState.CustomForeColor = true;
            this.powerBatteryState.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.powerBatteryState.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.powerBatteryState.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.powerBatteryState.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.powerBatteryState.Location = new System.Drawing.Point(232, 571);
            this.powerBatteryState.Name = "powerBatteryState";
            this.powerBatteryState.Size = new System.Drawing.Size(33, 25);
            this.powerBatteryState.Style = MetroFramework.MetroColorStyle.Blue;
            this.powerBatteryState.StyleManager = null;
            this.powerBatteryState.TabIndex = 8;
            this.powerBatteryState.Text = "---";
            this.powerBatteryState.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.powerBatteryState.UseStyleColors = false;
            // 
            // powerSource
            // 
            this.powerSource.AutoSize = true;
            this.powerSource.CustomBackground = false;
            this.powerSource.CustomForeColor = true;
            this.powerSource.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.powerSource.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.powerSource.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.powerSource.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.powerSource.Location = new System.Drawing.Point(232, 525);
            this.powerSource.Name = "powerSource";
            this.powerSource.Size = new System.Drawing.Size(33, 25);
            this.powerSource.Style = MetroFramework.MetroColorStyle.Blue;
            this.powerSource.StyleManager = null;
            this.powerSource.TabIndex = 7;
            this.powerSource.Text = "---";
            this.powerSource.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.powerSource.UseStyleColors = false;
            this.powerSource.Click += new System.EventHandler(this.powerSource_Click);
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
            this.metroLabel3.Location = new System.Drawing.Point(54, 571);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(162, 25);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.StyleManager = null;
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Battery Percent Left:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseStyleColors = false;
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
            this.metroLabel2.Location = new System.Drawing.Point(54, 525);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(110, 25);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.StyleManager = null;
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Battery State:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseStyleColors = false;
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
            this.metroLabel1.Location = new System.Drawing.Point(498, 619);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(120, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Power Source:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = false;
            // 
            // batteryInfoButton
            // 
            this.batteryInfoButton.Highlight = false;
            this.batteryInfoButton.Location = new System.Drawing.Point(44, 676);
            this.batteryInfoButton.Name = "batteryInfoButton";
            this.batteryInfoButton.Size = new System.Drawing.Size(108, 42);
            this.batteryInfoButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.batteryInfoButton.StyleManager = null;
            this.batteryInfoButton.TabIndex = 3;
            this.batteryInfoButton.Text = "Battery Info";
            this.batteryInfoButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.batteryInfoButton.Click += new System.EventHandler(this.batteryInfoButton_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 13);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1309, 457);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // BatteryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.percentLeftProgressBar);
            this.Name = "BatteryForm";
            this.Text = "BatteryForm";
            this.Load += new System.EventHandler(this.BatteryForm_Load);
            this.percentLeftProgressBar.ResumeLayout(false);
            this.percentLeftProgressBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel percentLeftProgressBar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroButton batteryInfoButton;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroLabel powerBatteryState;
        private MetroFramework.Controls.MetroLabel powerSource;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel batteryTimeLeft;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel diskStatus;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel deviceState;
    }
}