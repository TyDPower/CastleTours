using CastleTours.Shared.Models;

namespace CastleTours.Server.Services.SearchService
{
    public interface ISearchService
    {
        Task<List<Location>> GetLocations();
        Task<List<string>> GetLocationAreas();
        Task<List<Facility>> GetFacilities();
        Task<List<string>> GetFacilityTypes();
        Task<List<Category>> GetCategories();
        Task<List<string>> GetCategoryNames();
        //Task<List<Sort>> GetSort();
    }
}
