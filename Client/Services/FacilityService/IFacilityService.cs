using CastleTours.Shared.Models;

namespace CastleTours.Client.Services.FacilityService
{
    public interface IFacilityService
    {
        public List<Facility> Facilities { get; set; }
        Task LoadFacilities();
    }
}
