using CarouselViewChallenge.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselViewChallengePage : ContentPage
    {
        public CaroselViewChallengePageViewModel ViewModel { get; set; }
        public CarouselViewChallengePage()
        {
            InitializeComponent();

            ViewModel = new CaroselViewChallengePageViewModel();

            BindingContext = ViewModel;
        }
    }
}