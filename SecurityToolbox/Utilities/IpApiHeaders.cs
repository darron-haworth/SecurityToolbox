using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityToolbox.Utilities
{
    public static class IpApiHeaders
    {
        private static string[] _allHeaders = new string[] { "query", "status", "country", "regionName", "city", "district", "zip", "isp", "org", "as", "lat", "lon", "blacklist" };
        
        public static List<string> IpApiHeaderOptions
        {
            get { return _allHeaders.ToList(); }

        }        
    }
}
