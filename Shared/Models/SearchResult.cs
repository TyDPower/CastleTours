using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleTours.Shared.Models
{
    public class SearchResult
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Rating { get; set; }
        public string Blurb { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public string ImgUrl { get; set; }
        public bool IsFavorite { get; set; } = false;
        public List<Facility> Facilities { get; set; } = new List<Facility>();
    }
}
