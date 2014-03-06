using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using ACRM.CPU;
using System.Collections;
using ACRM.HDisk; //for Disk
using System.IO;
using System.Threading.Tasks; //for Disk

namespace ACRM
{
    public partial class Form1 : Form
    {
        private delegate void pList();
        private delegate void pInfo();
        private ArrayList processList;
        private ArrayList processMonitor;
        private ProcessLocal pl;
        private DriveInfo[] allDrives; //for disk
        private WMIDisk wd;
        private ArrayList diskModel;
        public Form1()
        {
            InitializeComponent();

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Task task = new Task(getProcessList);
            task.Start();
            await task;
            //pList plist = getProcessList;
            //IAsyncResult res1 = plist.BeginInvoke(null, null);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Task task = new Task(getProcessInfo);
                task.Start();
                await Task.Delay(1000);
                task.Dispose();
            }
            //pInfo pInfo = getProcessInfo;
            //IAsyncResult res2 = pInfo.BeginInvoke(null, null);
        }

        /// <summary>
        /// This method is used to retrieve the current processes running in the machine
        /// </summary>
        private void getProcessList()
        {
            pl = new ProcessLocal();
            processList = pl.RunningProcesses();

            textBox1.SafeInvoke(d => d.Clear());
            label2.SafeInvoke(d => d.Visible = true);
            label1.SafeInvoke(d => d.Visible = true);
            label1.SafeInvoke(d => d.Text = processList.Count.ToString());

            comboBox1.SafeInvoke(d => d.DataSource = processList);

            for (int i = 0; i < processList.Count; i++)
            {
                string processName = processList[i].ToString();
                textBox1.SafeInvoke(d => d.AppendText("Process Name : " + processName + "\n"));
            }
        }

        /// <summary>
        /// This method is used to retrieve the CPU usage of a particular process
        /// </summary>
        private void getProcessInfo()
        {
            if (!label1.Text.Equals("ProccessNo"))
            {
                textBox2.SafeInvoke(d => d.Clear());
                string processSelected = comboBox1.SafeInvoke(d => d.SelectedItem.ToString());

                processMonitor = pl.ProcessMonitor(processSelected);

                for (int i = 0; i < processMonitor.Count; i++)
                {
                    string property = processMonitor[i].ToString();
                    textBox2.SafeInvoke(d => d.AppendText(property + "\n"));
                }
            }
            else
            {
                MessageBox.Show("Press Get Processess Button First");
            }
        }

        private void fileSysMonBtn_Click(object sender, EventArgs e)
        {
            FileSysMonForm fsForm1 = new FileSysMonForm();
            fsForm1.Show();
            fsForm1.Focus();
        }

        private void driveListCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selInd = driveListCombo.SelectedIndex;
            dNameLbl.Text = allDrives[selInd].Name.ToString();
            volLbl.Text = allDrives[selInd].VolumeLabel.ToString();
            dTypeLbl.Text = allDrives[selInd].DriveType.ToString();
            dFormatLbl.Text = allDrives[selInd].DriveFormat.ToString();
            totSizeLbl.Text = ExtraDiskMeth.SizeSuffix(allDrives[selInd].TotalSize);
            totFreeLbl.Text = ExtraDiskMeth.SizeSuffix(allDrives[selInd].TotalFreeSpace);
            totAvaLbl.Text = ExtraDiskMeth.SizeSuffix(allDrives[selInd].AvailableFreeSpace);
            if (allDrives[selInd].IsReady == true)
            {
                dStatLbl.Text = "On-Line";
                dStatLbl.BackColor = Color.Green;
            }
            else
            {
                dStatLbl.Text = "Off-Line";
                dStatLbl.BackColor = Color.Red;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Fill Volumes
            allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                driveListCombo.Items.Add(d.Name);
            }
            driveListCombo.SelectedIndex = 0;

            //Fill Physical Drives
            wd = new WMIDisk();
            diskModel = wd.DiskInf(wd.ms);
            foreach (var v in diskModel)
            {
                phyDiskComBox.DataSource = diskModel;
            }
        }

        private void phyDiskComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManagementObjectSearcher mos1 = wd.phyDiskInf(phyDiskComBox.SelectedItem.ToString());
            ManagementObjectCollection moc = mos1.Get();

            foreach (ManagementObject mo in moc)
            {
                lblSerial.Text = mo["SerialNumber"].ToString();
            }
        }
    }
}
