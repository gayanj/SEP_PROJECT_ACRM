﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace ACRM.HDisk
{
    class WMIConn
    {
        public static ConnectionOptions WMIConnOptions()
        {
            ConnectionOptions options = new ConnectionOptions();
            options.Impersonation = ImpersonationLevel.Impersonate;
            options.Authentication = AuthenticationLevel.Default;
            options.EnablePrivileges = true;
            return options;
        }

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
