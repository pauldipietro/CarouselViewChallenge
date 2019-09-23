using CarouselViewChallenge.Models;
using MPD.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CarouselViewChallenge.ViewModels
{
    public class CarouselViewChallengeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(PropertyChangedEventArgs eventArgs)
        {
            PropertyChanged?.Invoke(this, eventArgs);
        }

        public ObservableCollection<Item> Items { get; set; }

        public Item currentItem { get; set; }

        public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>() ?? new MockDataStore();
        public Command LoadItemsCommand { get; set; }
        public CarouselViewChallengeViewModel()
        {
            Items = new ObservableCollection<Item>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
        }

        public async Task ExecuteLoadItemsCommand()
        {
            //if (IsBusy)
            //    return;

            //IsBusy = true;
            //return;
            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Items.Add(item);
                    if (item.Text.Equals("Fourth item"))
                        currentItem = item;
                }
                
            }
            catch (Exception ex)
            {
                //Debug.WriteLine(ex);
            }
            finally
            {
                //IsBusy = false;
            }
        }
    }
}
