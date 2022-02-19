namespace CastleTours.Client.Services.StoreConfigService
{
    public class StoreConfigService : IStoreConfigService
    {
        public int MaxTicketQty { get; private set; } = 10;
        public bool BuyTicketWithoutLoggedIn { get; private set; } = true;

        public int GetMaxticketQty()
        {
            return MaxTicketQty;
        }

        public bool GetBuyTicketWithoutLoggedIn()
        {
            return BuyTicketWithoutLoggedIn;
        }
    }
}
