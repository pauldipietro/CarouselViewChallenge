using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using CarouselViewChallenge.Models;

namespace CarouselViewChallenge.ViewModels
{
    public class RickAndMorthyViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Character> _characters;

        public ObservableCollection<Character> Characters
        {
            get
            {
                return _characters;
            }
            set
            {
                if (_characters != value)
                {
                    _characters = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Characters"));
                }
            }
        }

        private void OnPropertyChanged(PropertyChangedEventArgs eventArgs)
        {
            PropertyChanged?.Invoke(this, eventArgs);
        }
    }
}
