using CarouselViewChallenge.Models;
using FFImageLoading.Forms;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Comic : ContentView
    {
        public Comic()
        {
            InitializeComponent();
        }

        private void CachedImage_Success(object sender, CachedImageEvents.SuccessEventArgs e)
        {
            if (!(sender is CachedImage cachedImage))
                return;
            Device.BeginInvokeOnMainThread(() =>
            {
                cachedImage.HeightRequest = e.ImageInformation.OriginalHeight;
            });
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (!(BindingContext is XkcdComic comic))
                return;
            if (string.IsNullOrEmpty(comic.Alt))
                return;

            await App.Current.MainPage.DisplayAlert(comic.Title, comic.Alt, "Close");
        }
    }
}