using CarouselViewChallenge.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace CarouselViewChallenge.Services
{
    public interface IMockDataStore
    {
        Task<List<Movie>> GetMoviesAsync();
        Task<IList<Cinema>> GetCinemasAsync();
    }

    public class MockDataStore : IMockDataStore
    {
        public async Task<List<Movie>> GetMoviesAsync()
        {
            await Task.Delay(TimeSpan.FromSeconds(3));

            return new List<Movie>
            {
                new Movie
                {
                    Id = 1,
                    Category = Category.Action,
                    Name = "Angel has Fallen",
                    ImageSource = "angelhasFallen.png"
                },
                new Movie {Id = 2, Category = Category.Comedian, Name = "Hobs", ImageSource = "fastFurious.png"},
                new Movie
                {
                    Id = 3, Category = Category.Romance, Name = "Angel has Fallen", ImageSource = "GoodBoys.png"
                },
                new Movie
                {
                    Id = 4, Category = Category.Action, Name = "Angel has Fallen", ImageSource = "toyStory4.png"
                },
                new Movie
                {
                    Id = 5,
                    Category = Category.Action,
                    Name = "Angel has Fallen",
                    ImageSource = "angelhasFallen.png"
                }
            };
        }

        public async Task<IList<Cinema>> GetCinemasAsync()
        {
            return new List<Cinema>
            {
                new Cinema
                {
                    Name = "Cineplexx Graz",
                    Address = "8010 Graz",
                    Movies = new ObservableCollection<Movie>(await GetMoviesAsync()),
                    IsFavorite = true,
                },
                new Cinema
                {
                    Name = "Cineplexx Wien",
                    Address = "1010 Wien",
                    Movies = new ObservableCollection<Movie>(await GetMoviesAsync()),
                    IsFavorite = true,
                },
                new Cinema
                {
                    Name = "Cineplexx Graz",
                    Address = "8010 Graz",
                    Movies = new ObservableCollection<Movie>(await GetMoviesAsync()),
                    IsFavorite = true,
                },
                new Cinema
                {
                    Name = "Cineplexx Graz",
                    Address = "8010 Graz",
                    Movies = new ObservableCollection<Movie>(await GetMoviesAsync()),
                    IsFavorite = true,
                }
            };
        }
    }
}
