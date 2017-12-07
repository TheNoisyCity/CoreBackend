using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBackend.InnerModels
{
    public class Error
    {
        public int statusCode { get; set; }
        public string message { get; set; }
    }
}
