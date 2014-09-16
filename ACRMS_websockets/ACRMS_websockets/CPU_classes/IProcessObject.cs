using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ACRMS.CPU
{
    interface IProcessObject
    {
        ArrayList RunningProcesses();
        int GetCpuUsage();
        Hashtable ProcessMonitor();
        string CreateProcess(string processPath);
        void TerminateProcess(string processName);
        void SetPriority(string processName, ProcessPriority.priority priority);
        string GetProcessOwner(string processName);
        string GetProcessOwnerSID(string processName);
    }
}
