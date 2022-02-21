using CastleTours.Shared.Models;
using System.Net.Http.Json;

namespace CastleTours.Client.Services.TourService
{
    public class TourService : ITourService
    {
        private readonly HttpClient _http;

        public event Action OnChange;

        public List<Tour> Tours { get; set; } = new List<Tour>();
        public TourService(HttpClient http)
        {
            _http = http;
        }
        public async Task LoadTours(string categoryUrl = null)
        {
            if (categoryUrl == null)
            {
                Tours = await _http.GetFromJsonAsync<List<Tour>>($"api/Tour");
            }
            else
            {
                Tours = await _http.GetFromJsonAsync<List<Tour>>($"api/Tour/Category/{categoryUrl}");
            }
            OnChange.Invoke();
        }

        public async Task<Tour> GetTourById(int id)
        {
            return await _http.GetFromJsonAsync<Tour>($"api/Tour/{id}");
        }

        public async Task<List<Tour>> SearchTours(string searchText)
        {
            return await _http.GetFromJsonAsync<List<Tour>>($"api/tour/search/{searchText}");
        }
    }
}
