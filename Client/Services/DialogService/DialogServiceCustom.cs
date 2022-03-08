namespace CastleTours.Client.Services.DialogService
{
    public class DialogServiceCustom : IDialogServiceCustom
    {
        public bool IsDialogShowing { get; private set; }

        public string DialogState { get; private set; }

        public event Action OnChange;

        public void CloseDialog()
        {
            IsDialogShowing = false;
            DialogState = "login";
            OnChange.Invoke();
        }

        public void SignInDialog()
        {
            IsDialogShowing = true;
            DialogState = "login";
            OnChange.Invoke();
        }

        public void RegistrationDialog()
        {
            if (!IsDialogShowing) IsDialogShowing = true;
            DialogState = "registration";
            OnChange.Invoke();
        }
    }
}
