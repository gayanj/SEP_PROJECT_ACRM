﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace ACRMS.CPU
{
    class ProcessConnection
    {
        public static ConnectionOptions ProcessConnectionOptions()
        {
            ConnectionOptions options = new ConnectionOptions();
            options.Impersonation = ImpersonationLevel.Impersonate;
            options.Authentication = AuthenticationLevel.Default;
            options.EnablePrivileges = true;
            return options;
        }

        public static ManagementScope ConnectionScope(string machineName,
                                                      ConnectionOptions options)
        {
            ManagementScope connectScope = new ManagementScope();
            connectScope.Path = new ManagementPath(@"\\" + machineName + @"\root\CIMV2");
            connectScope.Options = options;

            try
            {
                connectScope.Connect();
            }
            catch (ManagementException e)
            {
                Console.WriteLine("An Error Occurred: " + e.Message.ToString());
            }
            return connectScope;
        }
    }
}
