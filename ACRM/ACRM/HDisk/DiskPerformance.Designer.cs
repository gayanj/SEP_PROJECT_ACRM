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
            this.lblAvgTrans = new System.Windows.Forms.Label();
            this.lblAvgWrite = new System.Windows.Forms.Label();
            this.lblAvgRead = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAvgTransB = new System.Windows.Forms.Label();
            this.lblAvgWriteB = new System.Windows.Forms.Label();
            this.lblAvgReadB = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblAvgWriteQ = new System.Windows.Forms.Label();
            this.lblAvgReadQ = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblAvgDiskQ = new System.Windows.Forms.Label();
            this.lblCurrQLen = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblWriteTime = new System.Windows.Forms.Label();
            this.lblReadTime = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblIOSplit = new System.Windows.Forms.Label();
            this.lblDiskTime = new System.Windows.Forms.Label();
            this.lblIdleTime = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Disk Reads B/Sec";
            // 
            // lblDiskReadsBytes
            // 
            this.lblDiskReadsBytes.AutoSize = true;
            this.lblDiskReadsBytes.Location = new System.Drawing.Point(135, 25);
            this.lblDiskReadsBytes.Name = "lblDiskReadsBytes";
            this.lblDiskReadsBytes.Size = new System.Drawing.Size(35, 13);
            this.lblDiskReadsBytes.TabIndex = 8;
            this.lblDiskReadsBytes.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Disk Writes B/Sec";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Disk Transfer B/Sec";
            // 
            // lblDiskWriteBytes
            // 
            this.lblDiskWriteBytes.AutoSize = true;
            this.lblDiskWriteBytes.Location = new System.Drawing.Point(135, 47);
            this.lblDiskWriteBytes.Name = "lblDiskWriteBytes";
            this.lblDiskWriteBytes.Size = new System.Drawing.Size(35, 13);
            this.lblDiskWriteBytes.TabIndex = 11;
            this.lblDiskWriteBytes.Text = "label7";
            // 
            // lblDiskTransByte
            // 
            this.lblDiskTransByte.AutoSize = true;
            this.lblDiskTransByte.Location = new System.Drawing.Point(135, 71);
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
            this.groupBox1.Controls.Add(this.lblAvgTrans);
            this.groupBox1.Controls.Add(this.lblAvgWrite);
            this.groupBox1.Controls.Add(this.lblAvgRead);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblTransMax);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblDiskReads);
            this.groupBox1.Controls.Add(this.lblDiskWrites);
            this.groupBox1.Controls.Add(this.lblDiskTrans);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 133);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "I/O Requests/Sec";
            // 
            // lblAvgTrans
            // 
            this.lblAvgTrans.AutoSize = true;
            this.lblAvgTrans.Location = new System.Drawing.Point(346, 71);
            this.lblAvgTrans.Name = "lblAvgTrans";
            this.lblAvgTrans.Size = new System.Drawing.Size(41, 13);
            this.lblAvgTrans.TabIndex = 20;
            this.lblAvgTrans.Text = "label13";
            // 
            // lblAvgWrite
            // 
            this.lblAvgWrite.AutoSize = true;
            this.lblAvgWrite.Location = new System.Drawing.Point(346, 47);
            this.lblAvgWrite.Name = "lblAvgWrite";
            this.lblAvgWrite.Size = new System.Drawing.Size(41, 13);
            this.lblAvgWrite.TabIndex = 19;
            this.lblAvgWrite.Text = "label12";
            // 
            // lblAvgRead
            // 
            this.lblAvgRead.AutoSize = true;
            this.lblAvgRead.Location = new System.Drawing.Point(346, 25);
            this.lblAvgRead.Name = "lblAvgRead";
            this.lblAvgRead.Size = new System.Drawing.Size(41, 13);
            this.lblAvgRead.TabIndex = 18;
            this.lblAvgRead.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(218, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Avg. Transfers/Sec";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(218, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Avg. Writes/Sec";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(218, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Avg. Reads/Sec";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAvgTransB);
            this.groupBox2.Controls.Add(this.lblAvgWriteB);
            this.groupBox2.Controls.Add(this.lblAvgReadB);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblDiskReadsBytes);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblDiskWriteBytes);
            this.groupBox2.Controls.Add(this.lblDiskTransByte);
            this.groupBox2.Location = new System.Drawing.Point(12, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 115);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "I/O Bytes/Sec";
            // 
            // lblAvgTransB
            // 
            this.lblAvgTransB.AutoSize = true;
            this.lblAvgTransB.Location = new System.Drawing.Point(346, 71);
            this.lblAvgTransB.Name = "lblAvgTransB";
            this.lblAvgTransB.Size = new System.Drawing.Size(41, 13);
            this.lblAvgTransB.TabIndex = 18;
            this.lblAvgTransB.Text = "label16";
            // 
            // lblAvgWriteB
            // 
            this.lblAvgWriteB.AutoSize = true;
            this.lblAvgWriteB.Location = new System.Drawing.Point(346, 47);
            this.lblAvgWriteB.Name = "lblAvgWriteB";
            this.lblAvgWriteB.Size = new System.Drawing.Size(41, 13);
            this.lblAvgWriteB.TabIndex = 17;
            this.lblAvgWriteB.Text = "label15";
            // 
            // lblAvgReadB
            // 
            this.lblAvgReadB.AutoSize = true;
            this.lblAvgReadB.Location = new System.Drawing.Point(346, 25);
            this.lblAvgReadB.Name = "lblAvgReadB";
            this.lblAvgReadB.Size = new System.Drawing.Size(41, 13);
            this.lblAvgReadB.TabIndex = 16;
            this.lblAvgReadB.Text = "label14";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(218, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Avg. Transfer B/Request";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(218, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Avg. Write B/Request";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(218, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Avg. Read B/Request";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblAvgWriteQ);
            this.groupBox3.Controls.Add(this.lblAvgReadQ);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.lblAvgDiskQ);
            this.groupBox3.Controls.Add(this.lblCurrQLen);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(12, 302);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(444, 100);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Disk Queue";
            // 
            // lblAvgWriteQ
            // 
            this.lblAvgWriteQ.AutoSize = true;
            this.lblAvgWriteQ.Location = new System.Drawing.Point(346, 48);
            this.lblAvgWriteQ.Name = "lblAvgWriteQ";
            this.lblAvgWriteQ.Size = new System.Drawing.Size(41, 13);
            this.lblAvgWriteQ.TabIndex = 7;
            this.lblAvgWriteQ.Text = "label21";
            // 
            // lblAvgReadQ
            // 
            this.lblAvgReadQ.AutoSize = true;
            this.lblAvgReadQ.Location = new System.Drawing.Point(346, 26);
            this.lblAvgReadQ.Name = "lblAvgReadQ";
            this.lblAvgReadQ.Size = new System.Drawing.Size(41, 13);
            this.lblAvgReadQ.TabIndex = 6;
            this.lblAvgReadQ.Text = "label20";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(218, 48);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 13);
            this.label19.TabIndex = 5;
            this.label19.Text = "Avg. Write Queue";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(218, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Avg. Read Queue";
            // 
            // lblAvgDiskQ
            // 
            this.lblAvgDiskQ.AutoSize = true;
            this.lblAvgDiskQ.Location = new System.Drawing.Point(135, 48);
            this.lblAvgDiskQ.Name = "lblAvgDiskQ";
            this.lblAvgDiskQ.Size = new System.Drawing.Size(41, 13);
            this.lblAvgDiskQ.TabIndex = 3;
            this.lblAvgDiskQ.Text = "label17";
            // 
            // lblCurrQLen
            // 
            this.lblCurrQLen.AutoSize = true;
            this.lblCurrQLen.Location = new System.Drawing.Point(135, 26);
            this.lblCurrQLen.Name = "lblCurrQLen";
            this.lblCurrQLen.Size = new System.Drawing.Size(41, 13);
            this.lblCurrQLen.TabIndex = 2;
            this.lblCurrQLen.Text = "label16";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Avg. Disk Queue";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Current Queue Length";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblWriteTime);
            this.groupBox4.Controls.Add(this.lblReadTime);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.lblIOSplit);
            this.groupBox4.Controls.Add(this.lblDiskTime);
            this.groupBox4.Controls.Add(this.lblIdleTime);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Location = new System.Drawing.Point(12, 409);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(444, 121);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Disk Times";
            // 
            // lblWriteTime
            // 
            this.lblWriteTime.AutoSize = true;
            this.lblWriteTime.Location = new System.Drawing.Point(349, 73);
            this.lblWriteTime.Name = "lblWriteTime";
            this.lblWriteTime.Size = new System.Drawing.Size(41, 13);
            this.lblWriteTime.TabIndex = 9;
            this.lblWriteTime.Text = "label27";
            // 
            // lblReadTime
            // 
            this.lblReadTime.AutoSize = true;
            this.lblReadTime.Location = new System.Drawing.Point(349, 49);
            this.lblReadTime.Name = "lblReadTime";
            this.lblReadTime.Size = new System.Drawing.Size(41, 13);
            this.lblReadTime.TabIndex = 8;
            this.lblReadTime.Text = "label26";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(218, 73);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(69, 13);
            this.label25.TabIndex = 7;
            this.label25.Text = "% Write Time";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(218, 49);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(70, 13);
            this.label24.TabIndex = 6;
            this.label24.Text = "% Read Time";
            // 
            // lblIOSplit
            // 
            this.lblIOSplit.AutoSize = true;
            this.lblIOSplit.Location = new System.Drawing.Point(135, 73);
            this.lblIOSplit.Name = "lblIOSplit";
            this.lblIOSplit.Size = new System.Drawing.Size(41, 13);
            this.lblIOSplit.TabIndex = 5;
            this.lblIOSplit.Text = "label23";
            // 
            // lblDiskTime
            // 
            this.lblDiskTime.AutoSize = true;
            this.lblDiskTime.Location = new System.Drawing.Point(135, 49);
            this.lblDiskTime.Name = "lblDiskTime";
            this.lblDiskTime.Size = new System.Drawing.Size(41, 13);
            this.lblDiskTime.TabIndex = 4;
            this.lblDiskTime.Text = "label22";
            // 
            // lblIdleTime
            // 
            this.lblIdleTime.AutoSize = true;
            this.lblIdleTime.Location = new System.Drawing.Point(135, 26);
            this.lblIdleTime.Name = "lblIdleTime";
            this.lblIdleTime.Size = new System.Drawing.Size(41, 13);
            this.lblIdleTime.TabIndex = 3;
            this.lblIdleTime.Text = "label21";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 73);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "I/O Splits";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 49);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "% Disk Time";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "% Idle Time";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 594);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(468, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // DiskPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(468, 616);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStart);
            this.Name = "DiskPerformance";
            this.Text = "DiskPerformance";
            this.Load += new System.EventHandler(this.DiskPerformance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAvgTrans;
        private System.Windows.Forms.Label lblAvgWrite;
        private System.Windows.Forms.Label lblAvgRead;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAvgTransB;
        private System.Windows.Forms.Label lblAvgWriteB;
        private System.Windows.Forms.Label lblAvgReadB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblAvgWriteQ;
        private System.Windows.Forms.Label lblAvgReadQ;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblAvgDiskQ;
        private System.Windows.Forms.Label lblCurrQLen;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblWriteTime;
        private System.Windows.Forms.Label lblReadTime;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblIOSplit;
        private System.Windows.Forms.Label lblDiskTime;
        private System.Windows.Forms.Label lblIdleTime;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}