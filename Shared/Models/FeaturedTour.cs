namespace CastleTours.Shared.Models
{
    public class FeaturedTour
    {
        public int TourId { get; set; }
        public string TourName { get; set; }
        public string TourImageUrl { get; set; }
        public string TourBlurb { get; set; }
        public string TourBasePrice { get; set; }
        public int TourRating { get; set; }
        public int CastleId { get; set; }
        public string CastleName { get; set; }
        public string ExperaincesBasePrice { get; set; }
    }
}
