using System.Collections.Generic;
using System.ComponentModel;
using CarouselViewChallenge.Models;
using CarouselViewChallenge.Services;

namespace CarouselViewChallenge.ViewModels
{
    public class CarouselViewChallengePageViewModel : INotifyPropertyChanged
    {
        public FakeMonsterService _monsterService;

        public CarouselViewChallengePageViewModel()
        {
            LetterList = new List<string>()
            {
                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N",
                "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
            };

            _monsterService = new FakeMonsterService();
            Monsters = _monsterService.GetMonsters();
        }

        public event PropertyChangedEventHandler PropertyChanged;


        public List<string> LetterList { get; }
        public List<Monster> Monsters { get; }

        private void OnPropertyChanged(PropertyChangedEventArgs eventArgs)
        {
            PropertyChanged?.Invoke(this, eventArgs);
        }
    }
}