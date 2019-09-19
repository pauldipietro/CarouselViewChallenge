using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;

namespace CarouselViewChallenge.ViewModels
{

    public class Pokedex
    {
        public Color TypeBackgroudColor { get; set; }
        public string ImagePokemon { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpAttack { get; set; }
        public int SpDefense { get; set; }
        public int Speed { get; set; }
    };

    public class CarouselViewChallengeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Pokedex> _pokedex;
        public ObservableCollection<Pokedex> Pokedex
        {
            get
            {
                return _pokedex;
            }
            set
            {
                if (_pokedex != value)
                {
                    _pokedex = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Pokedex"));
                }
            }
        }

        private void OnPropertyChanged(PropertyChangedEventArgs eventArgs)
        {
            PropertyChanged?.Invoke(this, eventArgs);
        }
    }
}
