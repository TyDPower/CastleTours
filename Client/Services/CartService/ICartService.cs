using CastleTours.Shared.Models;

namespace CastleTours.Client.Services.CartService
{
    public interface ICartService
    {
        event Action OnChange;
        Task AddToCart(Ticket ticket);
        Task<List<CartItem>> GetCartItems();
        Task DeleteItem(CartItem item);
        Task EmptyCart();
        Task<string> Checkout();
    }
}
