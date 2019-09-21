using CarouselViewChallenge.Models;
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

        public ObservableCollection<FortItem> LargeShipList { get; set; }

        public ObservableCollection<FortItem> SmallShipList { get; set; }

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
            // fake data
            LargeShipList = new ObservableCollection<FortItem>
            {
                new FortItem("Xinca", "101 ly", "Station", "343 ls", "independent"),
                new FortItem("Ngarawe", "86 ly", "Station", "35 ls", "empire"),
                new FortItem("Yanerones", "115 ly", "Planetary", "42 ls", "empire"),
                new FortItem("Damoorai", "86 ly", "Station", "1,324 ls", "empire"),
                new FortItem("Ostyat", "117 ly", "Station", "41 ls", "independent"),
                new FortItem("Itzamni", "64 ly", "Planetary", "158,992 ls", "empire"),
                new FortItem("HIP 20524", "53 ly", "Planetary", "2,192 ls", "empire"),
                new FortItem("Amenta", "47 ly", "Station", "236 ls", "empire"),
                new FortItem("27 G. Caeli", "54 ly", "Outpost", "3,145 ls", "independent"),
                new FortItem("Kappa Reticuli", "81 ly", "Planetary", "350 ls", "federation")
            };
            SmallShipList = new ObservableCollection<FortItem>
            {
                new FortItem("Lutni", "30 ly", "Planetary", "21 ls", "empire"),
                new FortItem("AB Pictoris", "41 ly", "Station", "1,739 ls", "empire"),
                new FortItem("HIP 21778", "66 ly", "Outpost", "181 ls", "independent"),
                new FortItem("Biliri", "68 ly", "Outpost", "181 ls", "empire"),
                new FortItem("Ngarawe", "86 ly", "Station", "35 ls", "empire"),
                new FortItem("Lopocares", "125 ly", "Outpost", "329 ls", "federation"),
                new FortItem("Carverda", "41 ly", "Station", "727 ls", "empire"),
                new FortItem("HIP 32812", "62 ly", "Outpost", "1,753 ls", "federation"),
                new FortItem("Tiburnat", "53 ly", "Planetary", "2,192 ls", "empire"),
                new FortItem("Ju Shiva", "47 ly", "Station", "236 ls", "independent"),
            };
            Cycle = "Cycle 150";
            CCBalance = "853 CC";
            LastUpdated = DateTime.Now;
        }
    }
}
