using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace CarouselViewChallenge.ViewModels
{
    public class SliderPage
    {
        public string Icon { get; set; }
        public string Header { get; set; }
        public string Text { get; set; }
        public string BackgroundColor { get; set; }
    };

    public class CarouselViewChallengeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<SliderPage> _sliders;
        public ObservableCollection<SliderPage> Sliders
        {
            get => _sliders;
            set
            {
                if (_sliders != value)
                {
                    _sliders = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Sliders"));
                }
            }
        }

        private int _index;
        public int Index
        {
            get => _index;
            set
            {
                if (_index != value)
                {
                    _index = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Index"));

                    TextLabel = (_index + 1 == Sliders.Count) ? "DONE" : "NEXT";
                    OnPropertyChanged(new PropertyChangedEventArgs("TextLabel"));
                }
            }
        }

        public string TextLabel { get; set; }

        public CarouselViewChallengeViewModel()
        {
            Sliders = new ObservableCollection<SliderPage>();
            TextLabel = "NEXT";
        }

        private void OnPropertyChanged(PropertyChangedEventArgs eventArgs)
        {
            PropertyChanged?.Invoke(this, eventArgs);
        }
    }
}
