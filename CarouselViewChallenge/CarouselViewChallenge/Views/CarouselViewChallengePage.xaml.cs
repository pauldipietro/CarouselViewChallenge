using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselViewChallengePage : ContentPage
    {
        public CarouselViewChallengePage()
        {
            InitializeComponent();

            this.BindingContext = new
            {
                Items = new List<object>
                {
                    new { Lottie = "money.json", Title="Besoin de monnaie ou d'espèces ?", Subtitle = "Passez votre commande personnalisée en 2 minutes" },
                     new { Lottie = "pin.json", Title="Livré là où vous voulez", Subtitle = "Dans votre banque habituelle ou directement sur votre lieu d'activité" },
                     new { Lottie = "folder.json", Title="Assurez la traçabilité de vos volis", Subtitle = "Suivez à tout moment vos commandes en cours et passées" },
                     new { Lottie = "lock.json", Title="Déposez en toute sécurité", Subtitle = "Préparez votre dépôt au calme chez vous, vous n'avez plus qu'à scanner pour déposer vos espèces." },
                }
            };
        }
    }
}