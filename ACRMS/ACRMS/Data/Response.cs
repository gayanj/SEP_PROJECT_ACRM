using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebSockets.Data
{
    /// <summary>
    /// Class for containing information related to a reqeust to be sent via Web Socket
    /// </summary>
    public class Response
    {
        /// <summary>
        /// Name of the method requested.
        /// </summary>
        public string MethodName { get; private set; }

        /// <summary>
        /// Parameters for the response.
        /// </summary>
        public Dictionary<string, Hashtable> Parameters { get; private set; }

        /// <summary>
        /// Success state of the requested method.
        /// </summary>
        public bool Success { get; private set; }

        /// <summary>
        /// PID of the Request.
        /// </summary>
        public string Pid { get; private set; }

        /// <summary>
        /// Initialize a response for a given Request.
        /// </summary>
        /// <param name="request">Request for which the response is generated.</param>
        /// <param name="success">Success state of the requested method.</param>
        /// <param name="parameters">Parameters for the response.</param>
        public Response(Request request, bool success, Dictionary<string, Hashtable> parameters)
            : this(request, success)
        {            
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initialize a response for a given Request.
        /// </summary>
        /// <param name="request">Request for which the response is generated.</param>
        /// <param name="success">Success state of the requested method.</param>        
        public Response(Request request, bool success)
        {
            this.MethodName = request.MethodName;            
            this.Pid = request.Pid;
            this.Success = success;
        }

        /// <summary>
        /// Initialize a generic response.
        /// </summary>
        /// <param name="methodName">Name of the method requested.</param>
        /// <param name="success">Success state of the requested method.</param>
        /// <param name="parameters">Parameters for the response.</param>
        public Response(string methodName, bool success, Dictionary<string, Hashtable> parameters)
            : this(methodName, success)
        {            
            this.Parameters = parameters;            
        }

        /// <summary>
        /// Initialize a generic response.
        /// </summary>
        /// <param name="methodName">Name of the method requested.</param>
        /// <param name="success">Success state of the requested method.</param>        
        public Response(string methodName, bool success)
        {
            this.MethodName = methodName;
            this.Success = success;
        }

        /// <summary>
        /// Generate a Response from a JSON String.
        /// </summary>
        /// <param name="response">JSON Formatted response string.</param>
        /// <returns></returns>
        public static Response FromString(string response)
        {
            return JSONDataHandler.ToResponse(response);
        }
    }
}
