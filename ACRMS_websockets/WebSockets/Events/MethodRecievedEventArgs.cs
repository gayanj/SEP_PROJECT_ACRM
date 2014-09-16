using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebSockets.Data;

namespace WebSockets.Events
{
    public class MethodReceivedEventArgs : EventArgs
    {
        public static MethodReceivedEventArgs Empty
        {
            get
            {
                return new MethodReceivedEventArgs(null);
            }
        }

        /// <summary>
        /// Request information for the Event.
        /// </summary>
        public Request RequestInfo { get; private set; }

        /// <summary>
        /// Initialize the MethodRecievedEventArgs
        /// </summary>
        /// <param name="requestInfo">Request information for the Event.</param>
        public MethodReceivedEventArgs(Request requestInfo)
        {
            this.RequestInfo = requestInfo;
        }
    }
}
