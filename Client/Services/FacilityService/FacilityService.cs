using CastleTours.Shared.Models;
using System.Net.Http.Json;

namespace CastleTours.Client.Services.FacilityService
{
    public class FacilityService : IFacilityService
    {
        public List<Facility> Facilities { get; set; } = new List<Facility>();
        public HttpClient _http { get; }

        public FacilityService(HttpClient http)
        {
            _http = http;
        }

        public async Task LoadFacilities()
        {
            Facilities = await _http.GetFromJsonAsync<List<Facility>>("api/Facility");
        }
    }
}
