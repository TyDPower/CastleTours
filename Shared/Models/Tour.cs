using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleTours.Shared.Models
{
    public class Tour
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsOperating { get; set; } = true;
        public bool IsPublic { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
        public bool IsFeatured { get; set; } = false;
        public string? Blurb { get; set; }
        public string ImgUrl { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal SpecialPrice { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateUpdated { get; set; }
        public int CastleId { get; set; }
        public Castle? Castle { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public List<TourComment>? TourComments { get; set; }
        public List<OperatingTime>? OperatingTimes { get; set; }
        public List<Addon> Addons { get; set; } = new List<Addon>();
        public List<Facility> Facilities { get; set; } = new List<Facility>();

        public string GetTicketPriceFormatted()
        {
            decimal tourBasePrice = (SpecialPrice != 0 && SpecialPrice < Price) ? SpecialPrice : Price;
            return tourBasePrice.ToString("0.00");
        }

        public decimal GetTicketPrice()
        {
            decimal tourBasePrice = (SpecialPrice != 0 && SpecialPrice < Price) ? SpecialPrice : Price;
            return tourBasePrice;
        }

        public int GetTourRating()
        {
            int total = 0;
            int averageRating = 0;
            foreach(var comment in TourComments)
            {
                total += comment.Rating;
                averageRating = total / TourComments.Count;
            }

            return averageRating;
        }
    }
}
