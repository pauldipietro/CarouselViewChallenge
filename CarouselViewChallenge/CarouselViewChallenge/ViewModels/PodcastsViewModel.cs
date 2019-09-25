namespace CarouselViewChallenge.ViewModels
{
    using System;
    using System.Windows.Input;
    using Xamarin.Forms;
    using System.Collections.ObjectModel;
    using System.ComponentModel;

    /// <summary>
    /// The podcast info
    /// </summary>
    public class Podcast
    {
        public string Title { get; set; }
        public FormattedString Description { get; set; }
        public string  Url { get; set; }

        public string ImageUrl { get; set; }
    };

    public class Episode
    {
        public string Title { get; set; }
        public FormattedString Description { get; set; }
        public string Url { get; set; }

        public string Duration { get; set; }
    }

    /// <summary>
    /// The Podcasts view model
    /// </summary>
    /// <seealso cref="System.ComponentModel.INotifyPropertyChanged" />
    public class PodcastsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Episode> _episodes;
        public ObservableCollection<Episode> Episodes
        {
            get
            {
                return _episodes;
            }
            set
            {
                if (_episodes != value)
                {
                    _episodes = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Podcasts"));
                }
            }
        }

        private ObservableCollection<Podcast> _podcasts;
        public ObservableCollection<Podcast> Podcasts
        {
            get
            {
                return _podcasts;
            }
            set
            {
                if (_podcasts != value)
                {
                    _podcasts = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Podcasts"));
                }
            }
        }

        public string PlayUrl { get; set; }

        public ICommand PlayCommand { get; private set; }
        public ICommand GetEpisodes { get; private set; }

        public PodcastsViewModel()
        {
            Podcasts = new ObservableCollection<Podcast>();
            Episodes = new ObservableCollection<Episode>();
            PlayCommand = new Command<string>(Play);
            GetEpisodes = new Command<string>(LoadEpisodes);

            LoadPodcasts();
        }

        private void Play(string url)
        {
            PlayUrl = url;
        }

        private void OnPropertyChanged(PropertyChangedEventArgs eventArgs)
        {
            PropertyChanged?.Invoke(this, eventArgs);
        }

        private void LoadPodcasts()
        {
            var maxItems = 5; // Min:1 - max:200
            var country = "nl"; // Two-letter country code (ISO 3166-1 alpha-2)


            var finder = new iTunesPodcastFinder.PodcastFinder();
            var results = finder.SearchPodcastsAsync("microsoft", maxItems);

            foreach (var item in results.Result)
            {
                

                Podcasts.Add(
                    new Podcast
                    {
                        Title = item.Name,
                        Description = item.Summary,
                        Url = item.FeedUrl,
                        ImageUrl = item.ArtWork,

                    });
            }

        }
        private void LoadEpisodes(string url)
        {
            var podcastFinder = new iTunesPodcastFinder.PodcastFinder();
            var results = podcastFinder.GetPodcastEpisodesAsync(url);

            Episodes.Clear();

            foreach (var item in results.Result.Episodes)
            {
                Episodes.Add(
                    new Episode
                    {
                        Title = item.Title,
                        Description = item.Summary,
                        Url = item.FileUrl.ToString(),
                        Duration = item.Duration.ToString()
                    });
            }
        }
    }
}
