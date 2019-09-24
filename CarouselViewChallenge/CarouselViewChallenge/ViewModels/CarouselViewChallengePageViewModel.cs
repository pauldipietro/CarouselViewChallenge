using CarouselViewChallenge.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace CarouselViewChallenge.ViewModels
{
    class CarouselViewChallengePageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<StoryCard> _storyCards;
        public ObservableCollection<StoryCard> StoryCards
        {
            get
            {
                return _storyCards;
            }
            set
            {
                if (_storyCards != value)
                {
                    _storyCards = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("StoryCards"));
                }
            }
        }

        private void OnPropertyChanged(PropertyChangedEventArgs eventArgs)
        {
            PropertyChanged?.Invoke(this, eventArgs);
        }
    }
}
