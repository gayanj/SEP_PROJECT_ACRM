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
                    driveListCombo.Items.Add(d.Name);
                }
                driveListCombo.SelectedIndex = 0;

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

        private void fileSysMonBtn1_Click(object sender, EventArgs e)
        {
            FileSysMonForm fsForm1 = new FileSysMonForm();
            fsForm1.Show();
            fsForm1.Focus();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DiskPerformance dp = new DiskPerformance();
            dp.Show();
            dp.Focus();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            DirSizeExplorer dse = new DirSizeExplorer();
            dse.Show();
            dse.Focus();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            InteliMonitorConfig imc = new InteliMonitorConfig();
            imc.Show();
            imc.Focus();
        }

        private void phyDiskComBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DiskProperties diskProperties = wd.GetDiskProperties(phyDiskComBox.SelectedItem.ToString());
            lblModel.Text = diskProperties.Model;
        }

        private void driveListCombo_SelectedIndexChanged_1(object sender, EventArgs e)
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
    }
}
