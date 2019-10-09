using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace CarouselViewChallenge.ViewModels
{
    public class Sample
    {
        public string Title { get; set; }
        public string Image { get; set; }
    }
    public class CarouselModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Sample> _sections;
        public ObservableCollection<Sample> Sections
        {
            get
            {
                return _sections;
            }
            set
            {
                if (_sections != value)
                {
                    _sections = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Sections"));
                }
            }
        }

        private void OnPropertyChanged(PropertyChangedEventArgs eventArgs)
        {
            PropertyChanged?.Invoke(this, eventArgs);
        }
    }
}
