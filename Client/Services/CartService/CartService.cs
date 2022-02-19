using Blazored.LocalStorage;
using Blazored.Toast.Services;
using CastleTours.Client.Services.TourService;
using CastleTours.Shared.Models;

namespace CastleTours.Client.Services.CartService
{
    public class CartService : ICartService
    {
        public ILocalStorageService LocalStorage { get; }
        public IToastService ToastService { get; }
        public ITourService TourService { get; }

        public event Action OnChange;

        public CartService(ILocalStorageService localStorage, IToastService toastService, ITourService tourService)
        {
            LocalStorage = localStorage;
            ToastService = toastService;
            TourService = tourService;
        }

        public async Task AddToCart(Ticket ticket)
        {
            var cart = await LocalStorage.GetItemAsync<List<Ticket>>("cart");
            if (cart == null) cart = new List<Ticket>();
            cart.Add(ticket);
            await LocalStorage.SetItemAsync("cart", cart);

            ToastService.ShowSuccess(ticket.Title, "Added to cart:");

            OnChange.Invoke();
        }
    }
}
