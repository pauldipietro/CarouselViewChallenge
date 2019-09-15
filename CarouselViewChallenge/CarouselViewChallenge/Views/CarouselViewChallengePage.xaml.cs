using CarouselViewChallenge.Models;
using CarouselViewChallenge.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public CarouselViewChallengeViewModel VM { get; set; } = new CarouselViewChallengeViewModel();
        public CarouselViewChallengePage()
        {
            InitializeComponent();

            InitMockData();

            BindingContext = VM;
        }

        private void InitMockData()
        {
            VM.Cards = new ObservableCollection<Card>
            {
                new Card
                {
                    CardImage = "WishCard.PNG" ,
                    Title = "eGift Card Details",
                    Summary = "Redeem in-store or online",
                    Details = new List<Detail>
                    {
                        new Detail{Icon = "🚊", DetailTitle = "For In-Store redempption please enter:", DetailFact = "0119 8479 79"},
                        new Detail{Icon = "🥦", DetailTitle = "For Online redempption please enter:" , DetailFact = "0119 1124 8479 79"},
                        new Detail{Icon = "⚙", DetailTitle = "PIN:", DetailFact = "0119"},
                    }
                },
                new Card
                {
                    CardImage ="RewardCard.PNG" ,
                    Title = "Woolworths Rewards preference",
                    Summary = "Automatic Redemption",
                     Details = new List<Detail>
                    {
                        new Detail{Icon = "🐱‍🚀", DetailTitle = "For In-Store redempption please enter:", DetailFact = "0119 8479 79"},
                        new Detail{Icon = "🐠", DetailTitle = "For Online redempption please enter:" , DetailFact = "0119 1124 8479 79"},
                        new Detail{Icon = "🐷", DetailTitle = "PIN:", DetailFact = "0119"},
                    }
                },
                new Card
                {
                    CardImage ="PetrolCard.PNG" ,
                   Title = "eGift Card Details",
                    Summary = "Redeem in-store or online",

                     Details = new List<Detail>
                    {
                        new Detail{Icon = "⚡", DetailTitle = "For In-Store redempption please enter:", DetailFact = "0119 8479 79"},
                        new Detail{Icon = "💲", DetailTitle = "For Online redempption please enter:" , DetailFact = "0119 1124 8479 79"},
                        new Detail{Icon = "🏟", DetailTitle = "PIN:", DetailFact = "0119"},
                    }
                },
                 new Card
                {
                    CardImage ="WishCard.PNG" ,
                     Details = new List<Detail>
                    {
                        new Detail{Icon = "⚡", DetailTitle = "For In-Store redempption please enter:", DetailFact = "0119 8479 79"},
                        new Detail{Icon = "💲", DetailTitle = "For Online redempption please enter:" , DetailFact = "0119 1124 8479 79"},
                        new Detail{Icon = "🏟", DetailTitle = "PIN:", DetailFact = "0119"},
                    }
                },
            };
        }
    }
}