namespace ACRM
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.totAvaLbl = new System.Windows.Forms.Label();
            this.totFreeLbl = new System.Windows.Forms.Label();
            this.totSizeLbl = new System.Windows.Forms.Label();
            this.dFormatLbl = new System.Windows.Forms.Label();
            this.dTypeLbl = new System.Windows.Forms.Label();
            this.volLbl = new System.Windows.Forms.Label();
            this.dNameLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loadDrivesBtn = new System.Windows.Forms.Button();
            this.driveListCombo = new System.Windows.Forms.ComboBox();
            this.fileSysMonBtn = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.dStatLbl = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 561);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 535);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CPU";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(366, 36);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(420, 492);
            this.textBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(506, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(280, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(365, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Get Process Information";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of Current Processes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ProccessNo";
            this.label1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 35);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(353, 494);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Processess";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 535);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RAM";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dStatLbl);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.totAvaLbl);
            this.tabPage3.Controls.Add(this.totFreeLbl);
            this.tabPage3.Controls.Add(this.totSizeLbl);
            this.tabPage3.Controls.Add(this.dFormatLbl);
            this.tabPage3.Controls.Add(this.dTypeLbl);
            this.tabPage3.Controls.Add(this.volLbl);
            this.tabPage3.Controls.Add(this.dNameLbl);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.loadDrivesBtn);
            this.tabPage3.Controls.Add(this.driveListCombo);
            this.tabPage3.Controls.Add(this.fileSysMonBtn);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 535);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hard Disk";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // totAvaLbl
            // 
            this.totAvaLbl.AutoSize = true;
            this.totAvaLbl.Location = new System.Drawing.Point(165, 111);
            this.totAvaLbl.Name = "totAvaLbl";
            this.totAvaLbl.Size = new System.Drawing.Size(50, 13);
            this.totAvaLbl.TabIndex = 16;
            this.totAvaLbl.Text = "Available";
            // 
            // totFreeLbl
            // 
            this.totFreeLbl.AutoSize = true;
            this.totFreeLbl.Location = new System.Drawing.Point(165, 98);
            this.totFreeLbl.Name = "totFreeLbl";
            this.totFreeLbl.Size = new System.Drawing.Size(28, 13);
            this.totFreeLbl.TabIndex = 15;
            this.totFreeLbl.Text = "Free";
            // 
            // totSizeLbl
            // 
            this.totSizeLbl.AutoSize = true;
            this.totSizeLbl.Location = new System.Drawing.Point(165, 85);
            this.totSizeLbl.Name = "totSizeLbl";
            this.totSizeLbl.Size = new System.Drawing.Size(27, 13);
            this.totSizeLbl.TabIndex = 14;
            this.totSizeLbl.Text = "Size";
            // 
            // dFormatLbl
            // 
            this.dFormatLbl.AutoSize = true;
            this.dFormatLbl.Location = new System.Drawing.Point(165, 72);
            this.dFormatLbl.Name = "dFormatLbl";
            this.dFormatLbl.Size = new System.Drawing.Size(39, 13);
            this.dFormatLbl.TabIndex = 13;
            this.dFormatLbl.Text = "Format";
            // 
            // dTypeLbl
            // 
            this.dTypeLbl.AutoSize = true;
            this.dTypeLbl.Location = new System.Drawing.Point(165, 59);
            this.dTypeLbl.Name = "dTypeLbl";
            this.dTypeLbl.Size = new System.Drawing.Size(31, 13);
            this.dTypeLbl.TabIndex = 12;
            this.dTypeLbl.Text = "Type";
            // 
            // volLbl
            // 
            this.volLbl.AutoSize = true;
            this.volLbl.Location = new System.Drawing.Point(165, 46);
            this.volLbl.Name = "volLbl";
            this.volLbl.Size = new System.Drawing.Size(42, 13);
            this.volLbl.TabIndex = 11;
            this.volLbl.Text = "Volume";
            // 
            // dNameLbl
            // 
            this.dNameLbl.AutoSize = true;
            this.dNameLbl.Location = new System.Drawing.Point(165, 33);
            this.dNameLbl.Name = "dNameLbl";
            this.dNameLbl.Size = new System.Drawing.Size(35, 13);
            this.dNameLbl.TabIndex = 10;
            this.dNameLbl.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Available Free Space";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Total Free Space";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Total Size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Drive Format";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Drive Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Volume Label";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Drive Name";
            // 
            // loadDrivesBtn
            // 
            this.loadDrivesBtn.Location = new System.Drawing.Point(212, 7);
            this.loadDrivesBtn.Name = "loadDrivesBtn";
            this.loadDrivesBtn.Size = new System.Drawing.Size(75, 23);
            this.loadDrivesBtn.TabIndex = 2;
            this.loadDrivesBtn.Text = "Load Drives";
            this.loadDrivesBtn.UseVisualStyleBackColor = true;
            this.loadDrivesBtn.Click += new System.EventHandler(this.loadDrivesBtn_Click);
            // 
            // driveListCombo
            // 
            this.driveListCombo.FormattingEnabled = true;
            this.driveListCombo.Location = new System.Drawing.Point(6, 9);
            this.driveListCombo.Name = "driveListCombo";
            this.driveListCombo.Size = new System.Drawing.Size(200, 21);
            this.driveListCombo.TabIndex = 1;
            this.driveListCombo.SelectedIndexChanged += new System.EventHandler(this.driveListCombo_SelectedIndexChanged);
            // 
            // fileSysMonBtn
            // 
            this.fileSysMonBtn.Location = new System.Drawing.Point(679, 7);
            this.fileSysMonBtn.Name = "fileSysMonBtn";
            this.fileSysMonBtn.Size = new System.Drawing.Size(107, 23);
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
            this.tabPage4.Size = new System.Drawing.Size(792, 535);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Network";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Drive Status";
            // 
            // dStatLbl
            // 
            this.dStatLbl.AutoSize = true;
            this.dStatLbl.Location = new System.Drawing.Point(165, 124);
            this.dStatLbl.Name = "dStatLbl";
            this.dStatLbl.Size = new System.Drawing.Size(37, 13);
            this.dStatLbl.TabIndex = 18;
            this.dStatLbl.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 563);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Automated Computer Resource Management System";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button fileSysMonBtn;
        private System.Windows.Forms.ComboBox driveListCombo;
        private System.Windows.Forms.Button loadDrivesBtn;
        private System.Windows.Forms.Label totAvaLbl;
        private System.Windows.Forms.Label totFreeLbl;
        private System.Windows.Forms.Label totSizeLbl;
        private System.Windows.Forms.Label dFormatLbl;
        private System.Windows.Forms.Label dTypeLbl;
        private System.Windows.Forms.Label volLbl;
        private System.Windows.Forms.Label dNameLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dStatLbl;
        private System.Windows.Forms.Label label10;
    }
}

