namespace ACRMS.DISK.DiskDataHandler
{
    public struct DiskDataValues
    {
        public string HostName { get; set; }

        public string HostIp { get; set; }

        public double DiskReads { get; set; }

        public double DiskWrites { get; set; }

        public double DiskTransfers { get; set; }

        public double DiskReadsB { get; set; }

        public double DiskWritesB { get; set; }

        public double DiskTransB { get; set; }

        public double AvgDiskRead { get; set; }

        public double AvgDiskWrite { get; set; }

        public double AvgDiskTrans { get; set; }

        public double AvgDiskReadB { get; set; }

        public double AvgDiskWriteB { get; set; }

        public double AvgDiskTransB { get; set; }

        public double AvgDiskQueue { get; set; }

        public double AvgDiskReadQueue { get; set; }

        public double AvgDiskWriteQueue { get; set; }

        public double CurrQueueLen { get; set; }

        public double DiskTime { get; set; }

        public double DiskReadTime { get; set; }

        public double DiskWriteTime { get; set; }

        public double DiskIdleTime { get; set; }

        public double DiskIoSplit { get; set; }
    }
}