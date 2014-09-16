using System;
using System.Collections.Generic;
using SuperSocket.SocketBase;
using WebSockets.Data;
using WebSockets.Events;
using WebSockets.Logging;
using System.IO;
using System.Reflection;
using System.Collections;
using SuperSocket.WebSocket;

namespace WebSockets.Types
{
    /// <summary>
    /// This class is responsible for creating websocket instances for both the Native and Launcher websocket servers.
    /// </summary>
    public class WebSocket
    {
        #region Private Variables

        private WebSocketServer appServer;
        private WebSocketSession currentSession;
        private int _port;

        #endregion

        #region Delegates

        public delegate void MethodReceivedEventHandler(object sender, MethodReceivedEventArgs e);

        #endregion

        #region Events

        /// <summary>
        /// Occurs when About method is called.
        /// </summary>
        public event MethodReceivedEventHandler AboutMethodReceived;

        #endregion

        #region Public Methods

        /// <summary>
        /// Initialize Web Socket with a Designated Port Number.
        /// </summary>
        /// <param name="portNumber">Port Number which the web socket should use.</param>
        public WebSocket(int portNumber)
        {
            _port = portNumber;
        }

        /// <summary>
        /// Create a Unique Session. 
        /// </summary>
        /// <param name="ErrorMessage">Error Information for failiures.</param>
        /// <returns>Returns True if session creation was successful.</returns>
        public bool CreateUniqueSession()
        {
            try
            {
                Console.WriteLine("Starting Socket Server.");
                FileLogger.Instance.LogMessage("Starting Socket Server.");
                SuperSocket.SocketBase.Config.RootConfig r = new SuperSocket.SocketBase.Config.RootConfig();

                SuperSocket.SocketBase.Config.ServerConfig s = new SuperSocket.SocketBase.Config.ServerConfig();
                string rootFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

                s.Name = "SecureSuperWebSocket";
                s.Ip = "127.0.0.1";
                s.Port = _port;
                s.Mode = SocketMode.Tcp;

                //s.Security = "tls";
                //s.Certificate = new SuperSocket.SocketBase.Config.CertificateConfig
                //{
                //    FilePath = @"localhost_sticky_ad.pfx",
                //    Password = "274aDVGRNjY3Jyqw"
                //};
                appServer = new WebSocketServer();
                appServer.Setup(r, s);
                appServer.NewSessionConnected += new SessionHandler<WebSocketSession>(AppServerNewSessionConnected);
                appServer.NewMessageReceived += new SessionHandler<WebSocketSession, string>(AppServerNewMessageReceived);
                appServer.SessionClosed += new SessionHandler<WebSocketSession, CloseReason>(AppServerSessionClosed);
                appServer.Start();
                Console.WriteLine("Socket Server Started. IP=" + s.Ip + ". Port=" + s.Port);
                FileLogger.Instance.LogMessage("Socket Server Started. IP=" + s.Ip + ". Port=" + s.Port);
                return true;
            }
            catch (Exception exception)
            {
                FileLogger.Instance.LogException(exception);
                return false;
            }
        }

        /// <summary>
        /// Send a Response to the Web Socket client.
        /// </summary>
        /// <param name="response">Response Information.</param>
        /// <param name="ErrorMessage">Error Information for failiures.</param>
        /// <returns>Returns true if message sending was successful.</returns>
        public bool SendResponse(Response response)
        {
            try
            {
                string jsonResponse = JSONDataHandler.ToResponseString(response);

                Console.WriteLine("Sending Response.");
                FileLogger.Instance.LogMessage("Sending Response. Raw=" + jsonResponse);
                currentSession.Send(jsonResponse);

                return true;
            }
            catch (Exception exception)
            {
                FileLogger.Instance.LogException(exception);
                return false;
            }
        }

        /// <summary>
        /// Send a Log Message to the Web Socket client.
        /// </summary>
        /// <param name="type">Type of the Log Message</param>
        /// <param name="message">Message Content.</param>
        /// <param name="data">Additional Data For Message.</param>
        /// <param name="ErrorMessage">Error Information for failiures.</param>
        /// <returns></returns>
        public bool SendLogMessage(string type, string message, string data)
        {
            try
            {
                FileLogger.Instance.LogMessage("Sending Log Message. Type=" + type + ". Message =" + message + ". Data =" + data);
                Dictionary<string, Hashtable> responseParams = new Dictionary<string, Hashtable>();

                Hashtable Hashmessage = new Hashtable();
                Hashtable Hashdata = new Hashtable();

                Hashmessage.Add("Message", message);
                Hashdata.Add("Data", data);

                responseParams.Add("message", Hashmessage);
                responseParams.Add("data", Hashdata);

                Response logResponse = new Response(type, true, responseParams);
                string jsonResponse = JSONDataHandler.ToResponseString(logResponse);

                FileLogger.Instance.LogMessage("Sending Log Message. Raw=" + jsonResponse);
                currentSession.Send(jsonResponse);

                return true;
            }
            catch (Exception exception)
            {
                FileLogger.Instance.LogException(exception);
                return false;
            }
        }

        #endregion

        #region Protected Methods

        protected virtual void AppServerNewMessageReceived(WebSocketSession session, string value)
        {
            Console.WriteLine("New Message Recieved.");
            FileLogger.Instance.LogMessage("New Message Recieved. Value=" + value);
            HandleNewMessage(session, value);
        }

        /// <summary>
        /// Handle a message recieved to the socket.
        /// </summary>
        /// <param name="session">Web Socket Session information.</param>
        /// <param name="value">Value recieved.</param>
        /// <returns>True if the method was handled properly.</returns>
        protected virtual bool HandleNewMessage(WebSocketSession session, string value)
        {
            Request request = JSONDataHandler.ToRequest(value);
            MethodReceivedEventArgs args = new MethodReceivedEventArgs(request);

            switch (request.MethodName)
            {
                case "about":
                    FileLogger.Instance.LogMessage("About Method Recieved.");
                    if (AboutMethodReceived != null)
                        AboutMethodReceived(this, args);
                    return true;
                default:
                    return false;
            }
        }

        protected void AppServerNewSessionConnected(WebSocketSession session)
        {
            // The server will only maintain one connection. Whenever a new session is trying to connect, the previous 
            // session will be closed.

            if (currentSession != null)
            {
                currentSession.SendCloseHandshakeResponse(0);
                currentSession.Close();
            }
            Console.WriteLine("Client Connected. IP " + session.RemoteEndPoint.Address.ToString() + " Port " + session.RemoteEndPoint.Port.ToString());
            FileLogger.Instance.LogMessage("Client Connected. IP " + session.RemoteEndPoint.Address.ToString() + " Port " + session.RemoteEndPoint.Port.ToString());
            currentSession = session;
        }

        protected virtual void AppServerSessionClosed(WebSocketSession session, CloseReason value)
        {
            Console.WriteLine("Client Disconnected. IP " + session.RemoteEndPoint.Address + " Port " + session.RemoteEndPoint.Port.ToString());
            FileLogger.Instance.LogMessage("Client Disconnected. IP " + session.RemoteEndPoint.Address + " Port " + session.RemoteEndPoint.Port.ToString());
            FileLogger.Instance.LogMessage("Reason " + value);
        }
        #endregion

        #region Public Enums

        public enum LogMessageType
        {
            LogStreamMessage,
            WarnStreamMessage,
            DebugStreamMessage,
            ErrorStreamMessage,
            FatalStreamMessage,
            EventStartStreamMessage,
            EventEndStreamMessage,
            EventPointStreamMessage,
            AttributesStreamMessage
        }

        #endregion
    }
}
