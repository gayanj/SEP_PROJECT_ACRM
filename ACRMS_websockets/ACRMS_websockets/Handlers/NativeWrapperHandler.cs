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

namespace NativeWrapper.Handlers
{
    /// <summary>
    /// This Class is used to wrap the native library calls for the Parameterized thread
    /// </summary>
    class NativeWrapperHandler
    {
        #region Event methods

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

        ///// <summary>
        ///// Calls the native validateQuality() method and sends back the response via the Wbsocket
        ///// </summary>
        ///// <param name="sender">Websocket object</param>
        //public void ValidateQualityMethodRecievedHandler(object sender)
        //{
        //    HandlerParameters parameter = (HandlerParameters)sender;
        //    try
        //    {
        //        LogMessage("ValidateQuality Method Started.", ((NativeWebSocket)parameter.Sender));

        //        string successMessage = parameter.Instance.validateQuality();

        //        Dictionary<string, string> response = new Dictionary<string, string>();
        //        response.Add("ValidateQuality", successMessage);

        //        Response res = parameter.Args.RequestInfo.GenerateResponse(successMessage.ToLower().Equals("good"), response);
        //        ((NativeWebSocket)parameter.Sender).SendResponse(res);
        //    }
        //    catch (Exception ex)
        //    {
        //        LogMessage(ex.Message + " Exception in ILETSNetLib.validateQuality() " + ex.StackTrace, ((NativeWebSocket)parameter.Sender));
        //    }
        //}

        ///// <summary>
        ///// Calls the native isCameraGoodEnough() method and sends back the response via the Wbsocket
        ///// </summary>
        ///// <param name="sender">Websocket object</param>
        //public void IsCameraGoodEnoughMethodRecievedHandler(object sender)
        //{
        //    HandlerParameters parameter = (HandlerParameters)sender;
        //    try
        //    {
        //        LogMessage("IsCameraGoodEnough Method Started.", ((NativeWebSocket)parameter.Sender));

        //        bool successMessage = parameter.Instance.isCameraGoodEnough();

        //        Response res = parameter.Args.RequestInfo.GenerateResponse(successMessage);
        //        ((NativeWebSocket)parameter.Sender).SendResponse(res);
        //    }
        //    catch (Exception ex)
        //    {
        //        LogMessage(ex.Message + " Exception in ILETSNetLib.isCameraGoodEnough() " + ex.StackTrace, ((NativeWebSocket)parameter.Sender));
        //    }
        //}

        ///// <summary>
        ///// Calls the native getHeadPosition() method and sends back the response via the Wbsocket
        ///// </summary>
        ///// <param name="sender">Websocket object</param>
        //public void GetHeadPositionMethodRecievedHandler(object sender)
        //{
        //    HandlerParameters parameter = (HandlerParameters)sender;
        //    try
        //    {
        //        LogMessage("GetHeadPosition Method Started.", ((NativeWebSocket)parameter.Sender));

        //        string successMessage = parameter.Instance.getHeadPosition();

        //        Dictionary<string, string> response = new Dictionary<string, string>();
        //        response.Add("GetHeadPositionMethod", successMessage.ToString());

        //        Response res = parameter.Args.RequestInfo.GenerateResponse(successMessage.ToLower().Equals("good"), response);
        //        ((NativeWebSocket)parameter.Sender).SendResponse(res);
        //    }
        //    catch (Exception ex)
        //    {
        //        LogMessage(ex.Message + " Exception in ILETSNetLib.getHeadPosition() " + ex.StackTrace, ((NativeWebSocket)parameter.Sender));
        //    }
        //}

        ///// <summary>
        ///// Calls the native getUploadPercent() method and sends back the response via the Wbsocket
        ///// </summary>
        ///// <param name="sender">Websocket object</param>
        //public void GetUploadPercentMethodRecievedHandler(object sender)
        //{
        //    HandlerParameters parameter = (HandlerParameters)sender;
        //    try
        //    {
        //        LogMessage("GetUploadPercent Method Started.", ((NativeWebSocket)parameter.Sender));

        //        int successMessage = parameter.Instance.getUploadPercent();

        //        Dictionary<string, string> response = new Dictionary<string, string>();
        //        response.Add("UploadPercentage", successMessage.ToString());

