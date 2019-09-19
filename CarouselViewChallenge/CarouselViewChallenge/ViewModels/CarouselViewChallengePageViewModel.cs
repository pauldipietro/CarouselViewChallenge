using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using CarouselViewChallenge.Models;
using CarouselViewChallenge.Services;

namespace CarouselViewChallenge.ViewModels
{
    public class CarouselViewChallengePageViewModel : INotifyPropertyChanged
    {
        public FakeMonsterService _monsterService;
        private ObservableCollection<string> _startingLetters;

        public CarouselViewChallengePageViewModel()
        {
            StartingLetters = new ObservableCollection<string>()
            {
                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N",
                "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
            };

            //_monsterService = new FakeMonsterService();
            //Monsters = _monsterService.GetMonsters();
        }

        public event PropertyChangedEventHandler PropertyChanged;


        public ObservableCollection<string> StartingLetters
        {
            get
            {
                return _startingLetters;
            }
            set
            {
                if (_startingLetters != value)
                {
                    _startingLetters = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("StartingLetters"));
                }
            }
        }

        public List<Monster> Monsters { get; }

        private void OnPropertyChanged(PropertyChangedEventArgs eventArgs)
        {
            PropertyChanged?.Invoke(this, eventArgs);
        }
    }
}