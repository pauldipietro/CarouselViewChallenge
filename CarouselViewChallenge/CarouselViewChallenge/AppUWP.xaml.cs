using CarouselViewChallenge.Views;
using Xamarin.Forms;

namespace CarouselViewChallenge
{
    public partial class AppUWP : Application
    {

        public AppUWP()
        {
            InitializeComponent();

            var tabs = new TabbedPage();
            tabs.Children.Add(new NavigationPage(new WelcomePage()) { Title = "Welcome" });
            tabs.Children.Add(new NavigationPage(new CarouselViewChallengePage()) { Title = "Carousel" });

            MainPage = tabs;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
