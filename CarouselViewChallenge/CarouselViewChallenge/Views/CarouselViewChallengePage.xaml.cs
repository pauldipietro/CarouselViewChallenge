using CarouselViewChallenge.ViewModels;
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
        public DateTime currentMonth = DateTime.Now;
        public int position = 5;

        public CarouselViewChallengePage()
        {
            InitializeComponent();
            BindingContext = new CalendarViewModel();

            var prevMonthImage_tap = new TapGestureRecognizer();
            prevMonth.GestureRecognizers.Add(prevMonthImage_tap);

            prevMonthImage_tap.Tapped += PrevMonthImage_tap_Tapped; ;

            var nextMonthImage_tap = new TapGestureRecognizer();
            nextMonth.GestureRecognizers.Add(nextMonthImage_tap);

            nextMonthImage_tap.Tapped += NextMonthImage_tap_Tapped; ; ;

            Carousel.Position = 5;
            monthTitle.Text = currentMonth.ToString("MMMM yyyy");
        }

        

        private void NextMonthImage_tap_Tapped(object sender, EventArgs e)
        {
            if (Carousel.Position != 11)
            {
                position = Carousel.Position + 1;
                Carousel.Position = position;

                currentMonth = currentMonth.AddMonths(1);
                monthTitle.Text = currentMonth.ToString("MMMM yyyy");
            }
        }


        private void PrevMonthImage_tap_Tapped(object sender, EventArgs e)
        {
            if (Carousel.Position != 0)
            {
                position = Carousel.Position - 1;
                Carousel.Position = position;

                currentMonth = currentMonth.AddMonths(-1);
                monthTitle.Text = currentMonth.ToString("MMMM yyyy");
            }
        }

        private void Carousel_PositionChanged(object sender, PositionChangedEventArgs e)
        {
            if (Carousel.Position > position)
            {
                currentMonth = currentMonth.AddMonths(1);
                monthTitle.Text = currentMonth.ToString("MMMM yyyy");
            }
            else if (Carousel.Position < position)
            {
                currentMonth = currentMonth.AddMonths(-1);
                monthTitle.Text = currentMonth.ToString("MMMM yyyy");
            }
            position = Carousel.Position;
        }
    }
}   