using ACRMS.CPU;
using NativeWrapper.Data;
using NativeWrapper.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebSockets.Events;
using WebSockets.Types;

namespace ACRMS_websockets
{
    class ACRMS
    {
        private static int port;

        private static ProcessLocal Instance;

        private static TimeoutHandler tHandler;

        private static NativeWrapperHandler responseHandler;
        private static NativeWebSocket nws;
        static void Main(string[] args)
        {
            try
            {
                createNativeWebsocketInstance(12001);
                responseHandler = new NativeWrapperHandler();
                tHandler = new TimeoutHandler(60);
                //tHandler.SessionTimeout += tHandler_SessionTimeout;

                string Errormessage = string.Empty;

                if (nws.CreateUniqueSession())
                    Console.WriteLine("Server Running on port " + port);
                else
                    Console.WriteLine(Errormessage);

                nws.StartMonitoringMethodReceived += nws_StartMonitoring;
                nws.GetCpuUsageMethodReceived += nws_GetCpuUsageMethodReceived;
                //nws.CreateMethodReceived += nws_CreateMethodRecieved;
                //nws.ShowCalibrationDialogMethodReceived += nws_ShowCalibrationDialogMethodRecieved;
                //nws.ShowHeadValidationDialogMethodReceived += nws_ShowHeadValidationDialogMethodRecieved;
                //nws.StartRecordingMethodReceived += nws_StartRecordingMethodRecieved;
                //nws.StopRecordingMethodReceived += nws_StopRecordingMethodRecieved;
                //nws.CloseAndUploadMethodReceived += nws_CloseAndUploadMethodRecieved;
                //nws.DestructMethodReceived += nws_DestructMethodRecieved;
                //nws.GetUploadPercentMethodReceived += nws_GetUploadPercentMethodRecieved;
                //nws.GetHeadPositionMethodReceived += nws_GetHeadPositionMethodRecieved;
                //nws.IsCameraGoodEnoughMethodReceived += nws_IsCameraGoodEnoughMethodRecieved;
                //nws.ValidateQualityMethodReceived += nws_ValidateQualityMethodRecieved;
                //nws.UndefinedMethodReceived += nws_UndefinedMethodRecieved;
                //nws.CheckSystemMethodReceived += nws_CheckSystemMethodRecieved;
                //nws.ClosingMethodReceived += nws_ClosingMethodRecieved;
                //nws.AboutMethodReceived += nws_AboutMethodRecieved;

                //ErrorCallbackPtr = new Common.ErrorCallback(SendError);
                //Instance.RegisterErrorCallback(ErrorCallbackPtr);

                new ManualResetEvent(false).WaitOne();
            }
            catch (Exception ex)
            {
                //SendError(ex.Message + " Exception in Main() " + ex.StackTrace);
                Console.WriteLine(ex.StackTrace);
                Console.ReadLine();
            }
        }

        static void nws_GetCpuUsageMethodReceived(object sender, MethodReceivedEventArgs args)
        {
            try
            {
                HandlerParameters parameter = new HandlerParameters(sender, Instance, args);

                Thread thread = new Thread(new ParameterizedThreadStart(responseHandler.GetCpuUsage));
                thread.Start(parameter);
            }
            catch (Exception ex)
            {
                //SendError(ex.Message + " Exception in ILETSNetLib.checkSystem() " + ex.StackTrace);
            }
        }

        static void nws_StartMonitoring(object sender, MethodReceivedEventArgs args)
        {
            try
            {
                HandlerParameters parameter = new HandlerParameters(sender, Instance, args);

                Thread thread = new Thread(new ParameterizedThreadStart(responseHandler.StartMonitoring));
                thread.Start(parameter);
            }
            catch (Exception ex)
            {
                //SendError(ex.Message + " Exception in ILETSNetLib.checkSystem() " + ex.StackTrace);
            }
        }

        /// <summary>
        /// Creates the native websocket instance.
        /// </summary>
        /// <param name="assemblyPath">The assembly path.</param>
        /// <param name="assemblyIdentifier">The assembly identifier.</param>
        /// <param name="websocketPort">The websocket port.</param>
        private static void createNativeWebsocketInstance(int websocketPort)
        {
            Instance = new ProcessLocal();

            port = websocketPort;

            nws = new NativeWebSocket(port);
        }
    }
}
