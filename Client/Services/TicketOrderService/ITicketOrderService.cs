using CastleTours.Shared.Models;

namespace CastleTours.Client.Services.TicketOrderService
{
    public interface ITicketOrderService
    {
        bool GetTicketDialogStatus();
        void ShowTicketDialog();
        void CloseTicketDialog();
        Ticket GetTicketOrder();
        //string GetTicketOrderTotalFormatted();
        void SetCustomerName(string customerName = "Guest");
        void SetTourName(string tourName);
        void SetTicketQty(int ticketQty);
        void SetCastleName(string castleName);
        void SetTourLocation(string location);
        string SetAndReturnTicketOrderTotal(decimal selectedTourCost);
        void AddTourAddonsToTicket(Addon addon);
        Task ClearTicketOrder();
    }
}
