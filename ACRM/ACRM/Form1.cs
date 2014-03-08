﻿using System;
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
using System.IO; //for Disk

namespace ACRM
{
    public partial class Form1 : Form
    {
        private delegate void pList();
        private delegate void pInfo(string processName);
        private ArrayList processList;
        private ArrayList processInfo;
        private ProcessLocal pl;
        private DriveInfo[] allDrives; //For HDisk
        private WMIDisk wd; //For HDisk
        private ArrayList diskModelList; //For HDisk

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pList plist = getProcessList;
            IAsyncResult res1 = plist.BeginInvoke(null, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string processSelected = comboBox1.SelectedItem.ToString();
            pInfo pInfo = getProcessInfo;
            IAsyncResult res2 = pInfo.BeginInvoke(processSelected,null, null);
        }

        private void getProcessList()
        {
            pl = new ProcessLocal();
            processList = pl.RunningProcesses();

            //label1.Visible = true;
            label1.Text = processList.Count.ToString();

            comboBox1.DataSource = processList;
            for (int i = 0; i < processList.Count; i++)
            {
                string processName = processList[i].ToString();
                textBox1.AppendText("Process Name : " + processName);
            }
        }

        private void getProcessInfo(string processName)
        {
            processInfo = pl.ProcessProperties(processName);

            for (int i = 0; i < processList.Count; i++)
            {
                textBox2.AppendText(processInfo[i] + "\n");
            }
        }

        #region Codes for Hard Disk Monitor
        //show new File System Monitor Window
        private void fileSysMonBtn_Click(object sender, EventArgs e)
        {
            FileSysMonForm fsForm1 = new FileSysMonForm();
            fsForm1.Show();
            fsForm1.Focus();
        }

        //Fill Volume Information
        private void driveListCombo_SelectedIndexChanged(object sender, EventArgs e)
        {            
            int selInd = driveListCombo.SelectedIndex;

            dNameLbl.Text = allDrives[selInd].Name.ToString();
            dTypeLbl.Text = allDrives[selInd].DriveType.ToString();
            try
            {
                volLbl.Text = allDrives[selInd].VolumeLabel.ToString();
                dFormatLbl.Text = allDrives[selInd].DriveFormat.ToString();
                totSizeLbl.Text = ExtraDiskMeth.SizeSuffix(allDrives[selInd].TotalSize);
                totFreeLbl.Text = ExtraDiskMeth.SizeSuffix(allDrives[selInd].TotalFreeSpace);
                totAvaLbl.Text = ExtraDiskMeth.SizeSuffix(allDrives[selInd].AvailableFreeSpace);
            }
            catch (IOException ex)
            {
                volLbl.Text = "Volume Not Ready";
                dFormatLbl.Text = "Volume Not Ready";
                totAvaLbl.Text = "Volume Not Ready";
                totFreeLbl.Text = "Volume Not Ready";
                totSizeLbl.Text = "Volume Not Ready";
            }            
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

        //File the Volumes and Physical Drives Lists
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                driveListCombo.Items.Add(d.Name);
            }
            driveListCombo.SelectedIndex = 0;

            wd = new WMIDisk();
            diskModelList = wd.DiskInf(wd.ms);
            foreach (var v in diskModelList)
            {
                phyDiskComBox.DataSource = diskModelList;
            }
        }

        // Retrieve Disk Detail through WMI
        private void phyDiskComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManagementObjectSearcher mos1 = wd.phyDiskInf(phyDiskComBox.SelectedItem.ToString());
            ManagementObjectCollection moc = mos1.Get();

            foreach (ManagementObject mo in moc)
            {
                lblSerial.Text = mo["SerialNumber"].ToString().Trim();
                lblModel.Text = mo["Model"].ToString().Trim();
                lblInterface.Text = mo["InterfaceType"].ToString();
                lblCapacity.Text = ExtraDiskMeth.SizeSuffix(mo["Size"].ToString());
                lblPartitions.Text = mo["Partitions"].ToString();
                lblSig.Text = mo["Signature"].ToString();
                if (mo["FirmwareRevision"] == null)
                {
                    lblFirmware.Text = "-";
                }
                else
                {
                    lblFirmware.Text = mo["FirmwareRevision"].ToString();
                }
                lblCylinder.Text = mo["TotalCylinders"].ToString();
                lblSectors.Text = mo["TotalSectors"].ToString();
                lblHeads.Text = mo["TotalHeads"].ToString();
                lblTracks.Text = mo["TotalTracks"].ToString();
                lblBperSec.Text = mo["BytesPerSector"].ToString();
                lblSecPerTrack.Text = mo["SectorsPerTrack"].ToString();
                lblTrackPerCyl.Text = mo["TracksPerCylinder"].ToString();
            }
        }

        //Show New Disk Performance Window
        private void btnDiskPerf_Click(object sender, EventArgs e)
        {
            DiskPerformance dp = new DiskPerformance();
            dp.Show();
            dp.Focus();
        }
        #endregion
    }
}
