using System.Collections.ObjectModel;
using CarouselViewChallenge.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselViewChallengePage : ContentPage
    {
        public CarouselViewChallengePageViewModel vm { get; set; }

        public CarouselViewChallengePage()
        {
            InitializeComponent();
            vm = new CarouselViewChallengePageViewModel();
            SetupData();
        }

        private void SetupData()
        {
            vm.StartingLetters = new ObservableCollection<string>()
            {
                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N",
                "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
            };
            vm.SelectedLetter = "H";
        }
    }
}