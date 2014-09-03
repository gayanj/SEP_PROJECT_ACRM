using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACRMS.DISK.DiskDataHandler
{
    using System.Diagnostics;
    using System.IO;
    using System.Windows.Forms;

    using ACRMS.DISK.DiskMonitorBundle;

    internal class LogTextWriter
    {
        private PerfCounterHD perfCounter;
        private DiskDataValues diskDataValues;
        private string hostName;
        private string hostIp;

        public LogTextWriter(string hostName, string hostIp)
        {
            this.hostName = hostName;
            this.hostIp = hostIp;
            perfCounter = new PerfCounterHD(this.hostName);

        }

        public void Log()
        {
                diskDataValues = perfCounter.GetValues();
            string text = DateTime.UtcNow + " (UTC 0)" + "\t" + this.hostName + "\t" + this.hostIp + "\t"
                          + Math.Round(diskDataValues.DiskReads, 2, MidpointRounding.AwayFromZero) + "\t"
                          + Math.Round(diskDataValues.DiskWrites, 2, MidpointRounding.AwayFromZero) + "\t"
                          + Math.Round(diskDataValues.DiskTransfers, 2, MidpointRounding.AwayFromZero) + "\t"
                          + ExtraDiskMeth.SizeSuffix(
                              Math.Round(diskDataValues.DiskReadsB, 2, MidpointRounding.AwayFromZero).ToString()) + "\t"
                          + ExtraDiskMeth.SizeSuffix(
                              Math.Round(diskDataValues.DiskWritesB, 2, MidpointRounding.AwayFromZero).ToString()) + "\t"
                          + ExtraDiskMeth.SizeSuffix(
                              Math.Round(diskDataValues.DiskTransB, 2, MidpointRounding.AwayFromZero).ToString()) + "\t"
                          + Math.Round(diskDataValues.AvgDiskRead, 2, MidpointRounding.AwayFromZero) + "\t"
                          + Math.Round(diskDataValues.AvgDiskWrite, 2, MidpointRounding.AwayFromZero) + "\t"
                          + Math.Round(diskDataValues.AvgDiskTrans, 2, MidpointRounding.AwayFromZero) + "\t"
                          + ExtraDiskMeth.SizeSuffix(
                              Math.Round(diskDataValues.AvgDiskReadB, 2, MidpointRounding.AwayFromZero).ToString()) + "\t"
                          + ExtraDiskMeth.SizeSuffix(
                              Math.Round(diskDataValues.AvgDiskWriteB, 2, MidpointRounding.AwayFromZero).ToString()) + "\t"
                          + ExtraDiskMeth.SizeSuffix(
                              Math.Round(diskDataValues.AvgDiskTransB, 2, MidpointRounding.AwayFromZero).ToString()) + "\t" 
                          + Math.Round(diskDataValues.CurrQueueLen, 2, MidpointRounding.AwayFromZero) + "\t"
                          + Math.Round(diskDataValues.AvgDiskReadQueue, 2, MidpointRounding.AwayFromZero) + "\t"
                          + Math.Round(diskDataValues.AvgDiskWriteQueue, 2, MidpointRounding.AwayFromZero) + "\t"
                          + Math.Round(diskDataValues.AvgDiskQueue, 2, MidpointRounding.AwayFromZero) + "\t"
                          + Math.Round(diskDataValues.DiskIoSplit, 2, MidpointRounding.AwayFromZero) + "\t"
                          + Math.Round(diskDataValues.DiskTime, 2, MidpointRounding.AwayFromZero) + "\t"
                          + Math.Round(diskDataValues.DiskIdleTime, 2, MidpointRounding.AwayFromZero) + "\t"
                          + Math.Round(diskDataValues.DiskReadTime, 2, MidpointRounding.AwayFromZero) + "\t"
                          + Math.Round(diskDataValues.DiskWriteTime, 2, MidpointRounding.AwayFromZero) + "\n";
                File.AppendAllText(@"D:\mylog.txt",text);
            
        }
    }
}
