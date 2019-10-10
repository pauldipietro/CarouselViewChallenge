using CarouselViewChallenge.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselViewChallengePage : ContentPage
    {
        public CarouselModel VM { get; set; }
        public CarouselViewChallengePage()
        {
            InitializeComponent();
            VM = new CarouselModel();
            VM.Sections = new ObservableCollection<Sample>
            {
                new Sample
                {
                    Title = "Healthy LifeStyle Tips",
                    Image = "HealthyLifeStyle.png",

                },
                 new Sample
                {
                    Image = "Exercise.jpg",
                    Title = "1: Exercise Reguarly",
                },
                  new Sample
                {
                    Title = "2: Eat Healthy",
                    Image = "food.jpg",

                },
                  new Sample
                {
                    Title = "3: Drink Plenty of Water",
                    Image = "water.jpg",

                },
                  new Sample
                {
                    Title = "4: Reduce Stress",
                    Image = "stress.png",

                },
                
            BindingContext = VM;
        }

    }
}