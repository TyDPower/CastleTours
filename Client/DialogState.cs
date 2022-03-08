namespace CastleTours.Client
{
    public class DialogState
    {
        public bool IsDialogShowing { get; private set; }

        public void CloseDialog()
        {
            IsDialogShowing = false;
        }

        public void ShowDialog()
        {
            IsDialogShowing = true;
        }
    }
}