        //        Response res = parameter.Args.RequestInfo.GenerateResponse(true, response);
        //        ((NativeWebSocket)parameter.Sender).SendResponse(res);
        //    }
        //    catch (Exception ex)
        //    {
        //        LogMessage(ex.Message + " Exception in ILETSNetLib.getUploadPercent() " + ex.StackTrace, ((NativeWebSocket)parameter.Sender));
        //    }
        //}

        ///// <summary>
        ///// Calls the native closeAndUpload() method and sends back the response via the Wbsocket
        ///// </summary>
        ///// <param name="sender">Websocket object</param>
        //public void CloseAndUploadMethodRecievedHandler(object sender)
        //{
        //    HandlerParameters parameter = (HandlerParameters)sender;
        //    try
        //    {
        //        LogMessage("CloseAndUpload Method Started.", ((NativeWebSocket)parameter.Sender));

        //        bool successMessage = parameter.Instance.closeAndUpload();

        //        Response res = parameter.Args.RequestInfo.GenerateResponse(successMessage);
        //        ((NativeWebSocket)parameter.Sender).SendResponse(res);
        //    }
        //    catch (Exception ex)
        //    {
        //        LogMessage(ex.Message + " Exception in ILETSNetLib.getUploadPercent() " + ex.StackTrace, ((NativeWebSocket)parameter.Sender));
        //    }
        //}

        ///// <summary>
        ///// Calls the native stopRecording() method and sends back the response via the Wbsocket
        ///// </summary>
        ///// <param name="sender">Websocket object</param>
        //public void StopRecordingMethodRecievedHandler(object sender)
        //{
        //    HandlerParameters parameter = (HandlerParameters)sender;
        //    try
        //    {
        //        LogMessage("StopRecording Method Started.", ((NativeWebSocket)parameter.Sender));

        //        bool successMessage = parameter.Instance.stopRecording();

        //        Response res = parameter.Args.RequestInfo.GenerateResponse(successMessage);
        //        ((NativeWebSocket)parameter.Sender).SendResponse(res);
        //    }
        //    catch (Exception ex)
        //    {
        //        LogMessage(ex.Message + " Exception in ILETSNetLib.stopRecording() " + ex.StackTrace, ((NativeWebSocket)parameter.Sender));
        //    }
        //}

        ///// <summary>
        ///// Calls the native startRecording() method and sends back the response via the Wbsocket
        ///// </summary>
        ///// <param name="sender">Websocket object</param>
        //public void StartRecordingMethodRecievedHandler(object sender)
        //{
        //    HandlerParameters parameter = (HandlerParameters)sender;
        //    try
        //    {
        //        LogMessage("StartRecording Method Started.", ((NativeWebSocket)parameter.Sender));

        //        bool successMessage = parameter.Instance.startRecording();

        //        Response res = parameter.Args.RequestInfo.GenerateResponse(successMessage);
        //        ((NativeWebSocket)parameter.Sender).SendResponse(res);
        //    }
        //    catch (Exception ex)
        //    {
        //        LogMessage(ex.Message + " Exception in ILETSNetLib.startRecording() " + ex.StackTrace, ((NativeWebSocket)parameter.Sender));
        //    }
        //}

        ///// <summary>
        ///// Calls the native showHeadValidationDialog() method and sends back the response via the Wbsocket
        ///// </summary>
        ///// <param name="sender">Websocket object</param>
        //public void ShowHeadValidationDialogMethodRecievedHandler(object sender)
        //{
        //    HandlerParameters parameter = (HandlerParameters)sender;
        //    try
        //    {
        //        int browserX = 0;
        //        int browserY = 0;

        //        if (parameter.Args.RequestInfo.Parameters.ContainsKey(Config.BrowserX))
        //            browserX = int.Parse(parameter.Args.RequestInfo.Parameters[Config.BrowserX]);

        //        if (parameter.Args.RequestInfo.Parameters.ContainsKey(Config.BrowserY))
        //            browserY = int.Parse(parameter.Args.RequestInfo.Parameters[Config.BrowserY]);

        //        LogMessage("ShowHeadValidationDialog Method Started. Parameters, BrowserX:" + browserX 
        //            + " BrowserY:" + browserY, ((NativeWebSocket)parameter.Sender));

        //        bool successMessage = parameter.Instance.showHeadValidationDialog(browserX, browserY);

