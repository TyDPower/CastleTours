using Blazored.LocalStorage;

namespace CastleTours.Client.Services.StatsService
{
    public class StatsService : IStatsService
    {
        private readonly ILocalStorageService LocalStorage;
        public HttpClient Http { get; }

        public StatsService(HttpClient http, ILocalStorageService localStorage)
        {
            Http = http;
            LocalStorage = localStorage;
        }

        public async Task GetVisits()
        {
            int visits = int.Parse(await Http.GetStringAsync("api/Stats"));
            Console.WriteLine($"Visits: {visits}");
        }

        public async Task IncrementVisits()
        {
            DateTime? lastVisit = await LocalStorage.GetItemAsync<DateTime?>("lastVisit");
            if (lastVisit == null || ((DateTime)lastVisit).Date != DateTime.Now.Date)
            {
                await LocalStorage.SetItemAsync("lastVisits", DateTime.Now);
                await Http.PostAsync("api/Stats", null);
            }
        }
    }
}
