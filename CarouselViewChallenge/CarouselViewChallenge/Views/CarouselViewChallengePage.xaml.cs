using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarouselViewChallenge.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselViewChallengePage : ContentPage
    {
        public CarouselViewChallengePage()
        {
            InitializeComponent();

            // Bind the view with viewmodel
            BindingContext = new ListGamesViewModel();
        }

        private void CarouselView_Scrolled(object sender, ItemsViewScrolledEventArgs e)
        {
            //var carousel = (CarouselView)sender;
            //var carouselItems = carousel.ItemsSource.Cast<object>().ToList();
            //var currentIndex = e.CenterItemIndex;
            //var lastIndex = e.LastVisibleItemIndex;
            //var layout = carousel.ItemsLayout;
            //var adjust = Device.RuntimePlatform == Device.Android ? 3 : 1;

            //if (layout is ListItemsLayout listItemsLayout)
            //{
            //    if (listItemsLayout.Orientation == ItemsLayoutOrientation.Horizontal)
            //    {
            //        var carouselWidth = carousel.Width;
            //        var offset = (carouselWidth * (currentIndex + 1)) - (e.HorizontalOffset / adjust);
            //        var position = (offset * ParallaxOffset / carouselWidth) - ParallaxOffset;
            //        var scale = (offset * 100 / carouselWidth) / 100;

            //        var lastItem = carouselItems[lastIndex] as CarouselItem;
            //        lastItem.Position = position + ParallaxOffset;
            //        lastItem.Rotation = position / 2;
            //        lastItem.Scale = 1 - scale;

            //        var currentItem = carouselItems[currentIndex] as CarouselItem;
            //        currentItem.Position = position;
            //        currentItem.Rotation = position;
            //        currentItem.Scale = scale;
            //    }

            //    if (listItemsLayout.Orientation == ItemsLayoutOrientation.Vertical)
            //    {
            //        var carouselHeight = carousel.Height;
            //        var offset = (carouselHeight * (currentIndex + 1)) - (e.VerticalOffset / adjust);
            //        var position = (offset * ParallaxOffset / carouselHeight) - ParallaxOffset;
            //        var scale = offset * 100 / carouselHeight / 100;

            //        var lastItem = carouselItems[lastIndex] as CarouselItem;
            //        lastItem.Position = position + ParallaxOffset;
            //        lastItem.Rotation = position / 2;
            //        lastItem.Scale = 1 - scale;

            //        var currentItem = carouselItems[currentIndex] as CarouselItem;
            //        currentItem.Position = position;
            //        currentItem.Rotation = position;
            //        currentItem.Scale = scale;
            //    }
            //}
        }
    }
}