using CastleTours.Shared.Models;
using System.Net.Http.Json;

namespace CastleTours.Client.Services.SearchService
{
    public class SearchService : ISearchService
    {
        public SearchService(HttpClient http)
        {
            _http = http;
        }

        public HttpClient _http { get; }
        public List<Facility> Facilities { get; private set; }
        public List<Location> Locations { get; private set; }
        public List<Category> Categories { get; private set; }
        public List<string> FacilityTypes { get; private set; } = new List<string>();
        public List<string> LocationAreas { get; private set; } = new List<string>();
        public List<string> CategoryNames { get; private set; } = new List<string>();

        public async Task LoadCategories(string loadStrings = null)
        {
            if (loadStrings == null || loadStrings == string.Empty)
            {
                Categories = await _http.GetFromJsonAsync<List<Category>>("api/search/categories");
            }
            else if (loadStrings == "names" || loadStrings == "name")
            {
                CategoryNames = await _http.GetFromJsonAsync<List<string>>("api/search/categories/names");
            }
            
        }

        public async Task LoadFacilities(string loadStrings = null)
        {
            if (loadStrings == null || loadStrings == string.Empty)
            {
                Facilities = await _http.GetFromJsonAsync<List<Facility>>("api/search/facilities");
            }
            else if (loadStrings == "types" || loadStrings == "type")
            {
                FacilityTypes = await _http.GetFromJsonAsync<List<string>>("api/search/facilities/types");
            }
        }

        public async Task LoadLocations(string loadStrings = null)
        {
            if (loadStrings == null || loadStrings == string.Empty)
            {
                Locations = await _http.GetFromJsonAsync<List<Location>>("api/search/locations");
            }
            else if (loadStrings == "areas" || loadStrings == "area")
            {
                LocationAreas = await _http.GetFromJsonAsync<List<string>>("api/search/locations/areas");
            }
        }
    }
}
