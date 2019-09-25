using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarouselViewChallenge.Models;
using CarouselViewChallenge.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselViewChallengePage : ContentPage
    {
        public CarouselViewChallengePageViewModel VM { get; set; }

        public CarouselViewChallengePage()
        {
            InitializeComponent();

            VM = new CarouselViewChallengePageViewModel();
            VM.Plant = new Plant
            {
                Name = "Florentina",
                Type = "Climbing Rose",
                FlowerDate = "3,4,5",
                FruitDate = "6,7,8",
                HardinessZone = "Zone 4-9",
                Description = "佛罗伦蒂娜(佛罗伦萨、Florentina),德国, 2002,红色花，黄色花蕊。大花复瓣(26-40)，杯型过渡至平坦花，多季开放。约两米，宽度约一米，耐寒。",
                Images = new List<ImageSource>
                {
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-florentina.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-honeycaramel.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-hotchocolate.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-florentina.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-honeycaramel.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-hotchocolate.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-florentina.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-honeycaramel.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-hotchocolate.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-florentina.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-honeycaramel.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-hotchocolate.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-florentina.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-honeycaramel.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-hotchocolate.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-florentina.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-honeycaramel.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-hotchocolate.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-florentina.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-honeycaramel.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-hotchocolate.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-florentina.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-honeycaramel.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-hotchocolate.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-florentina.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-honeycaramel.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-hotchocolate.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-florentina.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-honeycaramel.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-hotchocolate.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-florentina.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-honeycaramel.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-hotchocolate.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-florentina.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-honeycaramel.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-hotchocolate.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-florentina.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-honeycaramel.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-hotchocolate.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-florentina.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-honeycaramel.jpg"),
                    ImageSource.FromResource("CarouselViewChallenge.Resources.sample-rose-hotchocolate.jpg"),
                }
            };

            BindingContext = VM;
        }
    }
}