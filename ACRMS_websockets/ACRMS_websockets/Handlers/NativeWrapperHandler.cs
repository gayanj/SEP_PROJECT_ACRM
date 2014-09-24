using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;
using NativeWrapper.Data;
using WebSockets.Data;
using WebSockets.Types;
using WebSockets.Logging;
using System.Collections;
using RAM;
using ACRMS.DISK.DiskMonitorBundle;
using System.Data;
using ACRMS.DISK.DiskDataHandler;
using DataWareHouse;

namespace NativeWrapper.Handlers
{
    /// <summary>
    /// This Class is used to wrap the native library calls for the Parameterized thread
    /// </summary>
    class NativeWrapperHandler
    {
        #region Private Attributes
        private MEMORYSTATUSEX statusEx = new MEMORYSTATUSEX();
        private PerfCounterHD perfCountObj = new PerfCounterHD(Environment.MachineName);
        private DiskDataValues diskDataValues = new DiskDataValues();
        #endregion
        #region Event methods

        /// <summary>
        /// GetCpuUsage
        /// </summary>
        /// <param name="sender">Websocket object</param>
        public void GetRamUsage(object sender)
        {
            HandlerParameters parameter = (HandlerParameters)sender;
            try
            {
                //LogMessage("StartMonitoring Method Started.", ((NativeWebSocket)parameter.Sender));
                statusEx.setValues();
                //double data = Convert.ToDouble(MEMORYSTATUSEX.graphMemory);

                Hashtable ramUsage = new Hashtable();

                ramUsage.Add("ramUsage", statusEx);

                Dictionary<string, Hashtable> response = new Dictionary<string, Hashtable>();

                response.Add("GetRamUsage", ramUsage);

                bool successMessage = false;
                if (ramUsage.Count > 0)
                {
                    successMessage = true;
                }
                Response res = parameter.Args.RequestInfo.GenerateResponse(successMessage, response);
                ((NativeWebSocket)parameter.Sender).SendResponse(res);
            }
            catch (Exception ex)
            {
                //LogMessage(ex.Message + " Exception in ILETSNetLib.validateQuality() " + ex.StackTrace, ((NativeWebSocket)parameter.Sender));
            }
        }
        /// <summary>
        /// GetCpuUsage
        /// </summary>
        /// <param name="sender">Websocket object</param>
        public void GetCpuUsage(object sender)
        {
            HandlerParameters parameter = (HandlerParameters)sender;
            try
            {
                //LogMessage("StartMonitoring Method Started.", ((NativeWebSocket)parameter.Sender));

                int data = parameter.Instance.GetCpuUsage();

                Hashtable cpuUsage = new Hashtable();

                cpuUsage.Add("cpuUsage", data);

                Dictionary<string, Hashtable> response = new Dictionary<string, Hashtable>();

                response.Add("GetCpuUsage", cpuUsage);

                bool successMessage = false;
                if (cpuUsage.Count > 0)
                {
                    successMessage = true;
                }
                Response res = parameter.Args.RequestInfo.GenerateResponse(successMessage, response);
                ((NativeWebSocket)parameter.Sender).SendResponse(res);
            }
            catch (Exception ex)
            {
                //LogMessage(ex.Message + " Exception in ILETSNetLib.validateQuality() " + ex.StackTrace, ((NativeWebSocket)parameter.Sender));
            }
        }
        /// <summary>
        /// GetDiskUsage
        /// </summary>
        /// <param name="sender">Websocket object</param>
        public void GetDiskUsage(object sender)
        {
            HandlerParameters parameter = (HandlerParameters)sender;
            try
            {
                //LogMessage("StartMonitoring Method Started.", ((NativeWebSocket)parameter.Sender));
                diskDataValues = perfCountObj.GetValues();

                Hashtable diskUsage = new Hashtable();

                diskUsage.Add("diskUsage", diskDataValues);

                Dictionary<string, Hashtable> response = new Dictionary<string, Hashtable>();

                response.Add("GetDiskUsage", diskUsage);

                bool successMessage = false;
                if (diskUsage.Count > 0)
                {
                    successMessage = true;
                }
                Response res = parameter.Args.RequestInfo.GenerateResponse(successMessage, response);
                ((NativeWebSocket)parameter.Sender).SendResponse(res);
            }
            catch (Exception ex)
            {
                //LogMessage(ex.Message + " Exception in ILETSNetLib.validateQuality() " + ex.StackTrace, ((NativeWebSocket)parameter.Sender));
            }
        }
        /// <summary>
        /// StartMonitoring
        /// </summary>
        /// <param name="sender">Websocket object</param>
        public void StartMonitoring(object sender)
        {
            HandlerParameters parameter = (HandlerParameters)sender;
            try
            {
                //LogMessage("StartMonitoring Method Started.", ((NativeWebSocket)parameter.Sender));

                Hashtable data = parameter.Instance.ProcessMonitor();

                Dictionary<string, Hashtable> response = new Dictionary<string, Hashtable>();

                response.Add("StartMonitoring", data);

                bool successMessage = false;
                if (data.Count > 0)
                {
                    successMessage = true;
                }
                Response res = parameter.Args.RequestInfo.GenerateResponse(successMessage, response);
                ((NativeWebSocket)parameter.Sender).SendResponse(res);
            }
            catch (Exception ex)
            {
                //LogMessage(ex.Message + " Exception in ILETSNetLib.validateQuality() " + ex.StackTrace, ((NativeWebSocket)parameter.Sender));
            }
        }

