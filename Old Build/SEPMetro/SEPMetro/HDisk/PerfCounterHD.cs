using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ACRM.HDisk
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
            InitPerfCountersIO(maName);
            InitPerfCountersQueue(maName);
            InitPerfCountersTime(maName);
            InitPerfCoutersAvg(maName);
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
        public float DiskReads { get { return diskReads.NextValue(); } }
        public float DiskWrites { get { return diskWrites.NextValue(); } }
        public float DiskTransfers { get { return diskTransfers.NextValue(); } }
        public float DiskReadsB { get { return diskReadsB.NextValue(); } }
        public float DiskWritesB { get { return diskWritesB.NextValue(); } }
        public float DiskTransB { get { return diskTransB.NextValue(); } }
        #endregion

        #region Average IO Returns
        public float AvgDiskRead { get { return avgDiskRead.NextValue(); } }
        public float AvgDiskWrite { get { return avgDiskWrite.NextValue(); } }
        public float AvgDiskTrans { get { return avgDiskTrans.NextValue(); } }

        public float AvgDiskReadB { get { return avgDiskReadB.NextValue(); } }
        public float AvgDiskWriteB { get { return avgDiskWriteB.NextValue(); } }
        public float AvgDiskTransB { get { return avgDiskTransB.NextValue(); } }
        #endregion

        #region Queue Returns
        public float AvgDiskQueue { get { return avgDiskQueue.NextValue(); } }
        public float AvgDiskReadQueue { get { return avgDiskReadQueue.NextValue(); } }
        public float AvgDiskWriteQueue { get { return avgDiskWriteQueue.NextValue(); } }
        public float CurrQueueLen { get { return currQueueLen.NextValue(); } }
        #endregion

        #region Time Returns
        public float DiskTime { get { return diskTime.NextValue(); } }
        public float DiskReadTime { get { return diskReadTime.NextValue(); } }
        public float DiskWriteTime { get { return diskWriteTime.NextValue(); } }
        public float DiskIdleTime { get { return diskIdleTime.NextValue(); } }
        public float DiskIOSplit { get { return diskIOSplit.NextValue(); } }
        #endregion

        public void destroyCounters()
        {
            diskTime.Dispose();
            diskReadTime.Dispose();
            diskWriteTime.Dispose();
            diskIdleTime.Dispose();
            diskIOSplit.Dispose();

            avgDiskQueue.Dispose();
            avgDiskReadQueue.Dispose();
            avgDiskWriteQueue.Dispose();
            currQueueLen.Dispose();

            avgDiskRead.Dispose();
            avgDiskWrite.Dispose();
            avgDiskTrans.Dispose();

            avgDiskReadB.Dispose();
            avgDiskWriteB.Dispose();
            avgDiskTransB.Dispose();

            diskReadsB.Dispose();
            diskWritesB.Dispose();
            diskTransB.Dispose();

            diskReads.Dispose();
            diskTransfers.Dispose();
            diskWrites.Dispose();
        }

    }
}
