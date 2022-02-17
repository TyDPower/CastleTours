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
        public int Id { get; set; }
        public string TicketSerialNumber { get; set; } = Guid.NewGuid().ToString();
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int Qty { get; private set; } = 1;
        public int MaxTicketQty { get; private set; } = 10;
        [Column(TypeName = "decimal(18,2)")]
        public decimal TicketCost { get; private set; }
        public Tour SelectedTour { get; private set; } = new Tour();
        public string GetFormattedTicketCost()
        {
            return TicketCost.ToString("0.00");
        }
        public void UpdateTicketQty(int ticketQty)
        {
            Qty = ticketQty;
        }
        public void UpdateTicketCost(decimal ticketCost)
        {
            TicketCost = ticketCost;
        }
    }
}
