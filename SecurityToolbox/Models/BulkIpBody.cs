using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityToolbox.Models
{
    public class BulkIpBody
    {
        public string query { get; set; }
        public string fields { get; set; }
    }

    public class BlResult
    {
        public bool IsListed { get; set; }
        public string ReturnCode { get; set; }
    }
}
