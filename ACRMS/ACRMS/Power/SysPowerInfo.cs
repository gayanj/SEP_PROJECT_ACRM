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
    public partial class SysPowerInfo : Form
    {
        const int SystemPowerInformation = 12;
        const uint STATUS_SUCCESS = 0;

        struct SYSTEM_POWER_INFORMATION
        {
            public uint MaxIdlenessAllowed;
            public uint Idleness;
            public uint TimeRemaining;
            public byte CoolingMode;
        }

        struct PROCESSOR_POWER_INFORMATION
        {
            public uint Number;
            public uint MaxMhz;
            public uint CurrentMhz;
            public uint MhzLimit;
            public uint MaxIdleState;
            public uint CurrentIdleState;
        }

        [DllImport("powrprof.dll")]
        static extern uint CallNtPowerInformation(
            int InformationLevel,
            IntPtr lpInputBuffer,
            int nInputBufferSize,
            out SYSTEM_POWER_INFORMATION spi,
            int nOutputBufferSize
        );

        public SysPowerInfo()
        {
            InitializeComponent();
        }

        private void SysPowerInfo_Load(object sender, EventArgs e)
        {
            SYSTEM_POWER_INFORMATION spi;
            PROCESSOR_POWER_INFORMATION ppi;

            uint retval = CallNtPowerInformation(
                SystemPowerInformation,
                IntPtr.Zero,
                0,
                out spi,
                Marshal.SizeOf(typeof(SYSTEM_POWER_INFORMATION))
            );

            maxIdlenessAllowed.Text = spi.MaxIdlenessAllowed.ToString();
            idleness.Text = spi.Idleness.ToString();
            timeRemaining.Text = spi.TimeRemaining.ToString();
            coolingMode.Text = spi.CoolingMode.ToString();

            ProcessorPowerInfo pi = new ProcessorPowerInfo();
            List<String> list = new List<string>();
            list=pi.getProcessorPowerInfo();

            currentProcessorIdle.Text = list[0];
            processorClockFreq.Text = list[1];
            maxProcessorIdle.Text = list[2];
            maxClockFreq.Text = list[3];
            limitProcessorCFreq.Text = list[4];

        }
    }


    class ProcessorPowerInfo
    {
        const int ProcessorPowerInformation = 11;
        const uint STATUS_SUCCESS = 0;

        [DllImport("kernel32.dll")]
        public static extern void GetSystemInfo([MarshalAs(UnmanagedType.Struct)] ref SYSTEM_INFO lpSystemInfo);

        [StructLayout(LayoutKind.Sequential)]
        public struct SYSTEM_INFO
        {
            internal _PROCESSOR_INFO_UNION uProcessorInfo;
            public uint dwPageSize;
            public IntPtr lpMinimumApplicationAddress;
            public IntPtr lpMaximumApplicationAddress;
            public IntPtr dwActiveProcessorMask;
            public uint dwNumberOfProcessors;
            public uint dwProcessorType;
            public uint dwAllocationGranularity;
            public ushort dwProcessorLevel;
            public ushort dwProcessorRevision;
        }

        struct PROCESSOR_POWER_INFORMATION
        {
            public uint Number;
            public uint MaxMhz;
            public uint CurrentMhz;
            public uint MhzLimit;
            public uint MaxIdleState;
            public uint CurrentIdleState;
        }
        [StructLayout(LayoutKind.Explicit)]
        public struct _PROCESSOR_INFO_UNION
        {
            [FieldOffset(0)]
            internal uint dwOemId;
            [FieldOffset(0)]
            internal ushort wProcessorArchitecture;
            [FieldOffset(2)]
            internal ushort wReserved;
        }


        [DllImport("powrprof.dll")]
        static extern uint CallNtPowerInformation(
            int InformationLevel,
            IntPtr lpInputBuffer,
            int nInputBufferSize,
            [Out] PROCESSOR_POWER_INFORMATION[] ppi,
            int nOutputBufferSize
        );

        public List<String> getProcessorPowerInfo()
        {
            List<String> list = new List<string>();

            SYSTEM_INFO sysinfo = new SYSTEM_INFO();
            GetSystemInfo(ref sysinfo);

            PROCESSOR_POWER_INFORMATION[] ppi = new PROCESSOR_POWER_INFORMATION[sysinfo.dwNumberOfProcessors];
            uint retval = CallNtPowerInformation(
                ProcessorPowerInformation,
                IntPtr.Zero,
                0,
                ppi,
               ppi.Length * Marshal.SizeOf(typeof(PROCESSOR_POWER_INFORMATION))
            );
            if (retval == STATUS_SUCCESS)
            {
                list.Add(ppi[0].CurrentIdleState.ToString());
                list.Add(ppi[0].CurrentMhz.ToString());
                list.Add(ppi[1].MaxIdleState.ToString());
                list.Add(ppi[0].MaxMhz.ToString());
                list.Add(ppi[0].MhzLimit.ToString());
            }
            return list;
        }
    }

}
