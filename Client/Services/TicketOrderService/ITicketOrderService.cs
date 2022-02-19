using CastleTours.Shared.Models;

namespace CastleTours.Client.Services.TicketOrderService
{
    public interface ITicketOrderService
    {
        bool GetTicketDialogStatus();
        void ShowTicketDialog();
        void CloseTicketDialog();
        Ticket GetTicketOrder();
        void SetTicketQty(int ticketQty);
        void SetTourId(int tourId);
        void SetCastleId(int castleId);
        void SetTicketTitle(string ticketTitle);
        string SetAndReturnTicketOrderTotal(decimal selectedTourCost);
        void AddTourAddonsToTicket(Addon addon);
        Task ClearTicketOrder();
    }
}
