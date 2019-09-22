using CarouselViewChallenge.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CarouselViewChallenge.ViewModels
{
    class ListGamesViewModel : BaseViewModel
    {
        Game selectedGame;
        public Game SelectedGame
        {
            get { return selectedGame; }
            set
            {
                selectedGame = value;
                OnPropertyChanged();
            }
        }
        //get a collection of Game Model
        ObservableCollection<Game> games;
        public ObservableCollection<Game> Games
        {
            get { return games; }
            set
            {
                games = value;
                OnPropertyChanged();
            }
        }

        public ListGamesViewModel()
        {
            Games = new ObservableCollection<Game>();


            Games.Add(new Game
            {
                Name = "We Happy Few",
                Img = @"https://pbs.twimg.com/profile_images/897864241566294017/QCYJPjVX_400x400.jpg",
                Platform = "Steam",
                Price = "18.77€",
            });
            Games.Add(new Game
            {
                Name = "Anno 1800",
                Img = @"https://s3.gaming-cdn.com/images/products/2249/271x377/anno-1800-cover.jpg",
                Platform = "Uplay",
                Price = "41.69€",
            });
            Games.Add(new Game
            {
                Name = "Quantum Break",
                Img = @"https://s1.qwant.com/thumbr/0x380/8/e/33fd35a2e5b3ef2ac390ac1440b0a17d8f4c17a12bdd1b4cdad5eb6bfc1c28/quantum-break-cover.jpg?u=http%3A%2F%2Fgamepreorders.com%2Fwp-content%2Fuploads%2F2016%2F02%2Fquantum-break-cover.jpg&q=0&b=1&p=0&a=1",
                Platform = "Origin",
                Price = "10.51€",
            });
        }
    }
}
