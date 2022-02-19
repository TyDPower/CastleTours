using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleTours.Shared.Models
{
    public class CartItem
    {
        public Tour SelectedTour { get; set; }
        public Castle Castle { get; set; }
        public List<Addon> SelectedAddons { get; set; } = new List<Addon>();
    }
}
