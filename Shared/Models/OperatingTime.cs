using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleTours.Shared.Models
{
    public class OperatingTime
    {
        public int Id { get; set; }
        public int? TourId { get; set; }
        public int? CastleId { get; set; }
        public string Time { get; set; }
    }
}
