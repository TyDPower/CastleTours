using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleTours.Shared.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string? Street { get; set; }
        public string Area { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string Postcode { get; set; }
        public string Coordinates { get; set; }
        public string? GoogleMapsUrl { get; set; }
        public string? OpenStreetMapUrl { get; set; }
        public string CountryIsoCode { get; set; }

        public string GetFormattedLocation(string locationFormat = "full")
        {
            string localAddress = Street + ", " + Area + ", " + Postcode;
            string displayLocation = Region + ", " + Country + ", " + Postcode;
            string full = Street + ", " + Area + ", " + Region + ", " + Country + ", " + Postcode;

            if (locationFormat != "full")
            {
                switch (locationFormat)
                {
                    case "localAddress": return localAddress;
                    case "displayLocation": return displayLocation;
                };
            }

            return full;
        }
    }
}
