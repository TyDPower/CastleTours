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
        public DateTime CreatedDate { get; private set; } = DateTime.Now;
        public int Qty { get; set; } = 1;
        [Column(TypeName = "decimal(18,2)")]
        public decimal TicketCost { get; set; }
        public string TourName { get; set; }
        public string CustomerName { get; set; }
        public List<Addon> TourAddons { get; set; } = new List<Addon>();
        public string CastleName { get; set; }
        public string Location { get; set; }
        public string GetFormattedTicketCost()
        {
            return TicketCost.ToString("0.00");
        }
    }
}
