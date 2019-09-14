using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CarouselViewChallenge.ViewModels
{
    public class CarouselViewChallengeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            var changed = PropertyChanged;
            if (changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public ObservableCollection<string> GalNetNewsList { get; set; }

        private DateTime _galnetLastUpdated;
        public DateTime GalNetLastUpdated
        {
            get { return _galnetLastUpdated; }
            private set
            {
                if (_galnetLastUpdated != value)
                {
                    _galnetLastUpdated = value;
                    OnPropertyChanged(nameof(GalNetLastUpdated));
                }
            }
        }

        public CarouselViewChallengeViewModel()
        {
            GalNetNewsList = new ObservableCollection<string>
            {
                "First Item",
                "Second Item",
                "Third Item"
            };
            GalNetLastUpdated = DateTime.Now;
        }
    }
}
