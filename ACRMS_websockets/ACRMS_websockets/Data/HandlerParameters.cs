using ACRMS.CPU;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebSockets.Events;

namespace NativeWrapper.Data
{
    /// <summary>
    /// Class for storing information related to a reqeust sent via the WebSocket so that it can be passed as an object to a Parameterized thread
    /// </summary>
    internal class HandlerParameters
    {
        /// <summary>
        /// Set or Get the object of type Websocket
        /// </summary>
        public object Sender { get; private set; }

        /// <summary>
        /// Set or Get the object of type IILETSNet
        /// </summary>
        public ProcessLocal Instance { get; private set; }

        /// <summary>
        /// Set or Get the object of type MethodRecievedEventArgs
        /// </summary>
        public MethodReceivedEventArgs Args { get; private set; }

        /// <summary>
        /// Constructor for HandlerParameters class which is used to initialize variables
        /// </summary>
        /// <param name="sender">WebSocket object</param>
        /// <param name="instance">IILETSNet object</param>
        /// <param name="args">Event object</param>
        public HandlerParameters(object sender, ProcessLocal instance, WebSockets.Events.MethodReceivedEventArgs args)
        {
            Args = args;
            Instance = instance;
            Sender = sender;
        }
    }
}
