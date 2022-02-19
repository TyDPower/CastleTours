using CastleTours.Client.Services.StoreConfigService;
using CastleTours.Shared.Models;

namespace CastleTours.Client.Services.TicketOrderService
{
    public class TicketOrderService : ITicketOrderService
    {
        public Ticket TicketOrder { get; private set; } = new Ticket(); //change to private
        public bool TicketDialog { get; private set; } = false;

        public event Action OnChange;

        public bool GetTicketDialogStatus()
        {
            return TicketDialog;
        }

        public void ShowTicketDialog() => TicketDialog = true;

        public void CloseTicketDialog()
        {
            TicketDialog = false;
            TicketOrder = new Ticket();
        }

        public Ticket GetTicketOrder()
        {
            return TicketOrder;
        }

        public void SetTicketQty(int ticketQty) => TicketOrder.Qty = ticketQty;


        public void SetTourId(int tourId) => TicketOrder.TourId = tourId;

        public void SetCastleId(int castleId) => TicketOrder.CastleId = castleId;

        public void SetCustomerId(int customerId) => TicketOrder.CustomerId = customerId;
        public void SetTicketTitle(string ticketTitle) => TicketOrder.Title = ticketTitle;

        public string SetAndReturnTicketOrderTotal(decimal selectedTourCost)
        {
            decimal addonsTotal = 0.00m;
            decimal tourCost = selectedTourCost;
            int ticketQty = TicketOrder.Qty;

            foreach (var i in TicketOrder.TourAddons) addonsTotal += i.Price;
            decimal ticketCost = (tourCost + addonsTotal) * ticketQty;

            return ticketCost.ToString("0.00");
        }

        public void AddTourAddonsToTicket(Addon addon)
        {
            var item = TicketOrder.TourAddons.Find(i => i.Id == addon.Id);

            if (item != null) TicketOrder.TourAddons.Remove(item);
            else TicketOrder.TourAddons.Add(addon);
        }

        public async Task ClearTicketOrder() => TicketOrder = new Ticket();

    }
}
