using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace ACRM.HDisk
{
    /// <summary>
    /// Setup the WMI Connection Options and set the Management Scope for the WMI
    /// </summary>
    class WMIConn
    {
        /// <summary>
        /// Setup the Connection Options so that the WMI may have the neccessary access to the components needed
        /// </summary>
        public static ConnectionOptions WMIConnOptions()
        {
            ConnectionOptions options = new ConnectionOptions();
            options.Impersonation = ImpersonationLevel.Impersonate;
            options.Authentication = AuthenticationLevel.Default;
            options.EnablePrivileges = true;
            return options;
        }

        /// <summary>
        /// Set the Scope of the WMI to the current local Machine
        /// </summary>
        public static ManagementScope WMIConneScope(string machineName, ConnectionOptions options)
        {
            ManagementScope connectScope = new ManagementScope();
            connectScope.Path = new ManagementPath(@"\\" + machineName + @"\root\CIMV2");
            connectScope.Options = options;
            connectScope.Connect();
            
            return connectScope;
        }
    }
}
