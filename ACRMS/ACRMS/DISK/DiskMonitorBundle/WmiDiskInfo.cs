namespace ACRMS.DISK.DiskDataHandler
{
    using System.Collections;
    using System.Management;

    public class WmiDiskInfo
    {
        private ManagementScope managementScope;
        private ConnectionOptions connectionOptions;

        public WmiDiskInfo()
        {
            this.connectionOptions = new ConnectionOptions
                                    {
                                        Impersonation = ImpersonationLevel.Impersonate,
                                        Authentication = AuthenticationLevel.Default,
                                        EnablePrivileges = true
                                    };
        }

        public ArrayList GetDiskModelList(string hostName)
        {
            this.managementScope = new ManagementScope
                                       {
                                           Path = new ManagementPath(@"\\" + hostName + @"\root\CIMV2"),
                                           Options = this.connectionOptions
                                       };
            this.managementScope.Connect();
            ArrayList diskModelList = new ArrayList();
            ObjectQuery objectQuery = new ObjectQuery("SELECT * FROM Win32_DiskDrive");
            ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(
                this.managementScope,
                objectQuery);
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            foreach (var o in managementObjectCollection)
            {
                var managementObject = (ManagementObject)o;
                diskModelList.Add(managementObject["Model"].ToString());
            }

            return diskModelList;
        }

        public DiskProperties GetDiskProperties(string diskName)
        {
            DiskProperties diskProperties = new DiskProperties();
            ObjectQuery oquery = new ObjectQuery("SELECT * FROM Win32_DiskDrive WHERE Model = \"" + diskName + "\"");
            ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(this.managementScope, oquery);
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            foreach (var o in managementObjectCollection)
            {
                var managementObject = (ManagementObject)o;
                diskProperties.Model = managementObject["Model"].ToString();

                //diskProperties.BytesPerSector = managementObject["BytesPerSector"].ToString();
                //diskProperties.FirmwareRevision = managementObject["FirmwareRevision"].ToString();
                //diskProperties.InterfaceType = managementObject["InterfaceType"].ToString();
                //diskProperties.MaxBlockSize = managementObject["MaxBlockSize"].ToString();
                //diskProperties.MinBlockSize = managementObject["MinBlockSize"].ToString();
                //diskProperties.NoOfPartitions = managementObject["Partitions"].ToString();
                //diskProperties.SectorsPerTrack = managementObject["SectorsPerTrack"].ToString();
                diskProperties.SerialNumber = managementObject["SerialNumber"].ToString();

                //diskProperties.Size = managementObject["Capacity"].ToString();
                diskProperties.TotalCylinders = managementObject["TotalCylinders"].ToString();

                //diskProperties.TotalHeads = managementObject["TotalHeads"].ToString();
                //diskProperties.TotalSectors = managementObject["TotalSectors"].ToString();
                //diskProperties.TotalTracks = managementObject["TotalTracks"].ToString();
                //diskProperties.TracksPerCylinser = managementObject["TracksPerCylinder"].ToString();
            }

            return diskProperties;
        }
    }
}