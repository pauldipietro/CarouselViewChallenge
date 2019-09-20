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

        private string _dotSections;
        public string DotSections
        {
            get
            {
                return _dotSections;
            }
            set
            {
                if (_dotSections != value)
                {
                    _dotSections = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("DotSections"));
                }
            }
        }

        public void setCarrouselPosition(int pos)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < _sections.Count; i++)
            {
                if (i == pos)
                {
                    sb.Append("●");
                    continue;
                }
                sb.Append("○");
            }

            DotSections = sb.ToString();
        }

        private void OnPropertyChanged(PropertyChangedEventArgs eventArgs)
        {
            PropertyChanged?.Invoke(this, eventArgs);
        }

    }
}
