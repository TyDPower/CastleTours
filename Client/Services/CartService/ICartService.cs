using CastleTours.Shared.Models;

namespace CastleTours.Client.Services.CartService
{
    public interface ICartService
    {
        event Action OnChange;

        Task AddToCart(Ticket ticket);
    }
}
