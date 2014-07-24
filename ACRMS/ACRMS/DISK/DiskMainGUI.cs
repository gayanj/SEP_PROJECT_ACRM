using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Management;
using System.Windows.Forms;
using ACRMS.DISK.IntelliMon;

namespace ACRMS.DISK
{
    using ACRMS.DISK.DiskMonitorBundle;

    public partial class DiskMainGUI : Form
    {
        private DriveInfo[] allDrives;
        private WmiDiskInfo wd;
        private ArrayList diskModelList;
        bool loadReady;

        public DiskMainGUI()
        {
            InitializeComponent();
        }

        private void loadDiskDetails()
        {

            if (loadReady == false)
            {
                allDrives = DriveInfo.GetDrives();
                foreach (DriveInfo d in allDrives)
                {
                    volumeListCombo.Items.Add(d.Name);
                }
                volumeListCombo.SelectedIndex = 0;

                wd = new WmiDiskInfo();
                diskModelList = wd.GetDiskModelList(Environment.MachineName);
                foreach (var v in diskModelList)
                {
                    phyDiskComBox.DataSource = diskModelList;
                }

                loadReady = true;
            }
        }

        private void DiskMainGUI_Load(object sender, EventArgs e)
        {
            this.loadReady = false;
            this.loadDiskDetails();
        }
        
        private void phyDiskComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DiskProperties diskProperties = wd.GetDiskProperties(phyDiskComBox.SelectedItem.ToString());
            lblModel.Text = diskProperties.Model.Trim();
            //lblCapacity.Text = diskProperties.Size.Trim();
            lblCylinder.Text = diskProperties.TotalCylinders.Trim();
            lblBperSec.Text = ExtraDiskMeth.SizeSuffix(diskProperties.BytesPerSector);
            lblSerial.Text = diskProperties.SerialNumber.Trim();
        }

        private void volumeListCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selInd = volumeListCombo.SelectedIndex;

            lblVolName.Text = allDrives[selInd].Name.ToString();
            lblVolType.Text = allDrives[selInd].DriveType.ToString();
            try
            {
                lblVolLbl.Text = allDrives[selInd].VolumeLabel.ToString();
                lblVolFormat.Text = allDrives[selInd].DriveFormat.ToString();
                lblVolSize.Text = ExtraDiskMeth.SizeSuffix(allDrives[selInd].TotalSize);
                lblVolFreeSpc.Text = ExtraDiskMeth.SizeSuffix(allDrives[selInd].TotalFreeSpace);
                lblVolAvaFreeSpc.Text = ExtraDiskMeth.SizeSuffix(allDrives[selInd].AvailableFreeSpace);
            }
            catch (IOException ex)
            {
                lblVolLbl.Text = "Volume Not Ready";
                lblVolFormat.Text = "Volume Not Ready";
                lblVolAvaFreeSpc.Text = "Volume Not Ready";
                lblVolFreeSpc.Text = "Volume Not Ready";
                lblVolSize.Text = "Volume Not Ready";
            }
            if (allDrives[selInd].IsReady == true)
            {
                lblVolStatus.Text = "On-Line";
                lblVolStatus.ForeColor = Color.LimeGreen;
            }
            else
            {
                lblVolStatus.Text = "Off-Line";
                lblVolStatus.ForeColor = Color.Red;
            }
        }

        private void btnFileSysMon_Click(object sender, EventArgs e)
        {
            FileSysMonForm fileSysMon = new FileSysMonForm();
            fileSysMon.Show();
            fileSysMon.Focus();
        }

        private void btnDiskPerf_Click(object sender, EventArgs e)
        {
            DiskPerformance diskPerf = new DiskPerformance();
            diskPerf.Show();
            diskPerf.Focus();
        }

        private void btnDirExplorer_Click(object sender, EventArgs e)
        {
            DirSizeExplorer dirSize = new DirSizeExplorer();
            dirSize.Show();
            dirSize.Focus();
        }

        private void btnInteliMonitor_Click(object sender, EventArgs e)
        {
            InteliMonitorConfig inteliMonitor = new InteliMonitorConfig();
            inteliMonitor.Show();
            inteliMonitor.Focus();
        }
    }
}
