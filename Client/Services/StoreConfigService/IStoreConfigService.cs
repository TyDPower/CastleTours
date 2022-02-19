namespace CastleTours.Client.Services.StoreConfigService
{
    public interface IStoreConfigService
    {
        int GetMaxticketQty();

        bool GetBuyTicketWithoutLoggedIn();
    }
}
