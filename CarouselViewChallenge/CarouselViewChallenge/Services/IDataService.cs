using System.Threading.Tasks;
using System.Collections.Generic;
using CarouselViewChallenge.Models;

namespace CarouselViewChallenge.Services
{
    public interface IDataService
    {
        Task<IEnumerable<Movie>> GetMoviesAsync();
    }
}
