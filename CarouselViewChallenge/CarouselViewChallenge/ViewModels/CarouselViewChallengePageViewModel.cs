using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CarouselViewChallenge.ViewModels
{
    public class CarouselViewChallengePageViewModel : INotifyPropertyChanged
    {
        private string _podcastFeed;
        // TODO: have a look at https://github.com/jamesmontemagno/Hanselman.Forms
        // to see how to get podcasts

        public CarouselViewChallengePageViewModel()
        {
            AddFeedCommand = new Command(async () => await AddFeedExecute());

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand AddFeedCommand { get; }
        public string PodcastFeed
        {
            get => _podcastFeed;
            set
            {
                _podcastFeed = value;
                OnPropertyChanged(new PropertyChangedEventArgs("PodcastFeed"));
            }
        }

        private async Task AddFeedExecute()
        {

        }

        private void OnPropertyChanged(PropertyChangedEventArgs eventArgs)
        {
            PropertyChanged?.Invoke(this, eventArgs);
        }
    }
}