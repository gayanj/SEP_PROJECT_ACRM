using ACRMS.CPU;
using ACRMS_websockets.CPU_classes;
using NativeWrapper.Data;
using NativeWrapper.Handlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        private static CPUMonitoring cpum;
        public static NotifyIcon notifyIcon1;
        private static IContainer components;
        static void Main(string[] args)
        {
            try
            {
                components = new System.ComponentModel.Container();
                notifyIcon1 = new System.Windows.Forms.NotifyIcon(components);
                notifyIcon1.Icon = new Icon("image.ico");
                notifyIcon1.Visible = true;
                createNativeWebsocketInstance(12001);
                responseHandler = new NativeWrapperHandler();
                tHandler = new TimeoutHandler(60);
                cpum = new CPUMonitoring();
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
                nws.GetCpuAlertsMethodReceived += nws_GetCpuAlertsMethodReceived;

                cpum.StartPersistingData();
                cpum.StartCPUMonitoring();

                new ManualResetEvent(false).WaitOne();
            }
            catch (Exception ex)
            {
                //SendError(ex.Message + " Exception in Main() " + ex.StackTrace);
                Console.WriteLine(ex.StackTrace);
                Console.ReadLine();
            }
        }

        static void nws_GetCpuAlertsMethodReceived(object sender, MethodReceivedEventArgs args)
        {
            try
            {
                HandlerParameters parameter = new HandlerParameters(sender, Instance, args);

                Thread thread = new Thread(new ParameterizedThreadStart(responseHandler.GetCpuAlerts));
                thread.Start(parameter);
            }
            catch (Exception ex)
            {
                //SendError(ex.Message + " Exception in ILETSNetLib.checkSystem() " + ex.StackTrace);
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
