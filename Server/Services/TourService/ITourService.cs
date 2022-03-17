using CastleTours.Shared.Models;
using CastleTours.Shared.DTOModels;

namespace CastleTours.Server.Services.TourService
{
    public interface ITourService
    {
        //Task<List<Tour>> GetAllTours(); //DEPRICATED - Use SearchTours(null) to get all tours.
        Task<List<Tour>> GetToursByCategory(string categoryUrl);
        Task<Tour> GetTourById(int id);
        Task<ServiceResponse<List<SearchResult>>> SearchTours(string searchText = null);
        Task<ServiceResponse<TourSearchResult>> TourSearchResults(int page, string searchText);
        Task<ServiceResponse<List<string>>> GetTourSearchSuggestions(string searchText);
        Task<FeaturedTour> GetFeaturedTour();
    }
}
