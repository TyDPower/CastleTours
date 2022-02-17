using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CastleTours.Shared.Models
{
    public class Facility
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Note { get; set; }
        public string Icon { get; set; }
        [JsonIgnore]
        public List<Castle>? Castles { get; set; }
        [JsonIgnore]
        public List<Tour>? Tours { get; set; }
    }
}
