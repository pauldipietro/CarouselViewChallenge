using Acr.UserDialogs;
using CarouselViewChallenge.Model;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Http;
using Xamarin.Forms;

namespace CarouselViewChallenge.ViewModels
{
    public class ImageSearchViewModel : INotifyPropertyChanged
    {
        #region MVVM

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(PropertyChangedEventArgs eventArgs)
        {
            PropertyChanged?.Invoke(this, eventArgs);
        }

        #endregion

        public static string urlBase = "https://api.unsplash.com/";
        public static string auth = "client_id=0f4446f2ddeb7c1565216cac807bf697f2deeb989f1fbf16b6d6f034ef430b74";

        private ObservableCollection<PhotoInfo> _photos;
        public ObservableCollection<PhotoInfo> Photos
        {
            get
            {
                return _photos;
            }
            set
            {
                if (_photos != value)
                {
                    _photos = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Photos"));
                }
            }
        }

        private string _SearchValue;
        public string SearchValue
        {
            get
            {
                return _SearchValue;
            }
            set
            {
                if (_SearchValue != value)
                {
                    _SearchValue = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("SearchValue"));
                }
            }
        }

        private Command _CmdSearch;
        public Command CmdSearch
        {
            get
            {
                if (_CmdSearch == null)
                {
                    _CmdSearch = new Command(async () =>
                    {
                        // rest client

                        UserDialogs.Instance.ShowLoading("Getting images...");

                        HttpClient client = new HttpClient();

                        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"{urlBase}/search/photos?page=1&per_page=100&query={SearchValue}&{auth}");

                        HttpResponseMessage response = await client.SendAsync(request);

                        UserDialogs.Instance.HideLoading();

                        if (response.IsSuccessStatusCode)
                        {
                            PhotoResponse photoInfo = JsonConvert.DeserializeObject<PhotoResponse>(await response.Content.ReadAsStringAsync());
                            Photos = new ObservableCollection<PhotoInfo>(photoInfo.results);
                        }
                        else
                        {
                            await App.Current.MainPage.DisplayAlert("Carousel challenge", response.ReasonPhrase, "OK");
                        }
                    });
                }

                return _CmdSearch;
            }
        }
    }
}
