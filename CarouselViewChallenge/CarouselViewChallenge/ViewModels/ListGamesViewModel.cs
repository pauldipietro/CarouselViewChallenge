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
        ObservableCollection<CarouselItem> games;
        public ObservableCollection<CarouselItem> Games
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
            Games = new ObservableCollection<CarouselItem>();


            Games.Add(new CarouselItem
            {
                Name = "We Happy Few",
                Img = @"https://pbs.twimg.com/profile_images/897864241566294017/QCYJPjVX_400x400.jpg",
                Platform = "Steam",
                Genre = "Stealth",
                Price = "18.77€",
            });
            Games.Add(new CarouselItem
            {
                Name = "Anno 1800",
                Img = @"https://s3.gaming-cdn.com/images/products/2249/271x377/anno-1800-cover.jpg",
                Platform = "Uplay",
                Genre = "Strategy",
                Price = "41.69€",
            });
            Games.Add(new CarouselItem
            {
                Name = "Quantum Break",
                Img = @"https://s1.qwant.com/thumbr/0x380/8/e/33fd35a2e5b3ef2ac390ac1440b0a17d8f4c17a12bdd1b4cdad5eb6bfc1c28/quantum-break-cover.jpg?u=http%3A%2F%2Fgamepreorders.com%2Fwp-content%2Fuploads%2F2016%2F02%2Fquantum-break-cover.jpg&q=0&b=1&p=0&a=1",
                Platform = "Microsoft store",
                Genre = "Narrative",
                Price = "10.51€",
            });
            Games.Add(new CarouselItem
            {
                Name = "Sherlock Holmes: The Devil's Daughter",
                Img = @"https://s2.qwant.com/thumbr/0x380/6/f/d59c12435321285615b8193a2eb980646956ef51ba05fbc96df12920e45f76/3003937-xb1_esrb_3d.jpg?u=https%3A%2F%2Fstatic.gamespot.com%2Fuploads%2Fscale_medium%2F1197%2F11970954%2F3003937-xb1_esrb_3d.jpg&q=0&b=1&p=0&a=1",
                Platform = "Origin",
                Genre = "Detective",
                Price = "8.45€",
            });
        }
    }
}
