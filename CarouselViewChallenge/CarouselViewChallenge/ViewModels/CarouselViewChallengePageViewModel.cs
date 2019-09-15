using CarouselViewChallenge.Models;
using Flurl.Http;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CarouselViewChallenge.ViewModels
{
    public class CarouselViewChallengePageViewModel : ReactiveObject
    {
        private const string _apiBaseUrl = "http://xkcd.com";
        private const string _apiEndUrl = "info.0.json";
        private const int _cacheSize = 10;

        [Reactive] public bool IsBusy { get; private set; }

        [Reactive] public XkcdComic CurrentComic { get; set; }

        public ObservableCollection<XkcdComic> ComicList { get; private set; }
        [Reactive] public ICommand CurrentItemChangedCommand { get; private set; }

        private IFlurlClient _flurlClient;

        public CarouselViewChallengePageViewModel()
        {
            IsBusy = true;
            ComicList = new ObservableCollection<XkcdComic>();
            _flurlClient = new FlurlClient(_apiBaseUrl);

            Task.Factory.StartNew(InitAsync, TaskCreationOptions.LongRunning);
        }

        private async Task InitAsync()
        {
            try
            {
                // I don't know why this statement is slow (2 or 3 sec)...
                // So I moved it in my async init task.
                CurrentItemChangedCommand = ReactiveCommand.CreateFromTask(CurrentItemChanged);
                var firstModel = await DownloadComicAsync();
                var tasksList = new List<Task<XkcdComic>>();

                for (var i = 0; i < _cacheSize; ++i)
                    tasksList.Add(DownloadComicAsync(firstModel.Num - 1 - i));

                await Task.WhenAll(tasksList);

                await Device.InvokeOnMainThreadAsync(async () =>
                {
                    ComicList.Add(firstModel);
                    foreach (var task in tasksList)
                        ComicList.Add(await task);
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                IsBusy = false;
            }
        }


        private async Task<XkcdComic> DownloadComicAsync(int? comicNumber = null)
        {
            IFlurlRequest request;

            if (comicNumber == null)
                request = _flurlClient.Request(_apiBaseUrl, _apiEndUrl);
            else
                request = _flurlClient.Request(_apiBaseUrl, comicNumber, _apiEndUrl);

            return await request.GetJsonAsync<XkcdComic>();
        }

        private async Task CurrentItemChanged(CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            var comicNumberToLoad = CurrentComic.Num - _cacheSize;
            if (comicNumberToLoad <= 0 || ComicList.Any(x => x.Num == comicNumberToLoad))
                return;

            var comic = await DownloadComicAsync(comicNumberToLoad);

            await Device.InvokeOnMainThreadAsync(() =>
            {
                ComicList.Add(comic);
            });
        }
    }
}
