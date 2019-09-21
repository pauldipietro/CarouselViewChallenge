using CarouselViewChallenge.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselViewTwoPage : ContentPage
    {
        private readonly CarouselViewTwoViewModel vm = new CarouselViewTwoViewModel();

        public CarouselViewTwoPage()
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}