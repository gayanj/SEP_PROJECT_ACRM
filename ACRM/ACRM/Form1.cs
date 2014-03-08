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
using System.Threading.Tasks;
using System.Threading; //for Disk

namespace ACRM
{
    public partial class Form1 : Form
    {
        private ProcessLocal pl;
        private System.Threading.Timer t;
        private DriveInfo[] allDrives; //for disk
        private WMIDisk wd;
        private ArrayList diskModelList;
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            dataGridView1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t = new System.Threading.Timer(new TimerCallback(getProcessInfo), null, 0, 1000);
            button2.Enabled = false;
            button1.Enabled = true;
        }

        /// <summary>
        /// This method is used to retrieve the CPU usage of a particular process
        /// </summary>
        private void getProcessInfo(object sender)
        {
            dataGridView1.SafeInvoke(d => d.Visible = true);
            int index = Int32.Parse(dataGridView1.FirstDisplayedScrollingRowIndex.ToString());
            pl = new ProcessLocal();
            DataTable processMonitor = new DataTable();
            processMonitor = pl.ProcessMonitor();
            dataGridView1.SafeInvoke(d => d.DataSource = processMonitor);

            if (index == -1)
            {
                dataGridView1.SafeInvoke(d => d.FirstDisplayedScrollingRowIndex = index + 1);
            }
            else
            {
                dataGridView1.SafeInvoke(d => d.FirstDisplayedScrollingRowIndex = index);
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
            diskModelList = wd.DiskInf(wd.ms);
            foreach (var v in diskModelList)
            {
                phyDiskComBox.DataSource = diskModelList;
            }
        }

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

        private void btnDiskPerf_Click(object sender, EventArgs e)
        {
            DiskPerformance dp = new DiskPerformance();
            dp.Show();
            dp.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button1.Enabled = false;
            t.Dispose();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int rows = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {            //Here 2 cell is target value and 1 cell is Volume
                if (Convert.ToInt32(row.Cells[2].Value) > 90)// Or your condition 
                {
                    dataGridView1.Rows[rows++].Cells[2].Style.ForeColor = Color.Red;
                }
                else
                {
                    dataGridView1.Rows[rows++].Cells[2].Style.ForeColor = Color.Green;
                }
            }
        }
    }
}
