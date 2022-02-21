using CastleTours.Shared.Models;
using Stripe;
using Stripe.Checkout;

namespace CastleTours.Server.Services.PaymentService
{
    public class PaymentService : IPaymentService
    {

        public PaymentService()
        {
            StripeConfiguration.ApiKey = "sk_test_51I6vB4DfEv7VtGSBosPLmp9pvtk1hAibqdSW6nGvaApSLEqn5qzlNddY69LCr1IP6WnAGy1gjKEYtfMaGxK2vu4q00G4epZKAY";
        }
        public Session CreateCheckoutSession(List<CartItem> cartItems)
        {
            var lineItems = new List<SessionLineItemOptions>();
            cartItems.ForEach(cartItem => lineItems.Add(new SessionLineItemOptions
            {
                PriceData = new SessionLineItemPriceDataOptions {
                    UnitAmountDecimal = cartItem.GetTicketOrderTotal() * 100,
                    Currency = "gbp",
                    ProductData = new SessionLineItemPriceDataProductDataOptions
                    {
                        Name = cartItem.TicketId,
                    }
                },
                Quantity = cartItem.TicketQty
            }));

            var options = new SessionCreateOptions
            {
                PaymentMethodTypes = new List<string>
                {
                    "card",
                },

                LineItems = lineItems,
                Mode = "payment",
                SuccessUrl = "https://localhost:7229/order-success",
                CancelUrl = "https://localhost:7229/cart",
            };

            var service = new SessionService();
            Session session = service.Create(options);
            return session;
        }
    }
}
