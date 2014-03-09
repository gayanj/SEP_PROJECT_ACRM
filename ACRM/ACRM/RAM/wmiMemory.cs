using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace RAM
{
    public class wmiMemory
    {
        ManagementScope scope = new ManagementScope("\\\\.\\ROOT\\CIMV2");
        ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_PhysicalMemory");
        public string[] info;
        public wmiMemory()
        {
            ManagementObjectSearcher search = new ManagementObjectSearcher(scope, query);
            ManagementObjectCollection queryCollection = search.Get();

            foreach (ManagementObject m in queryCollection)
            {
                info=new string[30];
                for (int i = 0; i < 30; i++)
                     info[i] = "Not available";
                    try
                    {
                       

                        info[1] = m["BankLabel"].ToString();
                        info[2] = m["Capacity"].ToString();
                        info[3] = m["Caption"].ToString();
                        info[4] = m["Manufacturer"].ToString();
                        info[5] = m["DataWidth"].ToString();
                        info[6] = m["SerialNumber"].ToString();
                        info[7] = m["Speed"].ToString();
                        info[8] = m["InterleaveDataDepth"].ToString();
                        info[9] = m["Version"].ToString();
                        info[10] = m["InstallDate"].ToString();
                        info[11] = m["Status"].ToString();
                        info[12] = m["InterleavePosition"].ToString();
                        info[13] = m["MemoryType"].ToString();
                        info[14] = m["DeviceLocator"].ToString();
                        info[15] = m["OtherIdentifyingInfo"].ToString();
                        info[16] = m["FormFactor"].ToString();
                        
                        info[17] = m["Tag"].ToString();
                        info[18] = m["PartNumber"].ToString();
                        info[19] = m["PositionInRow"].ToString();
                        info[20] = m["CreationClassName"].ToString();
                        info[21] = m["Removable"].ToString();
                        info[22] = m["Replaceable"].ToString();
                        info[23] = m["Name"].ToString();
                        info[24] = m["SKU"].ToString();
                        info[25] = m["HotSwappable"].ToString();
                        info[26] = m["Model"].ToString();
                        info[27] = m["Description"].ToString();
                        info[28] = m["TotalWidth"].ToString();
                        info[29] = m["TypeDetail"].ToString();
                        info[30] = m["PoweredOn"].ToString();
                    }
                    catch (NullReferenceException)
                    {

                    }
            }
        }

    }
}
