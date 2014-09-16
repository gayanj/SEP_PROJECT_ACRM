using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebSockets.Data
{
    /// <summary>
    /// Class for containing information related to a reqeust recieved via Web Socket
    /// </summary>
    public class Request
    {
        /// <summary>
        /// Name of the method requested.
        /// </summary>
        public string MethodName { get; private set; }

        /// <summary>
        /// Parameters for the requested method.
        /// </summary>
        public Dictionary<string, string> Parameters { get; private set; }

        /// <summary>
        /// PID for the request.
        /// </summary>
        public string Pid { get; private set; }

        /// <summary>
        /// Create a new Request with the given method Method Name, PID and Parameters.
        /// </summary>
        /// <param name="methodName">Name of the method requested.</param>
        /// <param name="pid">PID for the request.</param>
        /// <param name="parameters">Parameters for the requested method.</param>
        public Request(string methodName, string pid, IDictionary<string,string> parameters)
        {
            this.MethodName = methodName;
            this.Pid = pid;

            if (parameters != null)
                this.Parameters = new Dictionary<string, string>(parameters);
        }

        /// <summary>
        /// Generate a Response to a given request.
        /// </summary>
        /// <param name="success">Success state of the requested method.</param>
        /// <param name="parameters">Parameters for the response.</param>
        /// <returns></returns>
        public Response GenerateResponse(bool success, Dictionary<string,Hashtable> parameters)
        {
            return new Response(this, success, parameters);
        }

        /// <summary>
        /// Generate a Response to a given request.
        /// </summary>
        /// <param name="success">Success state of the requested method.</param>        
        /// <returns></returns>
        public Response GenerateResponse(bool success)
        {
            return new Response(this, success);
        }

        /// <summary>
        /// Generate a JSON formatted string for the request.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return JSONDataHandler.ToRequestString(this);
        }
    }
}
