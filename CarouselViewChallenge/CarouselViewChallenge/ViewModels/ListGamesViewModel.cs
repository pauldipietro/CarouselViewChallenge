using ColumbiaMobileProject.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ColumbiaMobileProject.ViewModels
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
                Name = "Watchdog",
                Img = @"http://static2.gamespot.com/uploads/scale_medium/1197/11970954/2309326-watchdogs.jpg",
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
