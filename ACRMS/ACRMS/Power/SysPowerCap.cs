using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEPMetro
{
    

    public struct SYSTEM_POWER_CAPABILITIES
    {
    public bool PowerButtonPresent;
    public bool SleepButtonPresent;
    public bool LidPresent;
    public bool SystemS1;
    public bool SystemS2;
    public bool SystemS3;
    public bool SystemS4;
    public bool SystemS5;
    public bool HiberFilePresent;
    public bool FullWake;
    public bool VideoDimPresent;
    public bool ApmPresent;
    public bool UpsPresent;
    public bool ThermalControl;
    public bool ProcessorThrottle;
    public byte ProcessorMinThrottle;
    public byte ProcessorMaxThrottle;
    public bool FastSystemS4;
    public bool WakeAlarmPresent;
    public bool HiberBoot;
    [MarshalAs( UnmanagedType.ByValArray, SizeConst = 3 )]
    public byte[] spare2;
    public bool DiskSpinDown;
    [MarshalAs( UnmanagedType.ByValArray, SizeConst = 8 )]
    public byte[] spare3;
    public bool SystemBatteriesPresent;
    public bool BatteriesAreShortTerm;
    [MarshalAs( UnmanagedType.ByValArray, SizeConst = 3 )]
    public BATTERY_REPORTING_SCALE[] BatteryScale;
    public SYSTEM_POWER_STATE AcOnLineWake;
    public SYSTEM_POWER_STATE SoftLidWake;
    public SYSTEM_POWER_STATE RtcWake;
    public SYSTEM_POWER_STATE MinDeviceWakeState;
    public SYSTEM_POWER_STATE DefaultLowLatencyWake;
}

    public struct BATTERY_REPORTING_SCALE
{
    public UInt32 Granularity;
    public UInt32 Capacity;
}

public enum SYSTEM_POWER_STATE
{
    PowerSystemUnspecified = 0,
    PowerSystemWorking = 1,
    PowerSystemSleeping1 = 2,
    PowerSystemSleeping2 = 3,
    PowerSystemSleeping3 = 4,
    PowerSystemHibernate = 5,
    PowerSystemShutdown = 6,
    PowerSystemMaximum = 7
}

    
   

    public partial class SysPowerCap : Form
    {
        [DllImport("powrprof.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetPwrCapabilities(out SYSTEM_POWER_CAPABILITIES systemPowerCapabilites);
        static SYSTEM_POWER_CAPABILITIES systemPowerCapabilites;

    
        public SysPowerCap()
        {
            InitializeComponent();
        }

        private void SysPowerCap_Load(object sender, EventArgs e)
        {
            powerButton.Text = systemPowerCapabilites.PowerButtonPresent.ToString();
            sleepButton.Text = systemPowerCapabilites.SleepButtonPresent.ToString();
            lidPresent.Text = systemPowerCapabilites.LidPresent.ToString();
            systemS1.Text = systemPowerCapabilites.SystemS1.ToString();
            systemS2.Text = systemPowerCapabilites.SystemS2.ToString();
            systemS3.Text = systemPowerCapabilites.SystemS3.ToString();
            systemS4.Text = systemPowerCapabilites.SystemS4.ToString();
            systemS5.Text = systemPowerCapabilites.SystemS5.ToString();
            hiberFilePresent.Text = systemPowerCapabilites.HiberFilePresent.ToString();
            fullWake.Text = systemPowerCapabilites.FullWake.ToString();
            videoDimPresent.Text = systemPowerCapabilites.VideoDimPresent.ToString();
            apmPresent.Text = systemPowerCapabilites.ApmPresent.ToString();
            upsPresent.Text = systemPowerCapabilites.UpsPresent.ToString();
            thermalControl.Text = systemPowerCapabilites.ThermalControl.ToString();
            processThrottle.Text = systemPowerCapabilites.ProcessorThrottle.ToString();
            processorMinThrottle.Text = systemPowerCapabilites.ProcessorMinThrottle.ToString();
            processorMaxThrottle.Text = systemPowerCapabilites.ProcessorMaxThrottle.ToString();
            fastSystem64.Text = systemPowerCapabilites.FastSystemS4.ToString();
            diskSpinDown.Text = systemPowerCapabilites.DiskSpinDown.ToString();
            hiberBoot.Text = systemPowerCapabilites.HiberBoot.ToString();
            wakeAlarm.Text = systemPowerCapabilites.WakeAlarmPresent.ToString();
            systemBatteriesPresent.Text = systemPowerCapabilites.SystemBatteriesPresent.ToString();
            acOnlineWake.Text = systemPowerCapabilites.AcOnLineWake.ToString();
            softLidWake.Text = systemPowerCapabilites.SoftLidWake.ToString();
            bAreShortTerm.Text = systemPowerCapabilites.BatteriesAreShortTerm.ToString();
            batteryScale.Text = systemPowerCapabilites.BatteriesAreShortTerm.ToString();
            rtcWake.Text = systemPowerCapabilites.RtcWake.ToString();
        }

    }
}
