using CarouselViewChallenge.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselViewChallengePage : ContentPage
    {
        public CarouselViewChallengeViewModel viewModel { get; set; }

        public CarouselViewChallengePage()
        {
            InitializeComponent();
            viewModel = new CarouselViewChallengeViewModel();
            viewModel.Sliders.Add(new SliderPage()
            {
                Icon = "\uF684",  //"\uF25A",
                Header = "Hello Food!",
                Text = "The easiest way to order food from your favourite restaurant!",
                BackgroundColor = "#F64C73"
            });
            viewModel.Sliders.Add(new SliderPage()
            {
                Icon = "\uF516",
                Header = "Movie Tickets",
                Text = "Book movie tickets for your family and friends!",
                BackgroundColor = "#20D2BB"
            });
            viewModel.Sliders.Add(new SliderPage()
            {
                Icon = "\uFCCE",
                Header = "Great Discounts",
                Text = "Best discounts on every single service we offer!",
                BackgroundColor = "#3395FF"
            });
            viewModel.Sliders.Add(new SliderPage()
            {
                Icon = "\uF01D",
                Header = "World Travel",
                Text = "Book tickets of any transportation and travel the world!",
                BackgroundColor = "#C873F4"
            });
            BindingContext = viewModel;
        }

        private void Carousel_PositionChanged(object sender, PositionChangedEventArgs e)
        {
            viewModel.Index = e.CurrentPosition;

            bv0.BackgroundColor = viewModel.Index == 0 ? Color.FromHex("#FFFFFFFF") : Color.FromHex("#7CFFFFFF");
            bv1.BackgroundColor = viewModel.Index == 1 ? Color.FromHex("#FFFFFFFF") : Color.FromHex("#7CFFFFFF");
            bv2.BackgroundColor = viewModel.Index == 2 ? Color.FromHex("#FFFFFFFF") : Color.FromHex("#7CFFFFFF");
            bv3.BackgroundColor = viewModel.Index == 3 ? Color.FromHex("#FFFFFFFF") : Color.FromHex("#7CFFFFFF");
        }
        private void Next_Tapped(object sender, EventArgs e)
        {
            if (carousel.Position + 1 < viewModel.Sliders.Count)
                carousel.Position += 1;
        }
    }
}