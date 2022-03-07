using CastleTours.Shared.Models;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Json;

namespace CastleTours.Client.Services.AuthService
{
    public class AuthService : IAuthService
    {
        public AuthService(HttpClient http, AuthenticationStateProvider authSateProvider)
        {
            Http = http;
            AuthSateProvider = authSateProvider;
        }

        public HttpClient Http { get; }
        public AuthenticationStateProvider AuthSateProvider { get; }

        public async Task<bool> GetUserAuthState()
        {
            var authState = await AuthSateProvider.GetAuthenticationStateAsync();
            var user = authState.User;
            bool isAuth = user.Identity.IsAuthenticated;

            return isAuth;
        }

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
