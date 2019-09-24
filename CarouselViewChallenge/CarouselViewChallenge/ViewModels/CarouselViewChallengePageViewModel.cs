using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CarouselViewChallenge.ViewModels
{
    class CarouselViewChallengePageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(PropertyChangedEventArgs eventArgs)
        {
            PropertyChanged?.Invoke(this, eventArgs);
        }
    }
}
