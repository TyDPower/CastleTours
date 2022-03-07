using CastleTours.Shared.Models;
using System.Net.Http.Json;

namespace CastleTours.Client.Services.TourService
{
    public class TourService : ITourService
    {
        private readonly HttpClient _http;

        public event Action OnChange;

        public List<SearchResult> SearchResults { get; set; } = new List<SearchResult>();
        public string Message { get; set; } = "Searching...";

        public TourService(HttpClient http)
        {
            _http = http;
        }

        //DEPRICATED - Use SearchTours(null) to get all tours.
        /*public async Task LoadTours(string categoryUrl = null)
        {
            SearchResults = await _http.GetFromJsonAsync<List<Tour>>($"api/Tour");
        }*/

        public async Task<Tour> GetTourById(int id)
        {
            return await _http.GetFromJsonAsync<Tour>($"api/Tour/{id}");
        }

        public async Task SearchTours(string searchText = null)
        {
            if (searchText != null)
            {
                var result = await _http.GetFromJsonAsync<ServiceResponse<List<SearchResult>>>($"api/tour/search/{searchText}");
                SearchResults = result.Data;
            }
            else
            {
                var result = await _http.GetFromJsonAsync<ServiceResponse<List<SearchResult>>>($"api/tour/loadAll");
                SearchResults = result.Data;
            }
            
            if (SearchResults == null || SearchResults.Count == 0)
            {
                Message = "No tours or experiences found.";
            }
        }

        public async Task<List<string>> GetTourSearchSuggestions(string searchText)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<string>>>($"api/tour/searchSuggestions/{searchText}");
            return result.Data;
        }

        public async Task<FeaturedTour> GetFeaturedTour()
        {
            return await _http.GetFromJsonAsync<FeaturedTour>($"api/tour/featured");
        }
    }
}
