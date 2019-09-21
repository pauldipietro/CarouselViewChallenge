using CarouselViewChallenge.Converters;
using CarouselViewChallenge.Helpers;
using CarouselViewChallenge.Models;
using CarouselViewChallenge.Services;
using MonkeyCache.FileStore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CarouselViewChallenge.ViewModels
{
    public class CarouselViewChallengeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            var changed = PropertyChanged;
            if (changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public ObservableCollection<NewsItem> GalNetNewsList { get; set; }

        private DateTime _galnetLastUpdated;
        public DateTime GalNetLastUpdated
        {
            get { return _galnetLastUpdated; }
            private set
            {
                if (_galnetLastUpdated != value)
                {
                    _galnetLastUpdated = value;
                    OnPropertyChanged(nameof(GalNetLastUpdated));
                }
            }
        }

        private string _message;
        public string Message
        {
            get { return _message; }
            set
            {
                if (_message != value)
                {
                    _message = value;
                    OnPropertyChanged(nameof(Message));
                }
            }
        }

        public CarouselViewChallengeViewModel()
        {
            Barrel.ApplicationId = "com.carouselchallenge.galnet";
            GalNetNewsList = new ObservableCollection<NewsItem>();
            GetGalNetNewsAsync();
        }

        private async void GetGalNetNewsAsync(bool ignoreCache = false)
        {
            Message = "Loading...";
            try
            {
                // get the news feed
                string json = String.Empty;
                GalNetService news = new GalNetService();
                (json, GalNetLastUpdated) = await news.GetData(ignoreCache).ConfigureAwait(false);

                // parse the json data
                GalNetNewsList.Clear();
                await Task.Run(() =>
                {
                    List<NewsItem> fullNews = JsonConvert.DeserializeObject<List<NewsItem>>(json, NewsItemConverter.Instance);
                    foreach (NewsItem item in fullNews.Where(o => !String.IsNullOrEmpty(o.Body)).OrderByDescending(o => o.PublishDateTime).Take(20))
                    {
                        item.ClassifyArticle();
                        Device.BeginInvokeOnMainThread(() => GalNetNewsList.Add(item));
                    }
                }).ConfigureAwait(false);
                Message = null;
            }
            catch (Exception ex)
            {
                Message = String.Format("Error: {0}", ex.Message);
                ToastHelper.Toast(Message);
            }
        }
    }
}
