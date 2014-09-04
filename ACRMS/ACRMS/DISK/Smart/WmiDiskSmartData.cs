namespace ACRMS.DISK.Smart
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Management;

    class WmiDiskSmartData
    {
        private ManagementScope managementScope;
        private ConnectionOptions connectionOptions;
        private DataTable smarDataTable;

        public WmiDiskSmartData()
        {
            this.connectionOptions = new ConnectionOptions
            {
                Impersonation = ImpersonationLevel.Impersonate,
                Authentication = AuthenticationLevel.Default,
                EnablePrivileges = true
            };
            smarDataTable = new DataTable();
            smarDataTable.Columns.Add("Type");
            smarDataTable.Columns.Add("Value");
            smarDataTable.Columns.Add("Advisory");
            smarDataTable.Columns.Add("Failure Eminent");
            smarDataTable.Columns.Add("Flag 1");
            smarDataTable.Columns.Add("Flag 2");
            smarDataTable.Columns.Add("Flag 3");
            smarDataTable.Columns.Add("Flag 4");
            smarDataTable.Columns.Add("Flag 5");
            smarDataTable.Columns.Add("Flag 6");
            smarDataTable.Columns.Add("Flag 7");
            smarDataTable.Columns.Add("Flag 8");
        }

        public DataTable GetSmartData(string hostName)
        {
            this.managementScope = new ManagementScope
                                    {
                                        Path = new ManagementPath(@"\\" + hostName + @"\root\WMI"),
                                        Options = this.connectionOptions
                                    };

            this.managementScope.Connect();
            ObjectQuery objectQuery = new ObjectQuery(@"SELECT * FROM MSStorageDriver_ATAPISmartData");
            ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(
                this.managementScope,
                objectQuery);
            ManagementObjectCollection managementObjects = managementObjectSearcher.Get();

            foreach (var queryObj in managementObjects)
            {
                var arrVendorSpecific = (byte[])queryObj.GetPropertyValue("VendorSpecific");

                // Create SMART data from 'vendor specific' array
                var d = new SmartData(arrVendorSpecific);
                foreach (var b in d.Attributes)
                {
                    string advisory = b.Advisory.ToString();
                    string isEminent = b.FailureImminent.ToString();
                    List<object> valueList = new List<object>();
                    valueList.Add(b.AttributeType);
                    valueList.Add(b.Value);
                    valueList.Add(advisory);
                    valueList.Add(isEminent);
                    foreach (byte vendorByte in b.VendorData)
                    {
                        valueList.Add(vendorByte.ToString());
                    }
                    smarDataTable.Rows.Add(valueList.ToArray());
                }
                smarDataTable.Rows.Add(
                        " ",
                        " ",
                        " ",
                        " ",
                        " ",
                        " ",
                        " ",
                        " ",
                        " ",
                        " ",
                        " ",
                        " ");
            }

            return this.smarDataTable;
        }

    }
}
