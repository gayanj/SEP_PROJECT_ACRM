namespace ACRMS.DISK.DiskMonitorBundle
{
    public struct DiskProperties
    {
        public string BytesPerSector { get; set; }
        public string FirmwareRevision { get; set; }
        public string InterfaceType { get; set; }
        public string MaxBlockSize { get; set; }
        public string MinBlockSize { get; set; }
        public string Model { get; set; }
        public string NoOfPartitions { get; set; }
        public string SectorsPerTrack { get; set; }
        public string SerialNumber { get; set; }
        public string Size { get; set; }
        public string TotalCylinders { get; set; }
        public string TotalHeads { get; set; }
        public string TotalSectors { get; set; }
        public string TotalTracks { get; set; }
        public string TracksPerCylinser { get; set; }
    }
}