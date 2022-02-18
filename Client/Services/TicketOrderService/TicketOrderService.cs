using CastleTours.Shared.Models;

namespace CastleTours.Client.Services.TicketOrderService
{
    public class TicketOrderService : ITicketOrderService
    {
        public Ticket TicketOrder { get; private set; }

        public void CreateTicketOrder(int qty, decimal ticketCost, string tourName, 
            string castleName, string location, List<Addon> tourAddons)
        {
            TicketOrder = new Ticket();
            TicketOrder.Qty = qty;
            TicketOrder.TicketCost = ticketCost;
            TicketOrder.TourName = tourName;
            TicketOrder.CastleName = castleName;
            TicketOrder.Location = location;
            TicketOrder.TourAddons = tourAddons;
        }

        public Ticket GetTicketOrder()
        {
            return TicketOrder;
        }

        public async Task ClearTicketOrder()
        {
            TicketOrder = null;
        }
    }
}
