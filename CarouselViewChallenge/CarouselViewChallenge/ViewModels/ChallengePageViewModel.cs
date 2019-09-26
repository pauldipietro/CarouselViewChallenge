using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using CarouselViewChallenge.Models;
using CarouselViewChallenge.Services;

namespace CarouselViewChallenge.ViewModels
{
    public class ChallengePageViewModel : BaseViewModel
    {
        private ObservableCollection<CityWeather> cities;

        public ObservableCollection<CityWeather> Cities
        {
            get { return cities; }
            set { cities = value; OnPropertyChanged(); }
        }

        private List<CityWeather> list;

        private bool isBusy;

        public bool IsBusy
        {
            get { return isBusy; }
            set { isBusy = value; OnPropertyChanged(); }
        }

        public void LoadData()
        {
            IsBusy = true;

            list = WeatherService.GetWeather();
            Cities = new ObservableCollection<CityWeather>(list);

            IsBusy = false;
        }

    }
}