        //        Response res = parameter.Args.RequestInfo.GenerateResponse(successMessage);
        //        ((NativeWebSocket)parameter.Sender).SendResponse(res);
        //    }
        //    catch (Exception ex)
        //    {
        //        LogMessage(ex.Message + " Exception in ILETSNetLib.showHeadValidationDialog() " + ex.StackTrace, ((NativeWebSocket)parameter.Sender));
        //    }
        //}

        ///// <summary>
        ///// Calls the native create() method and sends back the response via the Wbsocket
        ///// </summary>
        ///// <param name="sender">Websocket object</param>
        //public void CreateMethodRecievedHandler(object sender)
        //{
        //    HandlerParameters parameter = (HandlerParameters)sender;
        //    try
        //    {
        //        string createArgs = string.Empty;
        //        string baseURL = string.Empty;
        //        int browserX = 0;
        //        int browserY = 0;

        //        if (parameter.Args.RequestInfo.Parameters.ContainsKey(Config.JSONSetupString))
        //            createArgs = parameter.Args.RequestInfo.Parameters[Config.JSONSetupString].ToString();

        //        if (parameter.Args.RequestInfo.Parameters.ContainsKey(Config.BaseURL))
        //            baseURL = parameter.Args.RequestInfo.Parameters[Config.BaseURL].ToString();

        //        if (parameter.Args.RequestInfo.Parameters.ContainsKey(Config.BrowserX))
        //            browserX = int.Parse(parameter.Args.RequestInfo.Parameters[Config.BrowserX]);

        //        if (parameter.Args.RequestInfo.Parameters.ContainsKey(Config.BrowserY))
        //            browserY = int.Parse(parameter.Args.RequestInfo.Parameters[Config.BrowserY]);

        //        LogMessage("Create Method Started. Parameters, JSONSetupString:" + createArgs
        //            + " BaseURL:" + baseURL + " BrowserX:" + browserX + " BrowserY:" + browserY, 
        //            ((NativeWebSocket)parameter.Sender));

        //        string successMessage = parameter.Instance.create(createArgs, baseURL, browserX, browserY);

        //        Dictionary<string, string> response = new Dictionary<string, string>();
        //        response.Add("Create", successMessage);

        //        Response res = parameter.Args.RequestInfo.GenerateResponse(successMessage.ToLower().Equals("good"), response);
        //        ((NativeWebSocket)parameter.Sender).SendResponse(res);
        //    }
        //    catch (Exception ex)
        //    {
        //        LogMessage(ex.Message + " Exception in ILETSNetLib.create() " + ex.StackTrace, ((NativeWebSocket)parameter.Sender));
        //    }
        //}

        ///// <summary>
        ///// Calls the native destruct() method and sends back the response via the Wbsocket
        ///// </summary>
        ///// <param name="sender">Websocket object</param>
        //public void DestructMethodRecievedHandler(object sender)
        //{
        //    HandlerParameters parameter = (HandlerParameters)sender;
        //    try
        //    {
        //        LogMessage("Destruct Method Started.", ((NativeWebSocket)parameter.Sender));

        //        bool successMessage = parameter.Instance.destruct();

        //        Response res = parameter.Args.RequestInfo.GenerateResponse(successMessage);
        //        ((NativeWebSocket)parameter.Sender).SendResponse(res);

        //        System.Threading.Thread.Sleep(1000); // Small wait for the message to go through

        //        Environment.Exit(0);
        //    }
        //    catch (Exception ex)
        //    {
        //        LogMessage(ex.Message + " Exception in ILETSNetLib.destruct() " + ex.StackTrace, ((NativeWebSocket)parameter.Sender));
        //    }
        //}

        ///// <summary>
        ///// Calls the native showCalibrationDialog() method and sends back the response via the Wbsocket
        ///// </summary>
        ///// <param name="sender">Websocket object</param>
        //public void ShowCalibrationDialogMethodRecievedHandler(object sender)
        //{
        //    HandlerParameters parameter = (HandlerParameters)sender;
        //    try
        //    {                
        //        string CSVName = string.Empty;
        //        int browserX = 0;
        //        int browserY = 0;

        //        if (parameter.Args.RequestInfo.Parameters.ContainsKey(Config.Type))
        //            CSVName = parameter.Args.RequestInfo.Parameters[Config.Type].ToString();

