using CastleTours.Shared.Models;
using Stripe.Checkout;

namespace CastleTours.Server.Services.PaymentService
{
    public interface IPaymentService
    {
        Session CreateCheckoutSession(List<CartItem> cartItems);
    }
}
