using Newtonsoft.Json;
using RestSharp;
using SecurityToolbox.Models;
using SecurityToolbox.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityToolbox.Repository
{
    public class IpAddressRepo
    {

        public RootIpAddressLookup DoBulkIpLookup(List<string> ips, List<string> fieldsToUse)
        {
            var chunkedResults = new List<RootIpAddressLookup>();
            var combinedIpResults = new List<IpAddressData>();
            var returnResults = new RootIpAddressLookup();
            var rows = ips.Count;
            var fullGroups = Math.Truncate(rows / 100d);
            var remainingGroup = (rows % 100) > 0 ? 1 : 0;
            var totalGroups = fullGroups + remainingGroup;

            if (ips.Count > 100)
            {
                var chunks = Split<string>(ips, 100);
                var x = chunks;
                foreach (var chunkList in chunks)
                {
                    chunkedResults.Add(GetData(chunkList));
                }
                foreach (RootIpAddressLookup root in chunkedResults)
                {
                    var cList = root.IpAddressData;
                    combinedIpResults.AddRange(cList);
                }
                returnResults.IpAddressData = combinedIpResults;
            }
            else
            {
                returnResults = GetData(ips);
            }

            return returnResults;

        }

        private RootIpAddressLookup GetData(List<string> ips)
        {
            var searchFields = new List<string> { "query", "status", "country", "regionName", "city", "district", "zip", "isp", "org", "as", "lat", "lon", "blacklist" };
            var client = new RestClient("http://ip-api.com");
            List<BulkIpBody> body = new List<BulkIpBody>();


            var fieldsToUse = "";
            foreach (string f in searchFields)
            {
                fieldsToUse += string.Format("{0},", f);
            }

            fieldsToUse = fieldsToUse.TrimEnd(',');

            foreach (string s in ips)
            {
                if (!string.IsNullOrEmpty(s) && s != "127.0.0.1")
                {
                    BulkIpBody bodyItem = new BulkIpBody { query = s, fields = fieldsToUse };
                    body.Add(bodyItem);
                }
            }
            string output = JsonConvert.SerializeObject(body);
            var request = new RestRequest("/batch/}", Method.POST);
            request.AddParameter("application/json", output, ParameterType.RequestBody);

            // execute the request
            //client.Timeout = 5000000;
            IRestResponse response = client.Execute(request);

            var content = response.Content; // raw content as string
            JsonSerializerSettings settings = new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore
            };

            var data = new List<IpAddressData>();
            var results = JsonConvert.DeserializeObject<List<IpApiResponse>>(content, settings);
            foreach (var r in results)
            {
                var d = new IpAddressData() { ASN = r.As, City = r.city, Country = r.country, District = r.district, IpAddress = r.query, ISP = r.isp, Latitude = r.lat, Longitude = r.lon, Organization = r.org, RegionName = r.regionName, Status = r.status, Zipcode = r.zip };
                data.Add(d);
            }
            return new RootIpAddressLookup() { IpAddressData = data };
        }

        public static List<List<T>> Split<T>(List<T> collection, int size)
        {
            var chunks = new List<List<T>>();
            var chunkCount = collection.Count() / size;

            if (collection.Count % size > 0)
                chunkCount++;

            for (var i = 0; i < chunkCount; i++)
                chunks.Add(collection.Skip(i * size).Take(size).ToList());

            return chunks;
        }
    }
}
