using System.Diagnostics;
using ACRMS.DISK.DiskDataHandler;

namespace ACRMS.DISK.DiskMonitorBundle
{
    public class PerfCounterHD
    {
        #region IO Counters Definition

        private PerformanceCounter diskReads = new PerformanceCounter();
        private PerformanceCounter diskReadsB = new PerformanceCounter();
        private PerformanceCounter diskTransB = new PerformanceCounter();
        private PerformanceCounter diskTransfers = new PerformanceCounter();
        private PerformanceCounter diskWrites = new PerformanceCounter();
        private PerformanceCounter diskWritesB = new PerformanceCounter();

        #endregion IO Counters Definition

        #region Average IO Counters Definition

        private PerformanceCounter avgDiskRead = new PerformanceCounter();
        private PerformanceCounter avgDiskReadB = new PerformanceCounter();
        private PerformanceCounter avgDiskTrans = new PerformanceCounter();
        private PerformanceCounter avgDiskTransB = new PerformanceCounter();
        private PerformanceCounter avgDiskWrite = new PerformanceCounter();
        private PerformanceCounter avgDiskWriteB = new PerformanceCounter();

        #endregion Average IO Counters Definition

        #region Queue Counters Definition

        private PerformanceCounter avgDiskQueue = new PerformanceCounter();
        private PerformanceCounter avgDiskReadQueue = new PerformanceCounter();
        private PerformanceCounter avgDiskWriteQueue = new PerformanceCounter();
        private PerformanceCounter currQueueLen = new PerformanceCounter();

        #endregion Queue Counters Definition

        #region Time Counters Definitions

        private PerformanceCounter diskIdleTime = new PerformanceCounter();
        private PerformanceCounter diskIOSplit = new PerformanceCounter();
        private PerformanceCounter diskReadTime = new PerformanceCounter();
        private PerformanceCounter diskTime = new PerformanceCounter();
        private PerformanceCounter diskWriteTime = new PerformanceCounter();

        #endregion Time Counters Definitions

        public PerfCounterHD(string machineName)
        {
            this.InitPerfCountersIO(machineName);
            this.InitPerfCountersQueue(machineName);
            this.InitPerfCountersTime(machineName);
            this.InitPerfCoutersAvg(machineName);
        }

        #region Counter Initialization

        private void InitPerfCountersIO(string machineName)
        {
            this.diskReads.CategoryName = "PhysicalDisk";
            this.diskReads.CounterName = "Disk Reads/sec";
            this.diskReads.InstanceName = "_Total";

            this.diskWrites.CategoryName = "PhysicalDisk";
            this.diskWrites.CounterName = "Disk Writes/sec";
            this.diskWrites.InstanceName = "_Total";

            this.diskTransfers.CategoryName = "PhysicalDisk";
            this.diskTransfers.CounterName = "Disk Transfers/sec";
            this.diskTransfers.InstanceName = "_Total";

            this.diskReadsB.CategoryName = "PhysicalDisk";
            this.diskReadsB.CounterName = "Disk Read Bytes/sec";
            this.diskReadsB.InstanceName = "_Total";

            this.diskWritesB.CategoryName = "PhysicalDisk";
            this.diskWritesB.CounterName = "Disk Write Bytes/sec";
            this.diskWritesB.InstanceName = "_Total";

            this.diskTransB.CategoryName = "PhysicalDisk";
            this.diskTransB.CounterName = "Disk Bytes/sec";
            this.diskTransB.InstanceName = "_Total";
        }

        private void InitPerfCountersQueue(string machineName)
        {
            this.avgDiskQueue.CategoryName = "PhysicalDisk";
            this.avgDiskQueue.CounterName = "Avg. Disk Queue Length";
            this.avgDiskQueue.InstanceName = "_Total";

            this.avgDiskReadQueue.CategoryName = "PhysicalDisk";
            this.avgDiskReadQueue.CounterName = "Avg. Disk Read Queue Length";
            this.avgDiskReadQueue.InstanceName = "_Total";

            this.avgDiskWriteQueue.CategoryName = "PhysicalDisk";
            this.avgDiskWriteQueue.CounterName = "Avg. Disk Write Queue Length";
            this.avgDiskWriteQueue.InstanceName = "_Total";

            this.currQueueLen.CategoryName = "PhysicalDisk";
            this.currQueueLen.CounterName = "Current Disk Queue Length";
            this.currQueueLen.InstanceName = "_Total";
        }

        private void InitPerfCountersTime(string machineName)
        {
            this.diskTime.CategoryName = "PhysicalDisk";
            this.diskTime.CounterName = "% Disk Time";
            this.diskTime.InstanceName = "_Total";

            this.diskReadTime.CategoryName = "PhysicalDisk";
            this.diskReadTime.CounterName = "% Disk Read Time";
            this.diskReadTime.InstanceName = "_Total";

            this.diskWriteTime.CategoryName = "PhysicalDisk";
            this.diskWriteTime.CounterName = "% Disk Write Time";
            this.diskWriteTime.InstanceName = "_Total";

            this.diskIdleTime.CategoryName = "PhysicalDisk";
            this.diskIdleTime.CounterName = "% Idle Time";
            this.diskIdleTime.InstanceName = "_Total";

            this.diskIOSplit.CategoryName = "PhysicalDisk";
            this.diskIOSplit.CounterName = "Split IO/Sec";
            this.diskIOSplit.InstanceName = "_Total";
        }

