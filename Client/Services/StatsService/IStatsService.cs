namespace CastleTours.Client.Services.StatsService
{
    public interface IStatsService
    {
        Task GetVisits();
        Task IncrementVisits();
    }
}
