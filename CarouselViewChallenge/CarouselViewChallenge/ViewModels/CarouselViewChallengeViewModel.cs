using CarouselViewChallenge.Models;
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

        private ObservableCollection<Card> _cards;
        public ObservableCollection<Card> Cards
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
}
