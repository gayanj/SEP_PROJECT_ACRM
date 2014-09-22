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
                nws.GetRamUsageMethodReceived += nws_GetRamUsageMethodReceived;
                nws.GetDiskUsageMethodReceived += nws_GetDiskUsageMethodReceived;

                new ManualResetEvent(false).WaitOne();
            }
            catch (Exception ex)
            {
                //SendError(ex.Message + " Exception in Main() " + ex.StackTrace);
                Console.WriteLine(ex.StackTrace);
                Console.ReadLine();
            }
        }

        static void nws_GetDiskUsageMethodReceived(object sender, MethodReceivedEventArgs args)
        {
            try
            {
                HandlerParameters parameter = new HandlerParameters(sender, Instance, args);

                Thread thread = new Thread(new ParameterizedThreadStart(responseHandler.GetDiskUsage));
                thread.Start(parameter);
            }
            catch (Exception ex)
            {
                //SendError(ex.Message + " Exception in ILETSNetLib.checkSystem() " + ex.StackTrace);
            }
        }

        static void nws_GetRamUsageMethodReceived(object sender, MethodReceivedEventArgs args)
        {
            try
            {
                HandlerParameters parameter = new HandlerParameters(sender, Instance, args);

                Thread thread = new Thread(new ParameterizedThreadStart(responseHandler.GetRamUsage));
                thread.Start(parameter);
            }
            catch (Exception ex)
            {
                //SendError(ex.Message + " Exception in ILETSNetLib.checkSystem() " + ex.StackTrace);
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
