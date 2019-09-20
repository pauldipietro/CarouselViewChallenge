using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Threading.Tasks;

namespace CarouselViewChallenge.Helpers
{
    public static class HttpHelper
    {
        public static async Task<string> ReadContentAsync(HttpResponseMessage response)
        {
            string content;

            if (response.Content.Headers.ContentEncoding.Contains("gzip"))
            {
                Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
                using (GZipStream gzipStream = new GZipStream(stream, CompressionMode.Decompress))
                using (StreamReader reader = new StreamReader(gzipStream))
                {
                    content = reader.ReadToEnd();
                }
            }
            else if (response.Content.Headers.ContentEncoding.Contains("deflate"))
            {
                Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
                using (DeflateStream gzipStream = new DeflateStream(stream, CompressionMode.Decompress))
                using (StreamReader reader = new StreamReader(gzipStream))
                {
                    content = reader.ReadToEnd();
                }
            }
            else
            {
                content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            }
            return content;
        }
    }
}
