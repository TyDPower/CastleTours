using CastleTours.Shared.Models;

namespace CastleTours.Client.Services.SearchService
{
    public interface ISearchService
    {
        public List<Facility> Facilities { get; }
        public List<string> FacilityTypes { get; }
        public List<Location> Locations { get; }
        public List<string> LocationAreas { get; }
        public List<Category> Categories { get; }
        public List<string> CategoryNames { get; }
        Task LoadFacilities(string loadStrings);
        Task LoadLocations(string loadStrings);
        Task LoadCategories(string loadStrings);
    }
}
