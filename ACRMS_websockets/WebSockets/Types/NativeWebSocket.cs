using System;
using WebSockets.Data;
using WebSockets.Events;
using WebSockets.Logging;
using System.Collections.Generic;
using SuperSocket.WebSocket;

namespace WebSockets.Types
{
    public class NativeWebSocket : WebSocket
    {
        #region Private Variables

        private bool wsCheckComplete;

        #endregion

        #region Events

        /// <summary>
        /// Occurs when Get Disk Usage method is called.
        /// </summary>
        public event MethodReceivedEventHandler GetCpuAlertsMethodReceived;
        /// <summary>
        /// Occurs when Get Disk Usage method is called.
        /// </summary>
        public event MethodReceivedEventHandler GetDiskUsageMethodReceived;
        /// <summary>
        /// Occurs when Get Ram Usage method is called.
        /// </summary>
        public event MethodReceivedEventHandler GetRamUsageMethodReceived;
        /// <summary>
        /// Occurs when Get Cpu Usage method is called.
        /// </summary>
        public event MethodReceivedEventHandler GetCpuUsageMethodReceived;
        /// <summary>
        /// Occurs when Start Monitoring method is called.
        /// </summary>
        public event MethodReceivedEventHandler StartMonitoringMethodReceived;

        /// <summary>
        /// Occurs when an Undefined method is called.
        /// </summary>
        public event MethodReceivedEventHandler UndefinedMethodReceived;

        /// <summary>
        /// Occurs when Browser is closing.
        /// </summary>
        public event MethodReceivedEventHandler ClosingMethodReceived;

        #endregion

        #region Public Methods

        /// <summary>
        /// Initialize Web Socket with a Designated Port Number.
        /// </summary>
        /// <param name="PortNumber">Port Number which the web socket should use.</param>
        public NativeWebSocket(int port)
            : base(port)
        {
            FileLogger.Instance.LogMessage("Initializing Native Web Socket. Port=" + port);
            wsCheckComplete = false;
        }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Handle a message recieved to the socket.
        /// </summary>
        /// <param name="session">Web Socket Session information.</param>
        /// <param name="value">Value recieved.</param>
        /// <returns>True if the method was handled properly.</returns>
        protected override bool HandleNewMessage(WebSocketSession session, string value)
        {
            if (base.HandleNewMessage(session, value))
                return true;

            Request request = JSONDataHandler.ToRequest(value);
            MethodReceivedEventArgs args = new MethodReceivedEventArgs(request);

            switch (request.MethodName)
            {
                case "getCpuAlerts":
                    FileLogger.Instance.LogMessage("getCpuAlerts Method Recieved.");
                    if (GetCpuAlertsMethodReceived != null)
                        GetCpuAlertsMethodReceived(this, args);
                    return true;
                case "getDISKUsage":
                    FileLogger.Instance.LogMessage("getDISKUsage Method Recieved.");
                    if (GetDiskUsageMethodReceived != null)
                        GetDiskUsageMethodReceived(this, args);
                    return true;
                case "getRAMUsage":
                    FileLogger.Instance.LogMessage("getRAMUsage Method Recieved.");
                    if (GetRamUsageMethodReceived != null)
                        GetRamUsageMethodReceived(this, args);
                    return true;
                case "getCPUUsage":
                    FileLogger.Instance.LogMessage("getCPUUsage Method Recieved.");
                    if (GetCpuUsageMethodReceived != null)
                        GetCpuUsageMethodReceived(this, args);
                    return true;
                case "startMonitoring":
                    FileLogger.Instance.LogMessage("startMonitoring Method Recieved.");
                    if (StartMonitoringMethodReceived != null)
                        StartMonitoringMethodReceived(this, args);
                    return true;
                default:
                    FileLogger.Instance.LogMessage("Undefined Method Recieved.");
                    if (UndefinedMethodReceived != null)
                        UndefinedMethodReceived(this, args);
                    return false;
            }
        }

        protected override void AppServerSessionClosed(WebSocketSession session, SuperSocket.SocketBase.CloseReason value)
        {
            FileLogger.Instance.LogMessage("Client Disconnected. IP " + session.RemoteEndPoint.Address + " Port " + session.RemoteEndPoint.Port.ToString());
            FileLogger.Instance.LogMessage("Reason " + value);
            FileLogger.Instance.LogMessage("Web Socket Check Status " + wsCheckComplete);

            if (wsCheckComplete)
            {
                if (ClosingMethodReceived != null)
                    ClosingMethodReceived(this, MethodReceivedEventArgs.Empty);
            }

            // The first connection to the socket will be always from the Launcher.
            // Therefore we should not close the native wrapper aftert the first connection. For subsequent connections,
            // the native wrapper will be closed when the connection is closed.            
            wsCheckComplete = true;
        }

        #endregion
    }
}
