using Acr.UserDialogs;

namespace CarouselViewChallenge.Helpers
{
    public static class ToastHelper
    {
        public static void Toast(string message)
        {
            ToastConfig toastConfig = new ToastConfig(message);
            toastConfig.SetDuration(2500);
            UserDialogs.Instance.Toast(toastConfig);
        }
    }
}
