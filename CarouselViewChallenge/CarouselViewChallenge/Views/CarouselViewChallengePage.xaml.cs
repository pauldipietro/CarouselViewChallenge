using System.Collections.ObjectModel;
using CarouselViewChallenge.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselViewChallengePage : ContentPage
    {
        public CarouselViewChallengePageViewModel Vm { get; set; }

        public CarouselViewChallengePage()
        {
            InitializeComponent();
            Vm = new CarouselViewChallengePageViewModel();
            BindingContext = Vm;
        }
    }
}