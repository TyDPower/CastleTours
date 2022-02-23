using CastleTours.Shared.Models;

namespace CastleTours.Server.Services.OperatingTimesService
{
    public interface IOperatingTimesService
    {
        Task<List<OperatingTime>> GetOperatingTimesByCastleId(int castleId);

        Task<List<OperatingTime>> GetOperatingTimesByTourId(int tourId);
    }
}
