using CastleTours.Shared.Models;
using CastleTours.Shared.DTOModels;
using System.Net.Http.Json;

namespace CastleTours.Client.Services.TourService
{
    public class TourService : ITourService
    {
        private readonly HttpClient _http;

        public event Action OnChange;

        public List<SearchResult> SearchResults { get; set; } = new List<SearchResult>();
        public int CurrentPage { get; set; } = 1;
        public int PageCount { get; set; } = 0;
        public string LastSearchText { get; set; }
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

        public async Task SearchTours(int page, string searchText)
        {
            LastSearchText = searchText;
            if (searchText != null)
            {
                var results = await _http.GetFromJsonAsync<ServiceResponse<TourSearchResult>>($"api/tour/search/new/{searchText}/{page}");
                SearchResults = results.Data.SearchResults;
                CurrentPage = results.Data.CurrentPage;
                PageCount = results.Data.Pages;
            }
            
            if (SearchResults == null || SearchResults.Count == 0)
            {
                Message = "No tours or experiences found.";
            }
            OnChange.Invoke();
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
