using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CastleTours.Shared.Models;

namespace CastleTours.Shared.DTOModels
{
    public class TourSearchResult
    {
        public List<SearchResult> SearchResults { get; set; }
        public int Pages { get; set; }
        public int CurrentPage { get; set; }
    }
}
