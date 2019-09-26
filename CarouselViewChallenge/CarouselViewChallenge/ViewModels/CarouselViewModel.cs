using System;
using System.Collections.Generic;
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
            Index = "1";
        }

        private ObservableCollection<City> _cities;
        private City _currentCity;
        private string _index;

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

        public string Index
        {
            get => _index; set
            {
                _index = value;

                OnPropertyChanged(nameof(Index));
            }
        }

        public City CurrentCity
        {
            get
            {
                return _currentCity;
            }
            set
            {
                _currentCity = value;
                var index = Cities.IndexOf(_currentCity);
                Index = (index + 1).ToString();
                OnPropertyChanged(nameof(CurrentCity));
            }
        }
    }

    public class City : BaseViewModel, IEquatable<City>
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
        public bool IsFavorite
        {
            get => _isFavorite;
            set
            {
                _isFavorite = value;
                OnPropertyChanged(nameof(FavoriteIcon));
            }
        }

        public Command ChangeFavoriteStatus { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as City);
        }

        public bool Equals(City other)
        {
            return other != null &&
                   CityImage == other.CityImage &&
                   CityName == other.CityName &&
                   Country == other.Country &&
                   IsFavorite == other.IsFavorite &&
                   EqualityComparer<Command>.Default.Equals(ChangeFavoriteStatus, other.ChangeFavoriteStatus);
        }

        public override int GetHashCode()
        {
            var hashCode = -870885539;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CityImage);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CityName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Country);
            hashCode = hashCode * -1521134295 + IsFavorite.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Command>.Default.GetHashCode(ChangeFavoriteStatus);
            return hashCode;
        }
    }
}
