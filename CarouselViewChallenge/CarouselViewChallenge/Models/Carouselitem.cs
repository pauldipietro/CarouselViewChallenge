using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CarouselViewChallenge.Models
{
    public class Carouselitem : Drink, INotifyPropertyChanged
    {
        private double _position;
        private double _rotation;
        private double _scale;

        public Carouselitem()
        {
            Scale = 1;
        }

        public double Position
        {
            get { return _position; }
            set
            {
                _position = value;
                OnPropertyChanged();
            }
        }

        public double Rotation
        {
            get { return _rotation; }
            set
            {
                _rotation = value;
                OnPropertyChanged();
            }
        }

        public double Scale
        {
            get { return _scale; }
            set
            {
                _scale = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}