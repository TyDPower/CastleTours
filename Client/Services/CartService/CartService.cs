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

        public async Task<List<CartItem>> GetCartItems()
        {
            var result = new List<CartItem>();
            var cart = await LocalStorage.GetItemAsync<List<Ticket>>("cart");

            if (cart == null)
            {
                return result;
            }

            foreach (var item in cart)
            {
                var tour = await TourService.GetTourById(item.TourId);

                var cartItem = new CartItem
                {
                    TicketId = item.Id,
                    TicketCreatedDate = item.CreatedDate,
                    TicketQty = item.Qty,
                    SelectedTour = tour,
                    SelectedAddons = item.TourAddons
                };

                result.Add(cartItem);
            }

            return result;
        }

        public async Task DeleteItem(CartItem item)
        {
            var cart = await LocalStorage.GetItemAsync<List<Ticket>>("cart");
            if (cart == null)
            {
                return;
            }

            var cartItem = cart.Find(t => t.Id == item.TicketId && t.CreatedDate == item.TicketCreatedDate);
            cart.Remove(cartItem);

            await LocalStorage.SetItemAsync("cart", cart);
            OnChange.Invoke();
        }
    }
}
