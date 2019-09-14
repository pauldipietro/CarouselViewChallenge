using CarouselViewChallenge.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselViewChallengePage : ContentPage
    {
        private readonly CarouselViewChallengeViewModel vm = new CarouselViewChallengeViewModel();

        public CarouselViewChallengePage()
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}