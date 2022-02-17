﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleTours.Shared.Models
{
    public class Location
    {
        public int Id { get; set; }
        //public int CastleId { get; set; }
        public string? Street { get; set; }
        public string Area { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string Postcode { get; set; }
        public string Coordinates { get; set; }
        public string? GoogleMapsUrl { get; set; }
        public string? OpenStreetMapUrl { get; set; }

    }
}
