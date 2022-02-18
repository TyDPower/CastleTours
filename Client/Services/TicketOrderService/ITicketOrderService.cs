using CastleTours.Shared.Models;

namespace CastleTours.Client.Services.TicketOrderService
{
    public interface ITicketOrderService
    {
        void CreateTicketOrder(int qty, decimal ticketCost, string tourName,
            string castleName, string location, List<Addon> tourAddons);
        Ticket GetTicketOrder();
        Task ClearTicketOrder();
    }
}
