using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleTours.Shared.Models
{
    public class CartItem
    {
        public string TicketId { get; set; }
        public DateTime? TicketCreatedDate { get; set; }
        public int TicketQty { get; set; }
        public Tour? SelectedTour { get; set; }
        public List<Addon> SelectedAddons { get; set; } = new List<Addon>();
        public decimal GetTicketOrderTotal()
        {
            decimal addonsTotal = 0.00m;
            decimal tourCost = SelectedTour.GetTicketPrice();
            int ticketQty = TicketQty;

            foreach (var i in SelectedAddons) addonsTotal += i.Price;
            decimal ticketCost = (tourCost + addonsTotal) * ticketQty;

            return ticketCost;
        }
    }
}
