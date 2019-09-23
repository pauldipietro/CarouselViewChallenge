using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace CarouselViewChallenge.ViewModels
{
    public class LocationOfInterest
    {
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public FormattedString Content { get; set; }
    };

    public class CarouselViewChallengePageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<LocationOfInterest> _loi;
        public ObservableCollection<LocationOfInterest> LocationsOfInterest
        {
            get
            {
                return _loi;
            }
            set
            {
                if (_loi != value)
                {
                    _loi = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("LocationsOfInterest"));
                }
            }
        }

        private void OnPropertyChanged(PropertyChangedEventArgs eventArgs)
        {
            PropertyChanged?.Invoke(this, eventArgs);
        }
    }
}
