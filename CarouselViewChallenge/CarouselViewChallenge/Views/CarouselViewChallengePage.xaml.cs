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
        private CarouselViewChallengePageViewModel _viewModel;

        public CarouselViewChallengePage()
        {
            InitializeComponent();
            _viewModel = new CarouselViewChallengePageViewModel();
            BindingContext = _viewModel;
        }
    }
}