using CastleTours.Shared.Models;
using System.Net.Http.Json;

namespace CastleTours.Client.Services.AuthService
{
    public class AuthService : IAuthService
    {
        public AuthService(HttpClient http)
        {
            Http = http;
        }

        public HttpClient Http { get; }

        public async Task<ServiceResponse<string>> Login(UserLogin request)
        {
            var result = await Http.PostAsJsonAsync("api/auth/login", request);

            return await result.Content.ReadFromJsonAsync<ServiceResponse<string>>();
        }

        public async Task<ServiceResponse<int>> Register(UserRegister request)
        {
            var result = await Http.PostAsJsonAsync("api/auth/register", request);

            return await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();
        }
    }
}
