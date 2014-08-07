using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management;
using System.Text;

namespace ACRM.CPU
{
    class ProcessLocal : IProcessObject
    {
        #region "fields"
        ConnectionOptions options;
        ManagementScope connectionScope;
        #endregion

        #region "constructors"
        public ProcessLocal()
        {
            options = ProcessConnection.ProcessConnectionOptions();
            connectionScope = ProcessConnection.ConnectionScope(
                                     Environment.MachineName, options);
        }
        #endregion

        #region "polymorphic methods"
        public ArrayList RunningProcesses()
        {
            ArrayList alProcesses = new ArrayList();
            alProcesses = ProcessMethod.RunningProcesses(connectionScope);
            return alProcesses;
        }
        /// <summary>
        /// This method calls the SystemMonitor method in the ProcessMethod class and returns a data table with the process information
        /// </summary>
        /// <returns>Datatable</returns>
        public DataTable ProcessMonitor()
        {
            DataTable alProperties = new DataTable();
            alProperties = ProcessMethod.SystemMonitor(connectionScope);
            return alProperties;
        }

        public String returnUsageForProcess(int pid)
        {
            return ProcessMethod.getUsageForProcess(pid, connectionScope);
        }
        public string CreateProcess(string processPath)
        {
            return ProcessMethod.StartProcess(Environment.MachineName, processPath);
        }
        public void TerminateProcess(string processName)
        {
            ProcessMethod.KillProcess(connectionScope, processName);
        }
        public void SetPriority(string processName, ProcessPriority.priority priority)
        {
            ProcessMethod.ChangePriority(connectionScope, processName, priority);
        }
        public string GetProcessOwner(string processName)
        {
            return ProcessMethod.ProcessOwner(connectionScope, processName);
        }
        public string GetProcessOwnerSID(string processName)
        {
            return ProcessMethod.ProcessOwnerSID(connectionScope, processName);
        }
        #endregion
    }
}
