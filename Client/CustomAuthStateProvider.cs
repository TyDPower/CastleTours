using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace CastleTours.Client
{
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {
        public CustomAuthStateProvider(ILocalStorageService localStorage)
        {
            LocalStorage = localStorage;
        }

        public ILocalStorageService LocalStorage { get; }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var state = new AuthenticationState(new ClaimsPrincipal());

            string username = await LocalStorage.GetItemAsStringAsync("username");
            if (!string.IsNullOrEmpty(username))
            {
                var identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, username)
                }, "test authentication type");

                state = new AuthenticationState(new ClaimsPrincipal(identity));
            }

            NotifyAuthenticationStateChanged(Task.FromResult(state));

            return state;
        }
    }
}