        //        if (parameter.Args.RequestInfo.Parameters.ContainsKey(Config.BrowserX))
        //            browserX = int.Parse(parameter.Args.RequestInfo.Parameters[Config.BrowserX]);

        //        if (parameter.Args.RequestInfo.Parameters.ContainsKey(Config.BrowserY))
        //            browserY = int.Parse(parameter.Args.RequestInfo.Parameters[Config.BrowserY]);

        //        LogMessage("ShowCalibrationDialog Method Started. Parameters, CSVName:" + CSVName +
        //            " BrowserX:" + browserX + " BrowserY:" + browserY, ((NativeWebSocket)parameter.Sender));

        //        bool successMessage = parameter.Instance.showCalibrationDialog(CSVName, browserX, browserY);

        //        Response res = parameter.Args.RequestInfo.GenerateResponse(successMessage);
        //        ((NativeWebSocket)parameter.Sender).SendResponse(res);
        //    }
        //    catch (Exception ex)
        //    {
        //        LogMessage(ex.Message + " Exception in ILETSNetLib.showCalibrationDialog() " + ex.StackTrace, ((NativeWebSocket)parameter.Sender));
        //    }
        //}

        ///// <summary>
        ///// Calls the native checkSystem() method and sends back the response via the Wbsocket
        ///// </summary>
        ///// <param name="sender">Websocket object</param>
        //public void CheckSystemHandler(object sender)
        //{
        //    HandlerParameters parameter = (HandlerParameters)sender;
        //    try
        //    {
        //        LogMessage("CheckSystem Method Started.", ((NativeWebSocket)parameter.Sender));
        //        string successMessage = parameter.Instance.checkSystem();

        //        Dictionary<string, string> response = new Dictionary<string, string>();
        //        response.Add("CheckSystem", successMessage);

        //        Response res = parameter.Args.RequestInfo.GenerateResponse(successMessage.ToLower().Equals("good"), response);
        //        ((NativeWebSocket)parameter.Sender).SendResponse(res);
        //    }
        //    catch (Exception ex)
        //    {
        //        LogMessage(ex.Message + " Exception in ILETSNetLib.checkSystem() " + ex.StackTrace, ((NativeWebSocket)parameter.Sender));
        //    }
        //}

        //public void ClosingMethodHandler(object sender)
        //{
        //    HandlerParameters parameter = (HandlerParameters)sender;
        //    try
        //    {
        //        parameter.Instance.closeAndUpload();
        //        parameter.Instance.destruct();

        //        Environment.Exit(0);
        //    }
        //    catch (Exception ex)
        //    {
        //        FileLogger.Instance.LogException(ex);                
        //    }
        //}

        //public void AboutNativeMethodHandler(object sender)
        //{
        //    HandlerParameters parameter = (HandlerParameters)sender;
        //    try
        //    {
        //        LogMessage("AboutNative Method Started.", ((NativeWebSocket)parameter.Sender));

        //        string pathDir = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        //        string path = Path.Combine(pathDir, "GIT_ID.xml");
        //        string successMessage = string.Empty;

        //        if (File.Exists(path))
        //        {
        //            string CurrentGitCommit = string.Empty;                    

        //            using (XmlTextReader xmlReader = new XmlTextReader(path))
        //            {
        //                while (xmlReader.Read())
        //                {
        //                    if (xmlReader.AttributeCount == 1 && xmlReader.Name == Config.GitCommit)
        //                    {
        //                        CurrentGitCommit = xmlReader.GetAttribute("VALUE");
        //                    }
        //                }
        //                xmlReader.Close();
        //            }
        //            successMessage = CurrentGitCommit;
        //        }
        //        Dictionary<string, string> response = new Dictionary<string, string>();
        //        response.Add("GIT-COMMIT-NATIVE", successMessage);

        //        Response res = parameter.Args.RequestInfo.GenerateResponse(true, response);
        //        ((NativeWebSocket)parameter.Sender).SendResponse(res);
        //    }
        //    catch (Exception ex)
        //    {
        //        LogMessage(ex.Message + " Exception in AboutMethodRecieved() " + ex.StackTrace, ((NativeWebSocket)parameter.Sender));
        //    }

        //}

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