        private void InitPerfCoutersAvg(string machineName)
        {
            this.avgDiskRead.CategoryName = "PhysicalDisk";
            this.avgDiskRead.CounterName = "Avg. Disk sec/Read";
            this.avgDiskRead.InstanceName = "_Total";

            this.avgDiskWrite.CategoryName = "PhysicalDisk";
            this.avgDiskWrite.CounterName = "Avg. Disk sec/Write";
            this.avgDiskWrite.InstanceName = "_Total";

            this.avgDiskTrans.CategoryName = "PhysicalDisk";
            this.avgDiskTrans.CounterName = "Avg. Disk sec/Transfer";
            this.avgDiskTrans.InstanceName = "_Total";

            this.avgDiskReadB.CategoryName = "PhysicalDisk";
            this.avgDiskReadB.CounterName = "Avg. Disk Bytes/Read";
            this.avgDiskReadB.InstanceName = "_Total";

            this.avgDiskWriteB.CategoryName = "PhysicalDisk";
            this.avgDiskWriteB.CounterName = "Avg. Disk Bytes/Write";
            this.avgDiskWriteB.InstanceName = "_Total";

            this.avgDiskTransB.CategoryName = "PhysicalDisk";
            this.avgDiskTransB.CounterName = "Avg. Disk Bytes/Transfer";
            this.avgDiskTransB.InstanceName = "_Total";
        }

        #endregion Counter Initialization

        #region IO Returns

        private float DiskReads { get { return this.diskReads.NextValue(); } }

        private float DiskReadsB { get { return this.diskReadsB.NextValue(); } }

        private float DiskTransB { get { return this.diskTransB.NextValue(); } }

        private float DiskTransfers { get { return this.diskTransfers.NextValue(); } }

        private float DiskWrites { get { return this.diskWrites.NextValue(); } }

        private float DiskWritesB { get { return this.diskWritesB.NextValue(); } }

        #endregion IO Returns

        #region Average IO Returns

        private float AvgDiskRead { get { return this.avgDiskRead.NextValue(); } }

        private float AvgDiskReadB { get { return this.avgDiskReadB.NextValue(); } }

        private float AvgDiskTrans { get { return this.avgDiskTrans.NextValue(); } }

        private float AvgDiskTransB { get { return this.avgDiskTransB.NextValue(); } }

        private float AvgDiskWrite { get { return this.avgDiskWrite.NextValue(); } }

        private float AvgDiskWriteB { get { return this.avgDiskWriteB.NextValue(); } }

        #endregion Average IO Returns

        #region Queue Returns

        private float AvgDiskQueue { get { return this.avgDiskQueue.NextValue(); } }

        private float AvgDiskReadQueue { get { return this.avgDiskReadQueue.NextValue(); } }

        private float AvgDiskWriteQueue { get { return this.avgDiskWriteQueue.NextValue(); } }

        private float CurrQueueLen { get { return this.currQueueLen.NextValue(); } }

        #endregion Queue Returns

        #region Time Returns

        private float DiskIdleTime { get { return this.diskIdleTime.NextValue(); } }

        private float DiskIOSplit { get { return this.diskIOSplit.NextValue(); } }

        private float DiskReadTime { get { return this.diskReadTime.NextValue(); } }

        private float DiskTime { get { return this.diskTime.NextValue(); } }

        private float DiskWriteTime { get { return this.diskWriteTime.NextValue(); } }

        #endregion Time Returns

        public void DestroyCounters()
        {
            this.diskTime.Dispose();
            this.diskReadTime.Dispose();
            this.diskWriteTime.Dispose();
            this.diskIdleTime.Dispose();
            this.diskIOSplit.Dispose();

            this.avgDiskQueue.Dispose();
            this.avgDiskReadQueue.Dispose();
            this.avgDiskWriteQueue.Dispose();
            this.currQueueLen.Dispose();

            this.avgDiskRead.Dispose();
            this.avgDiskWrite.Dispose();
            this.avgDiskTrans.Dispose();

            this.avgDiskReadB.Dispose();
            this.avgDiskWriteB.Dispose();
            this.avgDiskTransB.Dispose();

            this.diskReadsB.Dispose();
            this.diskWritesB.Dispose();
            this.diskTransB.Dispose();

            this.diskReads.Dispose();
            this.diskTransfers.Dispose();
            this.diskWrites.Dispose();
        }

        public DiskDataValues GetValues()
        {
            DiskDataValues diskDataValues = new DiskDataValues();

            diskDataValues.DiskReads = this.DiskReads;
            diskDataValues.DiskWrites = this.DiskWrites;
            diskDataValues.DiskTransfers = this.DiskTransfers;
            diskDataValues.DiskReadsB = this.DiskReadsB;
            diskDataValues.DiskWritesB = this.DiskWritesB;
            diskDataValues.DiskTransB = this.DiskTransB;
            diskDataValues.AvgDiskRead = this.AvgDiskRead;
            diskDataValues.AvgDiskWrite = this.AvgDiskWrite;
            diskDataValues.AvgDiskTrans = this.AvgDiskTrans;
            diskDataValues.AvgDiskReadB = this.AvgDiskReadB;
            diskDataValues.AvgDiskWriteB = this.AvgDiskReadB;
            diskDataValues.AvgDiskTransB = this.AvgDiskReadB;
            diskDataValues.AvgDiskQueue = this.AvgDiskQueue;
            diskDataValues.AvgDiskReadQueue = this.AvgDiskReadQueue;
            diskDataValues.AvgDiskWriteQueue = this.AvgDiskReadQueue;
            diskDataValues.CurrQueueLen = this.CurrQueueLen;
            diskDataValues.DiskTime = this.DiskTime;
            diskDataValues.DiskReadTime = this.DiskReadTime;
            diskDataValues.DiskWriteTime = this.DiskWriteTime;
            diskDataValues.DiskIdleTime = this.DiskIdleTime;
            diskDataValues.DiskIoSplit = this.DiskIOSplit;

            return diskDataValues;
        }
    }
}