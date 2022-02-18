using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleTours.Shared.Models
{
    public class Amenity
    {
        public int Id { get; set; } = new Random().Next(10, 100);
        public int CastleId { get; set; }
        public int LoactionId { get; set; }
        public int FacilityId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
    }
}
