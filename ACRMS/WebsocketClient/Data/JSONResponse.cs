using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebSockets.Data
{
    /// <summary>
    /// JSON response class
    /// </summary>
    internal class JSONResponse
    {
        public string response { get; set; }
        public Dictionary<string, Hashtable> parameters { get; set; }
        public bool success { get; set; }
        public string pid { get; set; }
    }
}
