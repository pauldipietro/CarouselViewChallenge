using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CarouselViewChallenge.Annotations;
using CarouselViewChallenge.Models;
using CarouselViewChallenge.Views.Cards;
using Xamarin.Forms;

namespace CarouselViewChallenge.ViewModels
{
    public class ChallangeViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<MainCard> MainCards { get; set; }
        public ObservableCollection<Card> SmallCards { get; set; }

        public ChallangeViewModel()
        {
            MainCards = new ObservableCollection<MainCard>
            {
                new MainCard
                {
                    iconHex = "\uf3d1",
                    Header = "Saldo",
                    Content = new CardSaldo()
                },
                new MainCard
                {
                    iconHex = "\uf0ca",
                    Header = "Últimos Lançamentos",
                    Content = new CardUltimosLancamentos()
                },
            };
            SmallCards = new ObservableCollection<Card>
            {
                new Card
                {
                    iconHex = "\uf362",
                    Header = "Transferências"
                },
                new Card
                {
                    iconHex = "\uf0b1",
                    Header = "Fidelidade"
                },
                new Card
                {
                    iconHex = "\uf688",
                    Header = "Reemissão de Comprovante"
                },
                new Card
                {
                    iconHex = "\uf53d",
                    Header = "Extrato"
                },
                new Card
                {
                    iconHex = "\uf02a",
                    Header = "Pagento de Boleto"
                }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}