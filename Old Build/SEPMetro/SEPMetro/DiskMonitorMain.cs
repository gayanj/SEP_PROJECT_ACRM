using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACRM.HDisk;
using ACRM.HDisk.IntelliMon;
using System.Management;

namespace SEPMetro
{
    public partial class DiskMonitorMain : Form
    {
        private DriveInfo[] allDrives; //for disk
        private WMIDisk wd;
        private ArrayList diskModelList;
        bool loadReady = false;

        public DiskMonitorMain()
        {
            InitializeComponent();
        }

        private void fileSysMonBtn_Click(object sender, EventArgs e)
        {
            FileSysMonForm fsForm1 = new FileSysMonForm();
            fsForm1.Show();
            fsForm1.Focus();
        }

        private void btnDiskPerf_Click(object sender, EventArgs e)
        {
            DiskPerformance dp = new DiskPerformance();
            dp.Show();
            dp.Focus();
        }

        private void btnDirExplorer_Click(object sender, EventArgs e)
        {
            DirSizeExplorer dse = new DirSizeExplorer();
            dse.Show();
            dse.Focus();
        }

        private void btnInteliMonitor_Click(object sender, EventArgs e)
        {
            InteliMonitorConfig imc = new InteliMonitorConfig();
            imc.Show();
            imc.Focus();
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

        private void DiskMonitorMain_Load(object sender, EventArgs e)
        {
            this.loadDiskDetails();
        }

        private void loadDiskDetails()
        {
            if (loadReady == false)
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

                loadReady = true;
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
                //lblSig.Text = mo["Signature"].ToString();
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
    }
}
