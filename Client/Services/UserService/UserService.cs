using CastleTours.Shared.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace CastleTours.Client.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly HttpClient Http;
        private User User { get; set; }

        public UserService(HttpClient http)
        {
            Http = http;
        }
        public async Task GetUserDetailsFromDb()
        {
            User = new User();
            User = await Http.GetFromJsonAsync<User>("api/user/getuserdetails");
        }

        public User GetUserDetails()
        {
            return User;
        }
    }
}
