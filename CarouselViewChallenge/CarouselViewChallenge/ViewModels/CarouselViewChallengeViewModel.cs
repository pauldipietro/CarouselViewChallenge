using CarouselViewChallenge.Helpers;
using CarouselViewChallenge.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CarouselViewChallenge.ViewModels
{
    public class CarouselViewChallengeViewModel : INotifyPropertyChanged
    {
        public CarouselViewChallengeViewModel()
        {
            Items = new List<CarouselItem>()
            {
                new CarouselItem
                {
                    Title = "Breaking down: Big government",
                    Image = "breaking_down_big_government",
                    VideoLink = "https://www.youtube.com/embed/_vX_a3X2i5c"
                },
                new CarouselItem
                {
                    Title = "Breaking down: Bills",
                    Image = "breaking_down_bills",
                    VideoLink = "https://www.youtube.com/embed/j7iugJkK7w4"
                },
                new CarouselItem
                {
                    Title = "Breaking down: Cannabis",
                    Image = "breaking_down_cannabis",
                    VideoLink = "https://www.youtube.com/embed/bn6wbycCJG8"
                },
                new CarouselItem
                {
                    Title = "Breaking down: Caucus",
                    Image = "breaking_down_caucus",
                    VideoLink = "https://www.youtube.com/embed/R04ddYk40do"
                },
                new CarouselItem
                {
                    Title = "Breaking down: Impeachment",
                    Image = "breaking_down_impeachment",
                    VideoLink = "https://www.youtube.com/embed/XCTO7GB7DC0"
                },
                new CarouselItem
                {
                    Title = "Breaking down: Incumbent",
                    Image = "breaking_down_incumbent",
                    VideoLink = "https://www.youtube.com/embed/T08wlFuPreI"
                },
                new CarouselItem
                {
                    Title = "Breaking down: Primaries",
                    Image = "breaking_down_primaries",
                    VideoLink = "https://www.youtube.com/embed/IDLjPoup8Wc"
                },
                new CarouselItem
                {
                    Title = "Breaking down: Reproductive rights",
                    Image = "breaking_down_reproductive_rights",
                    VideoLink = "https://www.youtube.com/embed/D_wF_yAOQn0"
                },
                new CarouselItem
                {
                    Title = "Breaking down: Supreme Court",
                    Image = "breaking_down_supreme_court",
                    VideoLink = "https://www.youtube.com/embed/LDE-k0U7VpU"
                },
                new CarouselItem
                {
                    Title = "Breaking down: Tariffs",
                    Image = "breaking_down_tariffs",
                    VideoLink = "https://www.youtube.com/embed/CGiK7Ayw4nc"
                },
                new CarouselItem
                {
                    Title = "Breaking down: Voter Registration",
                    Image = "breaking_down_voter_registration",
                    VideoLink = "https://www.youtube.com/embed/pXNI5Dnhj3U"
                }
            };

            NavigateToVideoEmbedCommand = new AsyncCommand<string>(NavigateToVideoEmbed);
        }

        private List<CarouselItem> _items;
        public List<CarouselItem> Items
        {
            get { return _items; }
            set { SetProperty(ref _items, value); }
        }


        public AsyncCommand<string> NavigateToVideoEmbedCommand { get; private set; }
        private async Task NavigateToVideoEmbed(string videoUrl)
        {
            await Shell.Current.GoToAsync($"video?url={Uri.EscapeUriString(videoUrl)}");
        }

        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName]string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
