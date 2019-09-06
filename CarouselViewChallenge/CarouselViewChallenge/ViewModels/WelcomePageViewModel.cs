using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace CarouselViewChallenge.ViewModels
{
    public class Section
    {
        public string Header { get; set; }
        public FormattedString Content { get; set; }
        public string Emoji { get; set; }
    };

    public class WelcomePageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Section> _sections;
        public ObservableCollection<Section> Sections
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
