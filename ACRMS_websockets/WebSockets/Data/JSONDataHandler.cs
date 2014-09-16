using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using WebSockets.Logging;

namespace WebSockets.Data
{
    internal class JSONDataHandler
    {
        /// <summary>
        /// Convert a JSON String to a Request Type.
        /// </summary>
        /// <param name="JSONString">JSON formatted string.</param>
        /// <returns></returns>
        public static Request ToRequest(string JSONString)
        {
            try
            {
                JSONRequest request = JsonConvert.DeserializeObject<JSONRequest>(JSONString);
                return new Request(request.request, request.pid, request.parameters);
            }
            catch(Exception ex)
            {
                FileLogger.Instance.LogException(ex);
                return null;
            }
        }

        public static Response ToResponse(string JSONString)
        {
            try
            {
                JSONResponse response = JsonConvert.DeserializeObject<JSONResponse>(JSONString);
                return new Response(response.response, response.success, response.parameters);
            }
            catch (Exception ex)
            {
                FileLogger.Instance.LogException(ex);
                return null;
            }
        }

        /// <summary>
        /// Serialize a Response type to a JSON String.
        /// </summary>
        /// <param name="response">Response object to serialize.</param>
        /// <returns></returns>
        public static string ToResponseString(Response response)
        {
            try
            {
                JSONResponse JResponse = new JSONResponse();
                JResponse.response = response.MethodName;

                if (response.Parameters != null)
                    JResponse.parameters = response.Parameters;

                JResponse.pid = response.Pid;
                JResponse.success = response.Success;

                return JsonConvert.SerializeObject(JResponse);
            }
            catch (Exception ex)
            {
                FileLogger.Instance.LogException(ex);
                return null;
            }
        }

        /// <summary>
        /// Serialize a Request type to a JSON String.
        /// </summary>
        /// <param name="request">Request object to serialize.</param>
        /// <returns></returns>
        public static string ToRequestString(Request request)
        {
            try
            {
                JSONRequest JRequest = new JSONRequest();
                JRequest.parameters = request.Parameters;
                JRequest.pid = request.Pid;
                JRequest.request = request.MethodName;

                return JsonConvert.SerializeObject(JRequest);
            }
            catch (Exception ex)
            {
                FileLogger.Instance.LogException(ex);
                return null;
            }
        }

        private JSONDataHandler()
        {

        }
    }
}
