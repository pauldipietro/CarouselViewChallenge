using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CarouselViewChallenge.Annotations;
using CarouselViewChallenge.Models;
using Xamarin.Forms;

namespace CarouselViewChallenge.ViewModels
{
    public class ChallangeViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<MainCard> MainCards { get; set; }
        public ObservableCollection<Card> SmallCards { get; set; }

        public ChallangeViewModel()
        {
            MainCards = new ObservableCollection<MainCard>();
            SmallCards = new ObservableCollection<Card>();

            var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                var main = new MainCard
                {
                    iconHex = "ico",
                    Header = random.Next().ToString(),
                    Content = new StackLayout()
                };
                MainCards.Add(main);
                SmallCards.Add(main);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}