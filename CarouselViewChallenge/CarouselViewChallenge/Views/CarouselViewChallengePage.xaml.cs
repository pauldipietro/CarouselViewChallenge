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
        private CarouselViewChallengeViewModel viewModel;
        private int tapCount = 0;
        public CarouselViewChallengePage()
        {
            InitializeComponent();
            viewModel = new CarouselViewChallengeViewModel();
            this.Carousel.BindingContext = viewModel;
        }

        protected async override void OnAppearing()
        {
            await viewModel.ExecuteLoadItemsCommand();
        }

        void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            tapCount++;
            var labelSender = (Label)sender;
            
            if (tapCount % 2 == 0)
            {
                labelSender.Opacity = 0.50;
            }                
        }
    }    
}