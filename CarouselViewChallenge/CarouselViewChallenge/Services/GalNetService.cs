using System;
using System.Threading.Tasks;

namespace CarouselViewChallenge.Services
{
    public class GalNetService
    {
        private const string GalNetURL = "https://elitedangerous-website-backend-production.elitedangerous.com/api/galnet?_format=json";
        private const string dataKey = "NewsFeed";
        private const string lastUpdatedKey = "NewsLastUpdated";

        public async Task<(string data, DateTime updated)> GetData(bool ignoreCache = false)
        {
            DateTime lastUpdated;
            string json = String.Empty;
            TimeSpan expiry = TimeSpan.FromHours(1);

            // download the json feed
            DownloadService downloadService = DownloadService.Instance();
            (json, lastUpdated) = await downloadService.GetData(GalNetURL, dataKey, lastUpdatedKey, expiry, ignoreCache).ConfigureAwait(false);
            return (json, lastUpdated);
        }
    }
}
