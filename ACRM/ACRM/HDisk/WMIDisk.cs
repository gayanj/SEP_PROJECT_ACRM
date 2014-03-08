using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using ACRM.HDisk;
using System.Collections;

namespace ACRM.HDisk
{
    class WMIDisk
    {
        ConnectionOptions options;
        public ManagementScope ms;

        //set Connection options and Defines the Connection Namespace for local Machine
        public WMIDisk()
        {            
            ms = new ManagementScope();
            options = WMIConn.WMIConnOptions();
            ms = WMIConn.WMIConneScope(Environment.MachineName, options);
        }

        /// <summary>
        /// Retrieve all Disk Details through WMI
        /// </summary>
        public ArrayList DiskInf(ManagementScope ms)
        {
            ArrayList diskDet = new ArrayList();
            ObjectQuery oquery = new ObjectQuery("SELECT * FROM Win32_DiskDrive");

            ManagementObjectSearcher mos = new ManagementObjectSearcher(ms, oquery);
            ManagementObjectCollection moc = mos.Get();

            foreach (ManagementObject mo in moc)
            {
                diskDet.Add(mo["Model"].ToString());
            }
            return diskDet;
        }

        /// <summary>
        /// Retrive relate disk details through WMI for given Disk Name
        /// </summary>
        public ManagementObjectSearcher phyDiskInf(string diskName)
        {
            ObjectQuery oquery = new ObjectQuery("SELECT * FROM Win32_DiskDrive WHERE Model = \"" + diskName + "\"");
            ManagementObjectSearcher mos = new ManagementObjectSearcher(ms, oquery);
            return mos;
        }
    }
}
