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
        }

        public void OnPositionChanged(object sender, PositionChangedEventArgs args)
        {
            var max = 5;
            if(args.CurrentPosition == max)
            {
                carousel.IsScrollAnimated = false;
                carousel.Position = 1;
                carousel.IsScrollAnimated = true;
            }
            else if(args.CurrentPosition == 0)
            {
                carousel.IsScrollAnimated = false;
                carousel.Position = 4;
                carousel.IsScrollAnimated = true;
            }
        }
    }
}