using System.Diagnostics;

namespace ACRMS.DISK.DiskMonitorBundle
{
    class PerfCounterHD
    {
        #region IO Counters Definition
        private PerformanceCounter diskReads = new PerformanceCounter();
        private PerformanceCounter diskWrites = new PerformanceCounter();
        private PerformanceCounter diskTransfers = new PerformanceCounter();

        private PerformanceCounter diskReadsB = new PerformanceCounter();
        private PerformanceCounter diskWritesB = new PerformanceCounter();
        private PerformanceCounter diskTransB = new PerformanceCounter();
        #endregion

        #region Average IO Counters Definition
        private PerformanceCounter avgDiskRead = new PerformanceCounter();
        private PerformanceCounter avgDiskWrite = new PerformanceCounter();
        private PerformanceCounter avgDiskTrans = new PerformanceCounter();

        private PerformanceCounter avgDiskReadB = new PerformanceCounter();
        private PerformanceCounter avgDiskWriteB = new PerformanceCounter();
        private PerformanceCounter avgDiskTransB = new PerformanceCounter();
        #endregion

        #region Queue Counters Definition
        private PerformanceCounter avgDiskQueue = new PerformanceCounter();
        private PerformanceCounter avgDiskReadQueue = new PerformanceCounter();
        private PerformanceCounter avgDiskWriteQueue = new PerformanceCounter();
        private PerformanceCounter currQueueLen = new PerformanceCounter();
        #endregion

        #region Time Counters Definitions
        private PerformanceCounter diskTime = new PerformanceCounter();
        private PerformanceCounter diskReadTime = new PerformanceCounter();
        private PerformanceCounter diskWriteTime = new PerformanceCounter();
        private PerformanceCounter diskIdleTime = new PerformanceCounter();
        private PerformanceCounter diskIOSplit = new PerformanceCounter();
        #endregion

        public PerfCounterHD(string maName)
        {
            this.InitPerfCountersIO(maName);
            this.InitPerfCountersQueue(maName);
            this.InitPerfCountersTime(maName);
            this.InitPerfCoutersAvg(maName);
        }

        #region Counter Initialization
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
        #endregion

        #region IO Returns
        public float DiskReads { get { return this.diskReads.NextValue(); } }
        public float DiskWrites { get { return this.diskWrites.NextValue(); } }
        public float DiskTransfers { get { return this.diskTransfers.NextValue(); } }
        public float DiskReadsB { get { return this.diskReadsB.NextValue(); } }
        public float DiskWritesB { get { return this.diskWritesB.NextValue(); } }
        public float DiskTransB { get { return this.diskTransB.NextValue(); } }
        #endregion

        #region Average IO Returns
        public float AvgDiskRead { get { return this.avgDiskRead.NextValue(); } }
        public float AvgDiskWrite { get { return this.avgDiskWrite.NextValue(); } }
        public float AvgDiskTrans { get { return this.avgDiskTrans.NextValue(); } }

        public float AvgDiskReadB { get { return this.avgDiskReadB.NextValue(); } }
        public float AvgDiskWriteB { get { return this.avgDiskWriteB.NextValue(); } }
        public float AvgDiskTransB { get { return this.avgDiskTransB.NextValue(); } }
        #endregion

        #region Queue Returns
        public float AvgDiskQueue { get { return this.avgDiskQueue.NextValue(); } }
        public float AvgDiskReadQueue { get { return this.avgDiskReadQueue.NextValue(); } }
        public float AvgDiskWriteQueue { get { return this.avgDiskWriteQueue.NextValue(); } }
        public float CurrQueueLen { get { return this.currQueueLen.NextValue(); } }
        #endregion

        #region Time Returns
        public float DiskTime { get { return this.diskTime.NextValue(); } }
        public float DiskReadTime { get { return this.diskReadTime.NextValue(); } }
        public float DiskWriteTime { get { return this.diskWriteTime.NextValue(); } }
        public float DiskIdleTime { get { return this.diskIdleTime.NextValue(); } }
        public float DiskIOSplit { get { return this.diskIOSplit.NextValue(); } }
        #endregion

        public void destroyCounters()
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

    }
}
