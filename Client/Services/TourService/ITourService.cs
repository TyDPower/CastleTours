using CastleTours.Shared.Models;

namespace CastleTours.Client.Services.TourService
{
    public interface ITourService
    {
        event Action OnChange;
        public List<SearchResult> SearchResults { get; set; }
        string Message { get; set; }
        //Task LoadTours(string categoryUrl = null); //DEPRICATED - Use SearchTours(null) to get all tours.
        int CurrentPage { get; set; }
        int PageCount { get; set; }
        string LastSearchText { get; set; }
        Task<Tour> GetTourById(int id);
        Task SearchTours(int page, string searchText);
        Task<List<string>> GetTourSearchSuggestions(string searchText);
        Task<FeaturedTour> GetFeaturedTour();
    }
}
