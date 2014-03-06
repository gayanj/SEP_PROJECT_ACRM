namespace ACRM.HDisk
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDiskReads = new System.Windows.Forms.Label();
            this.lblDiskWrites = new System.Windows.Forms.Label();
            this.lblDiskTrans = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDiskReadsBytes = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDiskWriteBytes = new System.Windows.Forms.Label();
            this.lblDiskTransByte = new System.Windows.Forms.Label();
            this.lblTransMax = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Disk Reads/Sec";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Disk Writes/Sec";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Disk Transfer/Sec";
            // 
            // lblDiskReads
            // 
            this.lblDiskReads.AutoSize = true;
            this.lblDiskReads.Location = new System.Drawing.Point(135, 25);
            this.lblDiskReads.Name = "lblDiskReads";
            this.lblDiskReads.Size = new System.Drawing.Size(35, 13);
            this.lblDiskReads.TabIndex = 4;
            this.lblDiskReads.Text = "label4";
            // 
            // lblDiskWrites
            // 
            this.lblDiskWrites.AutoSize = true;
            this.lblDiskWrites.Location = new System.Drawing.Point(135, 47);
            this.lblDiskWrites.Name = "lblDiskWrites";
            this.lblDiskWrites.Size = new System.Drawing.Size(35, 13);
            this.lblDiskWrites.TabIndex = 5;
            this.lblDiskWrites.Text = "label4";
            // 
            // lblDiskTrans
            // 
            this.lblDiskTrans.AutoSize = true;
            this.lblDiskTrans.Location = new System.Drawing.Point(135, 71);
            this.lblDiskTrans.Name = "lblDiskTrans";
            this.lblDiskTrans.Size = new System.Drawing.Size(35, 13);
            this.lblDiskTrans.TabIndex = 6;
            this.lblDiskTrans.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Disk Reads B/Sec";
            // 
            // lblDiskReadsBytes
            // 
            this.lblDiskReadsBytes.AutoSize = true;
            this.lblDiskReadsBytes.Location = new System.Drawing.Point(355, 25);
            this.lblDiskReadsBytes.Name = "lblDiskReadsBytes";
            this.lblDiskReadsBytes.Size = new System.Drawing.Size(35, 13);
            this.lblDiskReadsBytes.TabIndex = 8;
            this.lblDiskReadsBytes.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Disk Writes B/Sec";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Disk Transfer B/Sec";
            // 
            // lblDiskWriteBytes
            // 
            this.lblDiskWriteBytes.AutoSize = true;
            this.lblDiskWriteBytes.Location = new System.Drawing.Point(355, 47);
            this.lblDiskWriteBytes.Name = "lblDiskWriteBytes";
            this.lblDiskWriteBytes.Size = new System.Drawing.Size(35, 13);
            this.lblDiskWriteBytes.TabIndex = 11;
            this.lblDiskWriteBytes.Text = "label7";
            // 
            // lblDiskTransByte
            // 
            this.lblDiskTransByte.AutoSize = true;
            this.lblDiskTransByte.Location = new System.Drawing.Point(355, 71);
            this.lblDiskTransByte.Name = "lblDiskTransByte";
            this.lblDiskTransByte.Size = new System.Drawing.Size(35, 13);
            this.lblDiskTransByte.TabIndex = 12;
            this.lblDiskTransByte.Text = "label8";
            // 
            // lblTransMax
            // 
            this.lblTransMax.AutoSize = true;
            this.lblTransMax.Location = new System.Drawing.Point(135, 94);
            this.lblTransMax.Name = "lblTransMax";
            this.lblTransMax.Size = new System.Drawing.Size(35, 13);
            this.lblTransMax.TabIndex = 13;
            this.lblTransMax.Text = "label7";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Disk Transfer Peak";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblTransMax);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblDiskTransByte);
            this.groupBox1.Controls.Add(this.lblDiskReads);
            this.groupBox1.Controls.Add(this.lblDiskWriteBytes);
            this.groupBox1.Controls.Add(this.lblDiskWrites);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblDiskTrans);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblDiskReadsBytes);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 133);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "I/O Rates";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(93, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 16;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // DiskPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(468, 464);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStart);
            this.Name = "DiskPerformance";
            this.Text = "DiskPerformance";
            this.Load += new System.EventHandler(this.DiskPerformance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDiskReads;
        private System.Windows.Forms.Label lblDiskWrites;
        private System.Windows.Forms.Label lblDiskTrans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDiskReadsBytes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDiskWriteBytes;
        private System.Windows.Forms.Label lblDiskTransByte;
        private System.Windows.Forms.Label lblTransMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStop;
    }
}