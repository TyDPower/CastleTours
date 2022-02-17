using CastleTours.Shared.Models;
using System.Net.Http.Json;

namespace CastleTours.Client.Services.CastleService
{
    public class CastleService : ICastleService
    {
        private readonly HttpClient _http;

        public List<Castle> Castles { get; set; } = new List<Castle>();

        public CastleService(HttpClient http)
        {
            _http = http;
        }

        public async Task LoadCastles()
        {
            Castles = await _http.GetFromJsonAsync<List<Castle>>($"api/Castle");
        }

        public async Task<Castle> GetCastleById(int id)
        {
            return await _http.GetFromJsonAsync<Castle>($"api/castle/{id}");
        }

    }
}
