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
                Name = "Anno 1800",
                Img = @"https://s3.gaming-cdn.com/images/products/2249/271x377/anno-1800-cover.jpg",
                Platform = "Uplay"
            });

            Games.Add(new Game
            {
                Name = "We Happy Few",
                Img = @"https://pbs.twimg.com/profile_images/897864241566294017/QCYJPjVX_400x400.jpg",
                Platform = "Steam"
            });
            Games.Add(new Game
            {
                Name = "FIFA 19",
                Img = @"https://cdn.gamer-network.net/2018/usgamer/FIFA-19-ronaldo.jpg",
                Platform = "Origin"
            });
        }
    }
}
