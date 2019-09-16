using CarouselViewChallenge.Services;
using Xamarin.Forms;

namespace CarouselViewChallenge
{
    public partial class App : Application
    {

        public App()
        {
            DependencyService.Register<MockDataStore>();
            InitializeComponent();

            MainPage = new AppShell();
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
