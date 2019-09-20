using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace CarouselViewChallenge.ViewModels
{
    public class CarouselViewTwoViewModel : INotifyPropertyChanged
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

        public ObservableCollection<string> LargeShipList { get; set; }

        public ObservableCollection<string> SmallShipList { get; set; }

        public string _ccBalance;
        public string CCBalance
        {
            get { return _ccBalance; }
            private set
            {
                if (_ccBalance != value)
                {
                    _ccBalance = value;
                    OnPropertyChanged(nameof(CCBalance));
                }
            }
        }

        private string _cycle;
        public string Cycle
        {
            get { return _cycle; }
            protected set
            {
                if (_cycle != value)
                {
                    _cycle = value;
                    OnPropertyChanged(nameof(Cycle));
                }
            }
        }

        private DateTime _lastUpdated;
        public DateTime LastUpdated
        {
            get { return _lastUpdated; }
            private set
            {
                if (_lastUpdated != value)
                {
                    _lastUpdated = value;
                    OnPropertyChanged(nameof(LastUpdated));
                }
            }
        }

        public CarouselViewTwoViewModel()
        {
            LargeShipList = new ObservableCollection<string>
            {
                "First Large Item",
                "Second Large Item",
                "Third Large Item",
                "Fourth Large Item",
                "Fifth Large Item",
                "Sixth Large Item",
                "Seventh Large Item",
                "Eighth Large Item",
                "Ninth Large Item",
                "Tenth Large Item"
            };
            SmallShipList = new ObservableCollection<string>
            {
                "First Small Item",
                "Second Small Item",
                "Third Small Item",
                "Fourth Small Item",
                "Fifth Small Item",
                "Sixth Small Item",
                "Seventh Small Item",
                "Eighth Small Item",
                "Ninth Small Item",
                "Tenth Small Item"
            };
            Cycle = "Cycle 150";
            CCBalance = "853 CC";
            LastUpdated = DateTime.Now;
        }
    }
}
