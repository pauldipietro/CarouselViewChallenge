using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;
using CarouselViewChallenge.Models;
using CarouselViewChallenge.Services.Abstract;

namespace CarouselViewChallenge.Services.Concrete
{
    public class PodcastService : IPodcastService
    {
        List<string> _podcastFeeds = new List<string>()
        {
            "https://feeds.fireside.fm/xamarinpodcast/rss",
            "https://pinecast.com/feed/ladybug-podcast",
            "https://feeds.simplecast.com/gvtxUiIf",
            "https://rss.art19.com/buffering-the-vampire-slayer"
        };

        public async Task<IEnumerable<Podcast>> GetPodcastsAsync()
        {
            var podcasts = new List<Podcast>();

            foreach (var feedUrl in _podcastFeeds)
            {
                podcasts.Add(await GetEpisodes(feedUrl));
            }

            return podcasts;
        }

        private async Task<Podcast> GetEpisodes(string feedUrl)
        {
            Podcast cast = new Podcast();

            var xml = XDocument.Load(feedUrl);
            cast.Description = xml("description");
            return cast;
        }
    }
}