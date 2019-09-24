using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace CarouselViewChallenge.ViewModels
{
    public class CarouselViewChallengeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<LsrHeader> _cards;
        public ObservableCollection<LsrHeader> Cards
        {
            get
            {
                return _cards;
            }
            set
            {
                if (_cards != value)
                {
                    _cards = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Cards"));
                }
            }
        }

        private void OnPropertyChanged(PropertyChangedEventArgs eventArgs)
        {
            PropertyChanged?.Invoke(this, eventArgs);
        }

    }

    public class LsrDetails
    {
        public string Icon { get; set; }
        public string Description { get; set; }

    }

    public class LsrHeader
    {
        public string Header { get; set; }
        public List<LsrDetails> CardDetails { get; set; }
    }
}