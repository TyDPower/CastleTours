using CastleTours.Shared.Models;

namespace CastleTours.Server.Services.TourService
{
    public interface ITourService
    {
        Task<List<Tour>> GetAllTours();
        Task<List<Tour>> GetToursByCategory(string categoryUrl);
        Task<Tour> GetTourById(int id);
        Task<List<Tour>> SearchTours(string searchText);
        Task<FeaturedTour> GetFeaturedTour();
    }
}
