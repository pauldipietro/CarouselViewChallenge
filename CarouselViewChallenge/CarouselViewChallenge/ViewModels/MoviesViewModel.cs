using CarouselViewChallenge.Models;
using System.Collections.ObjectModel;
using Microsoft.Win32.SafeHandles;

namespace CarouselViewChallenge.ViewModels
{
    public class MoviesViewModel : BaseViewModel
    {
        public ObservableCollection<Movie> _movies;
        public ObservableCollection<Cinema> _cinemas;

        public MoviesViewModel()
        {
            Movies = new ObservableCollection<Movie>();
            Movies.Add(new Movie
            {
                Id = 1,
                Category = Category.Action,
                Name = "Angel has Fallen",
                ImageSource = "angelhasFallen.png"
            });
            Movies.Add(new Movie
            {
                Id = 2,
                Category = Category.Comedian,
                Name = "Hobs",
                ImageSource = "fastFurious.png"
            });
            Movies.Add(new Movie
            {
                Id = 3,
                Category = Category.Romance,
                Name = "Angel has Fallen",
                ImageSource = "GoodBoys.png"
            });
            Movies.Add(new Movie
            {
                Id = 4,
                Category = Category.Action,
                Name = "Angel has Fallen",
                ImageSource = "toyStory4.png"
            });
            Movies.Add(new Movie
            {
                Id = 5,
                Category = Category.Action,
                Name = "Angel has Fallen",
                ImageSource = "angelhasFallen.png"
            });

            Cinemas = new ObservableCollection<Cinema>();

            Cinemas.Add(new Cinema
            {
                Name = "Cineplexx Graz",
                Movies = new ObservableCollection<Movie>(),
                IsFavorite =  true,
            });
            Cinemas.Add(new Cinema
            {
                Name = "Cineplexx Wine",
                Movies = new ObservableCollection<Movie>(),
                IsFavorite = true,
            });
            Cinemas.Add(new Cinema
            {
                Name = "Cineplexx Graz",
                Movies = new ObservableCollection<Movie>(),
                IsFavorite = true,
            });
            Cinemas.Add(new Cinema
            {
                Name = "Cineplexx Graz",
                Movies = new ObservableCollection<Movie>(),
                IsFavorite = true,
            });

            foreach (var cinema in Cinemas)
            {
                foreach (var movie in Movies)
                {
                    cinema.Movies.Add(movie);
                }
            }

        }

        public ObservableCollection<Movie> Movies
        {
            get => _movies;
            set => SetProperty(ref _movies, value);
        }

        public ObservableCollection<Cinema> Cinemas
        {
            get => _cinemas;
            set => SetProperty(ref _cinemas, value);
        }
    }
}