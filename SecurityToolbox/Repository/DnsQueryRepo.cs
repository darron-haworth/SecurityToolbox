using SecurityToolbox.Models;
using SecurityToolbox.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityToolbox.Repository
{
    public class DnsQueryRepo
    {
        public string GetIndividualIpBlockedStatus(string ip)
        {
            var returnText = "";
            VerifyIP IP = new VerifyIP(ip, new string[] { "cbl.abuseat.org", "zen.spamhaus.org" });
            if (IP.IPAddr.Valid)
                if (IP.BlackList.IsListed)
                {

                    returnText = String.Format("{0} - {1}", IP.BlackList.VerifiedOnServer.Replace("sbl-xbl.", ""), StringUtils.CodeToDescription(IP.BlackList.ReturnCode));
                }
                else
                {
                    returnText = String.Format("{0}", "Not listed");
                }
            return returnText;
        }

        public string GetBulkIpBlockedStatus(byte[] ips)
        {
            var returnText = "";
            VerifyIP IP = new VerifyIP(ips, new string[] { "sbl-xbl.spamhaus.org", "bl.spamcop.net", "cbl.abuseat.org", "zen.spamhaus.org" });
            if (IP.IPAddr.Valid)
                if (IP.BlackList.IsListed)
                {

                    returnText = String.Format("{0} - {1}", IP.BlackList.VerifiedOnServer.Replace("sbl-xbl.", ""), StringUtils.CodeToDescription(IP.BlackList.ReturnCode));
                }
                else
                {
                    returnText = String.Format("{0}", "Not listed");
                }
            return returnText;
        }
    }
}
