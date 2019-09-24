using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarouselViewChallenge.Models;
using CarouselViewChallenge.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.PancakeView;
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
            var carousel = (CarouselView)sender;
            var carouselItems = carousel.ItemsSource.Cast<object>().ToList();

            // Get index of every visible Items
            var currentIndex = e.CenterItemIndex;
            var lastIndex = e.LastVisibleItemIndex;
            var firstIndex = e.FirstVisibleItemIndex;

            // Get all these items
            var lastItem = (CarouselItem)carouselItems[lastIndex];
            var currentItem = (CarouselItem)carouselItems[currentIndex];
            var firstItem = (CarouselItem)carouselItems[firstIndex];

            // Constant resize
            const double heightResize = 500;
            const double heightBase = 450;
            const double marginBase = 15;
            const double marginResize = 5;


            // Transition forward
            if (currentIndex == firstIndex && currentIndex != 0)
            {
                lastItem.Height = heightResize;
                lastItem.Margin = marginResize;
                firstItem.Height = heightBase;
                firstItem.Margin = marginBase;
            }
            // Transition backward
            else if (lastIndex == currentIndex && currentIndex != 0)
            {
                firstItem.Height = heightResize;
                firstItem.Margin = marginResize;
                lastItem.Height = heightBase;
                lastItem.Margin = marginBase;
            }
            // No transition
            else
            {
                firstItem.Height = heightBase;
                firstItem.Margin = marginResize;
                currentItem.Height = heightResize;
                currentItem.Margin = marginResize;
                lastItem.Height = heightBase;
                lastItem.Margin = marginBase;
            }
        }
    }
}