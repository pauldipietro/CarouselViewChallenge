using CarouselViewChallenge.Models;
using CarouselViewChallenge.Services;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CarouselViewChallenge.ViewModels
{
    public class MoviesViewModel : BaseViewModel
    {
        private readonly IMockDataStore _dataStore;
        public ObservableCollection<Cinema> _cinemas;

        public MoviesViewModel()
        {
            _dataStore = DependencyService.Get<IMockDataStore>();
            Cinemas = new ObservableCollection<Cinema>();
        }
        
        public ObservableCollection<Cinema> Cinemas
        {
            get => _cinemas;
            set => SetProperty(ref _cinemas, value);
        }

        public override async Task InitializeAsync()
        {
            IsBusy = true;
            var result = await _dataStore.GetCinemasAsync();

            Cinemas.Clear();

            foreach (var cinema in result)
                Cinemas.Add(cinema);

            IsBusy = false;
            await base.InitializeAsync();
        }
    }
}