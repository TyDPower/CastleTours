using CastleTours.Shared.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace CastleTours.Client.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly HttpClient Http;
        public User User { get; private set; }

        public UserService(HttpClient http)
        {
            Http = http;
        }
        public async Task GetUserDetails()
        {
            User = new User();
            User = await Http.GetFromJsonAsync<User>("api/user/getuserdetails");
        }
    }
}
