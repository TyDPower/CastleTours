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
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int Qty { get; private set; } = 1;
        [Column(TypeName = "decimal(18,2)")]
        public decimal TicketCost { get; private set; }
        public string SelectedTourName { get; private set; }
        public string CustomerName { get; private set; }
        public List<string> SelectedTourAddons { get; private set; } = new List<string>();
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
        public void AddRemoveAddons(string addon, bool addItem = true)
        {
            if (addItem) SelectedTourAddons.Add(addon);
            else SelectedTourAddons.Remove(addon);
        }

        public void SetCustomerName(string customerName)
        {
            CustomerName = customerName;
        }

        public void SetSelectedTourName(string tourName)
        {
            SelectedTourName = tourName;
        }
    }
}
