using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using CarouselViewChallenge.Models;
using CarouselViewChallenge.Services;
using Xamarin.Forms;

namespace CarouselViewChallenge.ViewModels
{
    public class CarouselViewChallengePageViewModel : INotifyPropertyChanged
    {
        public FakeMonsterService _monsterService;
        private ObservableCollection<string> _startingLetters;
        private List<Monster> _monsters;
        private ObservableCollection<Monster> _filteredMonsters;

        public CarouselViewChallengePageViewModel()
        {
            StartingLetters = new ObservableCollection<string>()
            {
                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N",
                "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
            };

            _monsterService = new FakeMonsterService();
            _monsters = _monsterService.GetMonsters();
            FilteredMonsters = new ObservableCollection<Monster>(_monsters);

            FilterCommand = new Command<string>(async (letter) => await FilterExecute(letter));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand FilterCommand { get; }

        private async Task FilterExecute(string letter)
        {
            var monsters = _monsters.Where(x => x.StartingLetter.Equals(letter, StringComparison.OrdinalIgnoreCase));
            FilteredMonsters.Clear();
            FilteredMonsters = new ObservableCollection<Monster>(monsters);
        }

        public ObservableCollection<string> StartingLetters
        {
            get => _startingLetters;
            set
            {
                if (_startingLetters != value)
                {
                    _startingLetters = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("StartingLetters"));
                }
            }
        }

        public ObservableCollection<Monster> FilteredMonsters
        {
            get => _filteredMonsters;
            set
            {
                if (_filteredMonsters != value)
                {
                    _filteredMonsters = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("FilteredMonsters"));
                }
            }
        }

        private void OnPropertyChanged(PropertyChangedEventArgs eventArgs)
        {
            PropertyChanged?.Invoke(this, eventArgs);
        }
    }
}