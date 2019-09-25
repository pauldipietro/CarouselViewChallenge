using System.Collections.ObjectModel;
using CarouselViewChallenge.Models;
using CarouselViewChallenge.Services;

namespace CarouselViewChallenge.ViewModels
{
    public class CarouselViewChallengeViewModel : BaseViewModel
    {
        private ObservableCollection<Item> _items;
        private Item _currentItem;

        public CarouselViewChallengeViewModel()
        {
            LoadItems();
        }

        public ObservableCollection<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                OnPropertyChanged();
            }
        }

        public Item CurrentItem
        {
            get { return _currentItem; }
            set
            {
                _currentItem = value;
                OnPropertyChanged();
            }
        }

        private void LoadItems()
        {
            var item = MockCarService.Instance.GetItems();
            Items = new ObservableCollection<Item>(item);
            CurrentItem = Items[0];
        }
    }
}
