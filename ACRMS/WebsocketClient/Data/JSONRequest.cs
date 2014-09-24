using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebSockets.Data
{
    /// <summary>
    /// JSON request class
    /// </summary>
    internal class JSONRequest
    {
        public string request { get; set; }
        public IDictionary<string, string> parameters { get; set; }
        public string pid { get; set; }
    }
}
