using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CastleTours.Shared.Models
{
    public class Castle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Type { get; set; }
        public string? Date { get; set; } = "Unkown";
        public string? Condition { get; set; }
        public string Description { get; set; }
        public string Summary { get; set; }
        public string? ImgUrl { get; set; }
        public string? WikiUrl { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal EnteranceFee { get; set; } = 0;
        [Column(TypeName = "decimal(18,2)")]
        public decimal EnteranceFeeSpecial { get; set; }
        public bool IsOpenToPublic { get; set; } = false;
        public bool IsPublic { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateUpdated { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
        [JsonIgnore]
        public List<Tour>? Tours { get; set; }
        public List<CastleComment>? CastleComments { get; set; }
        public List<Facility>? Facilities { get; set; }
        public List<Amenity>? Amenities { get; set; }
        public List<OperatingTime> OperatingTimes { get; set; }
        public string GetFormattedEnteranceFee()
        {
            string price = (EnteranceFee > 0) ? EnteranceFee.ToString("$0.00") : "No Enterance Fee";
            return price;
        }
    }
}
