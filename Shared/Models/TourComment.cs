using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleTours.Shared.Models
{
    public class TourComment : Comment
    {
        public int TourId { get; set; }
        public Tour Tour { get; set; }
        public int Rating { get; set; }
    }
}
