using CastleTours.Shared.Models;

namespace CastleTours.Client.Services.TourService
{
    public interface ITourService
    {
        event Action OnChange;
        public List<SearchResult> SearchResults { get; set; }
        string Message { get; set; }
        //Task LoadTours(string categoryUrl = null); //DEPRICATED - Use SearchTours(null) to get all tours.
        Task<Tour> GetTourById(int id);
        Task SearchTours(string searchText = null);
        Task<List<string>> GetTourSearchSuggestions(string searchText);
        Task<FeaturedTour> GetFeaturedTour();
    }
}
