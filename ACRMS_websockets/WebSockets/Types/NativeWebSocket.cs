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
        /// Occurs when Get Cpu Usage method is called.
        /// </summary>
        public event MethodReceivedEventHandler GetCpuUsageMethodReceived;
        /// <summary>
        /// Occurs when Start Monitoring method is called.
        /// </summary>
        public event MethodReceivedEventHandler StartMonitoringMethodReceived;

        /// <summary>
        /// Occurs when Create method is called.
        /// </summary>
        public event MethodReceivedEventHandler CreateMethodReceived;

        /// <summary>
        /// Occurs when Check System method is called.
        /// </summary>
        public event MethodReceivedEventHandler CheckSystemMethodReceived;

        /// <summary>
        /// Occurs when Close and Upload method is called.
        /// </summary>
        public event MethodReceivedEventHandler CloseAndUploadMethodReceived;

        /// <summary>
        /// Occurs when Connect To Camera method is called.
        /// </summary>
        public event MethodReceivedEventHandler ConnectToCameraMethodReceived;

        /// <summary>
        /// Occurs when Destruct method is called.
        /// </summary>
        public event MethodReceivedEventHandler DestructMethodReceived;

        /// <summary>
        /// Occurs when Get Eye Track Location method is called.
        /// </summary>
        public event MethodReceivedEventHandler GetEyeTrackLocationMethodReceived;

        /// <summary>
        /// Occurs when Get Frame Brightness method is called.
        /// </summary>
        public event MethodReceivedEventHandler GetFrameBrightnessMethodReceived;

        /// <summary>
        /// Occurs when Get Head Position method is called.
        /// </summary>
        public event MethodReceivedEventHandler GetHeadPositionMethodReceived;

        /// <summary>
        /// Occurs when Get Upload Percentage method is called.
        /// </summary>
        public event MethodReceivedEventHandler GetUploadPercentMethodReceived;

        /// <summary>
        /// Occurs when Is Camera Good Enough method is called.
        /// </summary>
        public event MethodReceivedEventHandler IsCameraGoodEnoughMethodReceived;

        /// <summary>
        /// Occurs when Show Calibration Dialog method is called.
        /// </summary>
        public event MethodReceivedEventHandler ShowCalibrationDialogMethodReceived;

        /// <summary>
        /// Occurs when Show Head Validation method is called.
        /// </summary>
        public event MethodReceivedEventHandler ShowHeadValidationDialogMethodReceived;

        /// <summary>
        /// Occurs when Start Recording method is called.
        /// </summary>
        public event MethodReceivedEventHandler StartRecordingMethodReceived;

        /// <summary>
        /// Occurs when Stop Recording method is called.
        /// </summary>
        public event MethodReceivedEventHandler StopRecordingMethodReceived;

        /// <summary>
        /// Occurs when Validate Quality method is called.
        /// </summary>
        public event MethodReceivedEventHandler ValidateQualityMethodReceived;

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
                case "checkSystem":
                    FileLogger.Instance.LogMessage("checkSystem Method Recieved.");
                    if (CheckSystemMethodReceived != null)
                        CheckSystemMethodReceived(this, args);
                    return true;
                case "create":
                    FileLogger.Instance.LogMessage("create Method Recieved.");
                    if (CreateMethodReceived != null)
                        CreateMethodReceived(this, args);
                    return true;
                case "validateQuality":
                    FileLogger.Instance.LogMessage("validateQuality Method Recieved.");
                    if (ValidateQualityMethodReceived != null)
                        ValidateQualityMethodReceived(this, args);
                    return true;
                case "showCalibrationDialog":
                    FileLogger.Instance.LogMessage("showCalibrationDialog Method Recieved.");
                    if (ShowCalibrationDialogMethodReceived != null)
                        ShowCalibrationDialogMethodReceived(this, args);
                    return true;
                case "showHeadValidationDialog":
                    FileLogger.Instance.LogMessage("showHeadValidationDialog Method Recieved.");
                    if (ShowHeadValidationDialogMethodReceived != null)
                        ShowHeadValidationDialogMethodReceived(this, args);
                    return true;
                case "startRecording":
                    FileLogger.Instance.LogMessage("startRecording Method Recieved.");
                    if (StartRecordingMethodReceived != null)
                        StartRecordingMethodReceived(this, args);
                    return true;
                case "stopRecording":
                    FileLogger.Instance.LogMessage("stopRecording Method Recieved.");
                    if (StopRecordingMethodReceived != null)
                        StopRecordingMethodReceived(this, args);
                    return true;
                case "closeAndUpload":
                    FileLogger.Instance.LogMessage("closeAndUpload Method Recieved.");
                    if (CloseAndUploadMethodReceived != null)
                        CloseAndUploadMethodReceived(this, args);
                    return true;
                case "getUploadPercent":
                    FileLogger.Instance.LogMessage("getUploadPercent Method Recieved.");
                    if (GetUploadPercentMethodReceived != null)
                        GetUploadPercentMethodReceived(this, args);
                    return true;
                case "destruct":
                    FileLogger.Instance.LogMessage("destruct Method Recieved.");
                    if (DestructMethodReceived != null)
                        DestructMethodReceived(this, args);
                    return true;
                case "closeSession":
                    FileLogger.Instance.LogMessage("closeSession Method Recieved.");
                    if (ClosingMethodReceived != null)
                        ClosingMethodReceived(this, args);
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
