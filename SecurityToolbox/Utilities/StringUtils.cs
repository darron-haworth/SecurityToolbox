using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityToolbox.Utilities
{
    public static class StringUtils
    {
        public static string FirstLetterToUpper(string str)
        {
            if (str == null)
                return null;

            if (str.Length > 1)
                return char.ToUpper(str[0]) + str.Substring(1);

            return str.ToUpper();
        }

        public static string HeaderTextForFieldName(string fn)
        {
            IDictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("query", "IP Address");
            dict.Add("status", "Status");
            dict.Add("country", "Country");
            dict.Add("regionName", "Region Name");
            dict.Add("city", "City");
            dict.Add("district", "District");
            dict.Add("zip", "Zip Code");
            dict.Add("isp", "ISP");
            dict.Add("org", "Organization");
            dict.Add("as", "ASN");
            dict.Add("lat", "Latitude");
            dict.Add("lon", "Longitude");
            dict.Add("blacklist", "Blacklist Info");
            return dict[fn];
        }


        public static string CodeToDescription(string code)
        {
            //https://zee.balogh.sk/how-to-check-if-ip-is-listed-in-a-block-list/

            IDictionary<string, string> txDict = new Dictionary<string, string>();
            txDict.Add("127.0.0.2", "SBL:Spamhaus Maintained");
            txDict.Add("127.0.0.3", "reserved for future use" );
            txDict.Add("127.0.0.4", "XPL:CBL Detected Address");
            txDict.Add("127.0.0.5", "XPL:NJABL Proxies (customized)");
            txDict.Add("127.0.0.6", "reserved for future use");
            txDict.Add("127.0.0.7", "reserved for future use");
            txDict.Add("127.0.0.8", "reserved for future use");
            txDict.Add("127.0.0.9", "SBL:Spamhaus DROP/EDROP Data");
            txDict.Add("127.0.0.10", "PBL:ISP Maintained");
            txDict.Add("127.0.0.11", "PBL:Spamhaus Maintained");
            return txDict[code];
        }

    }
}
