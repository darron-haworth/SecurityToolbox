using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityToolbox.Models
{
    public class IpAddressData
    {
        public string IpAddress { get; set; }
        public string Status { get; set; }
        public string Country { get; set; }
        public string RegionName { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Zipcode { get; set; }
        public string ISP { get; set; }
        public string Organization { get; set; }
        public string ASN { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string BlackList { get; set; }

    }
}
