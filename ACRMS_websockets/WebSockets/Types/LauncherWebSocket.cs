using SuperSocket.WebSocket;
using WebSockets.Data;
using WebSockets.Events;
using WebSockets.Logging;

namespace WebSockets.Types
{
    public class LauncherWebSocket : WebSocket
    {
        #region Launcher Events

        /// <summary>
        /// Occurs when a new session is starting.
        /// </summary>
        public event MethodReceivedEventHandler StartSessionMethodReceived;

        /// <summary>
        /// Occurs when an Undefined method is called.
        /// </summary>
        public event MethodReceivedEventHandler UndefinedMethodReceived;

        #endregion

        public LauncherWebSocket(int port)
            : base(port)
        {
            FileLogger.Instance.LogMessage("Initializing Launcher Web Socket. Port=" + port);
        }

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
                case "startSession":
                    FileLogger.Instance.LogMessage("startSession Method Recieved.");
                    if (StartSessionMethodReceived != null)
                        StartSessionMethodReceived(this, args);
                    return true;
                default:
                    FileLogger.Instance.LogMessage("Undefined Method Recieved.");
                    if (UndefinedMethodReceived != null)
                        UndefinedMethodReceived(this, args);
                    return false;
            }
        }
    }
}