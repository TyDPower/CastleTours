using CastleTours.Shared.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace CastleTours.Client.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly HttpClient Http;

        public event Action OnChange;

        public User User { get; private set; }

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

        public async Task<List<Favorite>> GetUserFavorites()
        {
            var Favorites = await Http.GetFromJsonAsync<List<Favorite>>("api/user/getUserFavorites");
            return Favorites;
        }

        public async Task<Favorite> GetUserFavorite(int tourId)
        {
            var Favorite = await Http.GetFromJsonAsync<Favorite>($"api/user/getUserFavorites/{tourId}");
            return Favorite;
        }

        public async Task<ServiceResponse<int>> AddFavorite(Favorite favorite)
        {
            var result = await Http.PostAsJsonAsync<Favorite>("api/auth/addFavorite", favorite);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();
        }

        public async Task<ServiceResponse<int>> RemoveFavorite(int tourId)
        {
            var result = await Http.DeleteAsync($"api/auth/removeFavorite/{tourId}");
            return await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();
        }
    }
}
