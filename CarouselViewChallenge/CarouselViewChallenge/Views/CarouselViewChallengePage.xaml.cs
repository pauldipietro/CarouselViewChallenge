using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            // Bind the view with viewmodel
            BindingContext = new ListGamesViewModel();
        }

        private async void CarouselView_Focused(object sender, FocusEventArgs e)
        {
            
        }
    }
}