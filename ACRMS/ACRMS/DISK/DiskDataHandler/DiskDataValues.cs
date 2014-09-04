namespace ACRMS.DISK.DiskDataHandler
{
    using System.Runtime.Serialization;

    [DataContract]
    public struct DiskDataValues
    {
        [DataMember]
        public string HostName { get; set; }
        [DataMember]
        public string HostIp { get; set; }
        [DataMember]
        public double DiskReads { get; set; }
        [DataMember]
        public double DiskWrites { get; set; }
        [DataMember]
        public double DiskTransfers { get; set; }
        [DataMember]
        public double DiskReadsB { get; set; }
        [DataMember]
        public double DiskWritesB { get; set; }
        [DataMember]
        public double DiskTransB { get; set; }
        [DataMember]
        public double AvgDiskRead { get; set; }
        [DataMember]
        public double AvgDiskWrite { get; set; }
        [DataMember]
        public double AvgDiskTrans { get; set; }
        [DataMember]
        public double AvgDiskReadB { get; set; }
        [DataMember]
        public double AvgDiskWriteB { get; set; }
        [DataMember]
        public double AvgDiskTransB { get; set; }
        [DataMember]
        public double AvgDiskQueue { get; set; }
        [DataMember]
        public double AvgDiskReadQueue { get; set; }
        [DataMember]
        public double AvgDiskWriteQueue { get; set; }
        [DataMember]
        public double CurrQueueLen { get; set; }
        [DataMember]
        public double DiskTime { get; set; }
        [DataMember]
        public double DiskReadTime { get; set; }
        [DataMember]
        public double DiskWriteTime { get; set; }
        [DataMember]
        public double DiskIdleTime { get; set; }
        [DataMember]
        public double DiskIoSplit { get; set; }
    }
}