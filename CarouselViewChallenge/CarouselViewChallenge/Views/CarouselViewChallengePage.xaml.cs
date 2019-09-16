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
            BindingContext = new MoviesViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            if (!(BindingContext is MoviesViewModel viewModel)) return;

            await viewModel.InitializeAsync();
        }
    }
}