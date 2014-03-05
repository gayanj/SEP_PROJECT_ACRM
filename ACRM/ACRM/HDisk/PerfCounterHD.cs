using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ACRM.HDisk
{
    class PerfCounterHD
    {
        private PerformanceCounter diskReadsPerfCounter = new PerformanceCounter();
        private PerformanceCounter diskWritesPerfCounter = new PerformanceCounter();
        private PerformanceCounter diskTransfersPerfCounter = new PerformanceCounter();
        private PerformanceCounter diskReadsBytesPerSec = new PerformanceCounter();
        private PerformanceCounter diskWritesBytesPerSec = new PerformanceCounter();
        private PerformanceCounter diskTransBytesPerSec = new PerformanceCounter();

        public PerfCounterHD()
        {
            InitPerfCounters();
            
        }
        private void InitPerfCounters()
        {
            this.diskReadsPerfCounter.CategoryName = "PhysicalDisk";
            this.diskReadsPerfCounter.CounterName = "Disk Reads/sec";
            this.diskReadsPerfCounter.InstanceName = "_Total";

            this.diskWritesPerfCounter.CategoryName = "PhysicalDisk";
            this.diskWritesPerfCounter.CounterName = "Disk Writes/sec";
            this.diskWritesPerfCounter.InstanceName = "_Total";

            this.diskTransfersPerfCounter.CategoryName = "PhysicalDisk";
            this.diskTransfersPerfCounter.CounterName = "Disk Transfers/sec";
            this.diskTransfersPerfCounter.InstanceName = "_Total";

            this.diskReadsBytesPerSec.CategoryName = "PhysicalDisk";
            this.diskReadsBytesPerSec.CounterName = "Disk Read Bytes/sec";
            this.diskReadsBytesPerSec.InstanceName = "_Total";

            this.diskWritesBytesPerSec.CategoryName = "PhysicalDisk";
            this.diskWritesBytesPerSec.CounterName = "Disk Write Bytes/sec";
            this.diskWritesBytesPerSec.InstanceName = "_Total";

            this.diskTransBytesPerSec.CategoryName = "PhysicalDisk";
            this.diskTransBytesPerSec.CounterName = "Disk Bytes/sec";
            this.diskTransBytesPerSec.InstanceName = "_Total";
        }

        public float getDiskRead()
        {
            return diskReadsPerfCounter.NextValue();
        }
        public float getDiskWrites()
        {
            return diskWritesPerfCounter.NextValue();
        }
        public float getDiskTransfer()
        {
            return diskTransfersPerfCounter.NextValue();
        }
        public float getDiskReadsBytes()
        {
            return diskReadsBytesPerSec.NextValue();
        }
        public float getDiskWritesBytes()
        {
            return diskWritesBytesPerSec.NextValue();
        }
        public float getDiskTransBytes()
        {
            return diskTransBytesPerSec.NextValue();
        }

    }
}
