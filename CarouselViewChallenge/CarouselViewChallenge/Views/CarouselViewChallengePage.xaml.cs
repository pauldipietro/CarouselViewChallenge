using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using CarouselViewChallenge.ViewModels;

namespace CarouselViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselViewChallengePage : ContentPage
    {
        ChallengePageViewModel vm;

        public CarouselViewChallengePage()
        {
            InitializeComponent();

            vm = new ChallengePageViewModel();
            BindingContext = vm;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            vm.LoadData();
        }
    }
}