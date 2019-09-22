using CarouselViewChallenge.Models;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace CarouselViewChallenge.ViewModels
{
    class CarouselViewChallengePageViewModel : BindableObject
    {
        private ObservableCollection<Carouselitem> _drinks;

        public CarouselViewChallengePageViewModel()
        {
            LoadDrinks();
        }

        public ObservableCollection<Carouselitem> Drinks
        {
            get { return _drinks; }
            set
            {
                _drinks = value;
                OnPropertyChanged();
            }
        }

        void LoadDrinks()
        {
            Drinks = new ObservableCollection<Carouselitem>() {
                 new Carouselitem { Image="coffee.png", Title = "BRAZILIAN COFFEE", Color= Color.Maroon, Price =3.5, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." },
                 new Carouselitem { Image="marshmallows.png", Title = "HOT CHOCOLATE WITH MARSHMALLOWS", Color= Color.Wheat, Price = 8, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." },
                 new Carouselitem { Image="plant.png", Title = "MILK WITH MINT", Color= Color.Green, Price = 7.99, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." },
                 new Carouselitem { Image="strawberry.png", Title = "STRAWBERRY MILK", Color= Color.Red, Price = 6.5, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." }
            };
        }
    }
}