namespace CastleTours.Client
{
    public class DialogState
    {
        public bool ShowingDialog { get; private set; } = false;

        public void ShowDialog()
        {
            ShowingDialog = true;
        }

        public void CloseDialog()
        {
            ShowingDialog = false;
        }
    }
}
