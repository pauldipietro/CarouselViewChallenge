using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace CarouselViewChallenge.ViewModels
{
    public class CarouselViewModel : BaseViewModel
    {
        public CarouselViewModel()
        {
            _cities = new ObservableCollection<City>
            {
                new City
                {
                    CityImage = "London",
                    CityName = "London",
                    Country = "UK",
                    IsFavorite = false,
                },
                new City
                {
                    CityImage = "Zurich",
                    CityName = "Zurich",
                    Country = "Switzerland",
                    IsFavorite = true,
                },
                new City
                {
                    CityImage = "Seattle",
                    CityName = "Seattle",
                    Country = "USA",
                    IsFavorite = false,
                },
            };
        }

        private ObservableCollection<City> _cities;
        public ObservableCollection<City> Cities
        {
            get
            {
                return _cities;
            }
            set
            {
                if (_cities != value)
                {
                    _cities = value;
                    OnPropertyChanged(nameof(Cities));
                }
            }
        }
    }

    public class City : BaseViewModel
    {
        private bool _isFavorite;

        public City()
        {
            ChangeFavoriteStatus = new Command(() => IsFavorite = !IsFavorite);
        }

        public string CityImage { get; set; }
        public string CityName { get; set; }
        public string Country { get; set; }
        public string FavoriteIcon => IsFavorite ? "\uf2d1" : "\uf2d5";
        public bool IsFavorite { get => _isFavorite; 
            set 
            { 
                _isFavorite = value;
                OnPropertyChanged(nameof(FavoriteIcon));
            } 
        }

        public Command ChangeFavoriteStatus { get; set; }
    }
}
