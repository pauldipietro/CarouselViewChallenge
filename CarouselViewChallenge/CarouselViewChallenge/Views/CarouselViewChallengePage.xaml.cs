using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarouselViewChallenge.Models;
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

            BindingContext = new CarouselViewChallengeViewModel
            {
                Destinations = new List<Destination>() {
                 new Destination
                 {
                     Title = "Ulun Danu Beratan Temple",
                     ImageUrl = "bali.jpg",
                     Rating = 4.4f,
                     Votes = 3829
                 },
                 new Destination
                 {
                     Title = "Isola d'Elba",
                     ImageUrl = "elba.jpg",
                     Rating = 4.9f,
                     Votes = 9783
                 }
                },
                Categories = new List<Category>()
                {
                    new Category
                    {
                        Color = Color.FromHex("#5d6dff"),
                        Name = "Art & Cultures",
                        Icon = " "
                    },
                    new Category
                    {
                        Color = Color.FromHex("#37d2ff"),
                        Name = "Adventure",
                        Icon = " "
                    },
                    new Category
                    {
                        Color = Color.FromHex("#2687ee"),
                        Name = "Some other thing",
                        Icon = " "
                    }
                }
            };
        }
    }
}