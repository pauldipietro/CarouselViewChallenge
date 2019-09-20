using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarouselViewChallenge.Services;
using CarouselViewChallenge.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselViewChallengePage : ContentPage
    {
        private PlantsViewModel m_plantsViewModel;

        public CarouselViewChallengePage()
        {
            InitializeComponent();
            //Poor mans dependency injection
            BindingContext = m_plantsViewModel =  new PlantsViewModel(new FakePlantService());
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await m_plantsViewModel.Initialize();
        }
    }
}