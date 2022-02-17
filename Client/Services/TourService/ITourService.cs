using CastleTours.Shared.Models;

namespace CastleTours.Client.Services.TourService
{
    public interface ITourService
    {
        event Action OnChange;
        public List<Tour> Tours { get; set; }
        Task LoadTours(string categoryUrl = null);
        Task<Tour> GetTourById(int id);
    }
}
