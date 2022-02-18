using CastleTours.Shared.Models;

namespace CastleTours.Client.Services.TicketOrderService
{
    public class TicketOrderService : ITicketOrderService
    {
        public Ticket TicketOrder { get; private set; } = new Ticket(); //change to private
        public bool TicketDialog { get; private set; } = false;

        public event Action OnChange;

        public void CreateTicketOrder(/*int qty, */decimal ticketCost, string tourName, 
            string castleName, string location, List<Addon> tourAddons)
        {
            //TicketOrder = new Ticket();
            //TicketOrder.Qty = qty;
            TicketOrder.TicketCost = ticketCost;
            TicketOrder.TourName = tourName;
            TicketOrder.CastleName = castleName;
            TicketOrder.Location = location;
            TicketOrder.TourAddons = tourAddons;
        }

        public bool GetTicketDialogStatus()
        {
            return TicketDialog;
        }

        public void ShowTicketDialog()
        {
            TicketDialog = true;
        }

        public void CloseTicketDialog()
        {
            TicketDialog = false;
            TicketOrder = new Ticket();
        }

        public Ticket GetTicketOrder()
        {
            return TicketOrder;
        }

        public string GetTicketOrderTotalFormatted()
        {
            return TicketOrder.TicketCost.ToString("0.00");
        }

        public void SetTicketQty(int ticketQty)
        {
            TicketOrder.Qty = ticketQty;
        }

        public void SetTicketOrderTotal(decimal selectedTourCost, List<Addon> selectedAddons)
        {
            decimal addonsTotal = 0.00m;
            decimal tourCost = selectedTourCost;
            int ticketQty = TicketOrder.Qty;

            foreach (var i in selectedAddons) addonsTotal += i.Price;
            decimal ticketCost = (tourCost + addonsTotal) * ticketQty;

            TicketOrder.TicketCost = ticketCost;
        }

        public async Task ClearTicketOrder()
        {
            TicketOrder = new Ticket();
        }

    }
}
