using CarouselViewChallenge.Models;
using CarouselViewChallenge.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(WebDataService))]
namespace CarouselViewChallenge.Services
{
    public class WebDataService : IDataService
    {

        HttpClient httpClient;

        HttpClient Client => httpClient ?? (httpClient = new HttpClient());

        public async Task<IEnumerable<Movie>> GetMoviesAsync()
        {
            var json = await Client.GetStringAsync("https://raw.githubusercontent.com/BryanOroxon/CollectionViewChallenge/master/CollectionViewChallenge/CollectionViewChallenge/Data/moviedata.json");
            var all = Movie.FromJson(json);
            return all;
        }
    }
}
