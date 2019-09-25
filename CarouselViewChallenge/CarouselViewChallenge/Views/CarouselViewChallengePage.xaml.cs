
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CarouselViewChallenge.ViewModels;

namespace CarouselViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselViewChallengePage : ContentPage
    {
        public CarouselViewChallengePage()
        {
            InitializeComponent();
            BindingContext = new CarouselViewChallengeViewModel();
        }
    }
}