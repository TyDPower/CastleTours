using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleTours.Shared.Models
{
    public class Ticket
    {
        public string Id { get; private set; } = Guid.NewGuid().ToString();
        public int CastleId { get; set; }
        public int TourId { get; set; }
        public string Title { get; set; }
        public int CustomerId { get; set; }
        public DateTime CreatedDate { get; private set; } = DateTime.Now;
        public int Qty { get; set; } = 1;
        public List<Addon> TourAddons { get; set; } = new List<Addon>();
    }
}
