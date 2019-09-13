using System.Collections.Generic;
using System.Threading.Tasks;
using CarouselViewChallenge.Models;

namespace CarouselViewChallenge.Services.Abstract
{
    public interface IPodcastService
    {
        Task<IEnumerable<Podcast>> GetPodcastsAsync();
    }
}