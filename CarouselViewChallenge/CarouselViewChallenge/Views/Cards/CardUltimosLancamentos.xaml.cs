using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarouselViewChallenge.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselViewChallenge.Views.Cards
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CardUltimosLancamentos : ContentView
    {
        public CardUltimosLancamentos()
        {
            InitializeComponent();
            BindingContext = new UltimosLancamentosViewModel();

        }
    }
}