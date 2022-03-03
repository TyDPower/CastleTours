using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleTours.Shared.Models
{
    public class StoreTransaction : Transaction
    {
        public int Id { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TicketCost { get; set; }
        public int UserId { get; set; }
    }
}