        /// <summary>
        /// Method used to call if an undefined method name is sent in the request name
        /// </summary>
        /// <param name="sender">Websocket object</param>
        public void UndefinedMethodRecievedHandler(object sender)
        {
            HandlerParameters parameter = (HandlerParameters)sender;
            try
            {
                //LogMessage("UndefinedMethod Method Started.", ((NativeWebSocket)parameter.Sender));

                Response res = parameter.Args.RequestInfo.GenerateResponse(false);
                ((NativeWebSocket)parameter.Sender).SendResponse(res);
            }
            catch (Exception ex)
            {
                //LogMessage(ex.Message + " Exception in UndefinedMethodRecieved() " + ex.StackTrace, ((NativeWebSocket)parameter.Sender));               
            }
        }

        /// <summary>
        /// GetDiskUsage
        /// </summary>
        /// <param name="sender">Websocket object</param>
        public void GetCpuAlerts(object sender)
        {
            HandlerParameters parameter = (HandlerParameters)sender;
            try
            {
                //LogMessage("StartMonitoring Method Started.", ((NativeWebSocket)parameter.Sender));
                DB_Access sqldb = new DB_Access();

                DataSet alerts = sqldb.getCPUAlerts(parameter.Args.RequestInfo.Parameters["from"], parameter.Args.RequestInfo.Parameters["to"]);

                Hashtable cpuAlerts = new Hashtable();

                cpuAlerts.Add("cpuAlerts", alerts);

                Dictionary<string, Hashtable> response = new Dictionary<string, Hashtable>();

                response.Add("GetCpuAlerts", cpuAlerts);

                bool successMessage = false;
                if (cpuAlerts.Count > 0)
                {
                    successMessage = true;
                }
                Response res = parameter.Args.RequestInfo.GenerateResponse(successMessage, response);
                ((NativeWebSocket)parameter.Sender).SendResponse(res);
            }
            catch (Exception ex)
            {
                //LogMessage(ex.Message + " Exception in ILETSNetLib.validateQuality() " + ex.StackTrace, ((NativeWebSocket)parameter.Sender));
            }
        }

        #endregion

        #region Logging

        public static void LogMessage(string Message, NativeWebSocket WebSocketInstance)
        {
            FileLogger.Instance.LogMessage(Message);
            WebSocketInstance.SendLogMessage(WebSocket.LogMessageType.FatalStreamMessage.ToString(), Message, "");
        }

        #endregion
    }
}
