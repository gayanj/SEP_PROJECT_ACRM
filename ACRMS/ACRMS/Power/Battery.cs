using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEPMetro
{
    public partial class Battery : Form
    {
        SelectQuery Sq;
        ManagementObjectSearcher objOSDetails;
        ManagementObjectCollection osDetailsCollection;
        StringBuilder sb;
        Timer t;

        public Battery()
        {
            InitializeComponent();
        }

        private void Battery_Load(object sender, EventArgs e)
        {
            t = new Timer { Enabled = true, Interval = 1000 };
            t.Tick += t_Tick;
            batteryAvailability.TextChanged += new EventHandler(this.t_Tick);

        }

        void t_Tick(object sender, EventArgs e)
        {
            Sq = new SelectQuery("Win32_Battery");
            objOSDetails = new ManagementObjectSearcher(Sq);
            osDetailsCollection = objOSDetails.Get();
            sb = new StringBuilder();

            foreach (ManagementObject mo in osDetailsCollection)
            {
                batteryAvailability.Text = ((ushort)mo["Availability"]).ToString();
                batteryRechargeTime.Text = (string)mo["BatteryRechargeTime"];
                batteryStatus.Text = ((ushort)mo["BatteryStatus"]).ToString();
                caption.Text = (string)mo["Caption"];
                chemistry.Text = ((ushort)mo["Chemistry"]).ToString();
                installDate.Text = Convert.ToDateTime(mo["InstallDate"]).ToString();
                //  sb.AppendLine(string.Format("ConfigManagerUserConfig: {0}", (string)mo["ConfigManagerUserConfig"]));
                //  sb.AppendLine(string.Format("CreationClassName : {0}", (string)mo["CreationClassName"]));
                description.Text = (string)mo["Description"];
                designCapacity.Text = (string)mo["DesignCapacity"];
                designVoltage.Text = ((ulong)mo["DesignVoltage"]).ToString();
                deviceID.Text = (string)mo["DeviceID"];
                //   sb.AppendLine(string.Format("ErrorCleared: {0}", (string)mo["ErrorCleared"]));
                //   sb.AppendLine(string.Format("ErrorDescription : {0}", (string)mo["ErrorDescription"]));
                estCharge.Text = ((ushort)mo["EstimatedChargeRemaining"]).ToString();
                estRun.Text = mo["EstimatedRunTime"].ToString();
                expBattry.Text = (string)mo["ExpectedBatteryLife"];
                expLife.Text = (string)mo["ExpectedLife"];
                fullChargeCap.Text = (string)mo["FullChargeCapacity"];
                //    sb.AppendLine(string.Format("LastErrorCode : {0}", (string)mo["LastErrorCode"]));
                maxRechargeTime.Text = (string)mo["MaxRechargeTime"];
                name.Text = (string.Format("Name : {0}", (string)mo["Name"]));
                //     sb.AppendLine(string.Format("PNPDeviceID: {0}", (string)mo["PNPDeviceID"]));
                powerManSupport.Text = mo["PowerManagementSupported"].ToString();
                smartBatteryVersion.Text = (string)mo["SmartBatteryVersion"];
                batStatus.Text = (string.Format("Status : {0}", (string)mo["Status"]));
                //    sb.AppendLine(string.Format("SystemCreationClassName : {0}", (string)mo["SystemCreationClassName"]));
                systemName.Text = (string)mo["SystemName"];
                timeToFullCharge.Text = (string)mo["TimeToFullCharge"];
                timeOnBattery.Text = (string)mo["TimeOnBattery"];
                UInt16[] PowerManagement = (UInt16[])mo["PowerManagementCapabilities"];
                foreach (uint version in PowerManagement)
                {
                    powerManCap.Text = version.ToString();
                }
            }
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
