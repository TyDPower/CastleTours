using CastleTours.Shared.Models;

namespace CastleTours.Client.Services.TicketOrderService
{
    public interface ITicketOrderService
    {
        bool GetTicketDialogStatus();
        void ShowTicketDialog();
        void CloseTicketDialog();
        void CreateTicketOrder(/*int qty,*/ decimal ticketCost, string tourName,
            string castleName, string location, List<Addon> tourAddons);
        Ticket GetTicketOrder();
        string GetTicketOrderTotalFormatted();
        void SetTicketQty(int ticketQty);
        void SetTicketOrderTotal(decimal selectedTourCost, List<Addon> selectedAddons);
        Task ClearTicketOrder();
    }
}
