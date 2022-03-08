namespace CastleTours.Client.Services.DialogService
{
    public interface IDialogServiceCustom
    {
        event Action OnChange;
        public bool IsDialogShowing { get; }
        public string DialogState { get; }
        public void SignInDialog();
        public void CloseDialog();
        public void RegistrationDialog();
    }
}
