using Blazored.LocalStorage;
using CastleTours.Client.Services.UserService;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Json;

namespace CastleTours.Client
{
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {
        private readonly IUserService UserService;

        public CustomAuthStateProvider(ILocalStorageService localStorage, HttpClient http, IUserService userService)
        {
            LocalStorage = localStorage;
            Http = http;
            UserService = userService;
        }

        public ILocalStorageService LocalStorage { get; }
        public HttpClient Http { get; }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            string authToken = await LocalStorage.GetItemAsStringAsync("authToken");

            var identity = new ClaimsIdentity();
            Http.DefaultRequestHeaders.Authorization = null;

            if (!string.IsNullOrEmpty(authToken))
            {
                try
                {
                    identity = new ClaimsIdentity(ParseClaimsFromJwt(authToken), "jwt");
                    Http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken.Replace("\"", ""));
                    await UserService.GetUserDetailsFromDb();
                }
                catch (Exception)
                {
                    await LocalStorage.RemoveItemAsync("authToken");
                    identity = new ClaimsIdentity();
                }
            }

            var user = new ClaimsPrincipal(identity);
            var state = new AuthenticationState(user);

            NotifyAuthenticationStateChanged(Task.FromResult(state));

            return state;
        }

        private byte[] ParseBase64WithoutPadding(string base64)
        {
            switch(base64.Length % 4)
            {
                case 2: base64 += "=="; break;
                case 3: base64 += "="; break;
            }

            return Convert.FromBase64String(base64);
        }

        private IEnumerable<Claim> ParseClaimsFromJwt(string jwt)
        {
            var payload = jwt.Split(".")[1];
            var jsonBytes = ParseBase64WithoutPadding(payload);
            var KeyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);
            var claims = KeyValuePairs.Select(kvp => new Claim(kvp.Key, kvp.Value.ToString()));

            return claims;
        }
    }
}
