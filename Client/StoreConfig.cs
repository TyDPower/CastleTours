namespace CastleTours.Client
{
    public class StoreConfig
    {
        public int MaxTicketQty { get; private set; } = 10;
        public bool BuyTicketWithoutLoggedIn { get; private set; } = true;
    }
}
