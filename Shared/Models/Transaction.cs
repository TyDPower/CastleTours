using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleTours.Shared.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public int TourId { get; set; }
    }
}
