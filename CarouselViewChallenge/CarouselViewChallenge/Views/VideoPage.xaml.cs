using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    [QueryProperty("VideoUrl", "url")]
    public partial class VideoPage : ContentPage
    {
        public VideoPage()
        {
            InitializeComponent();
        }

        private string _videoUrl;
        public string VideoUrl {
            get { return _videoUrl; }
            set
            {
                if (value != _videoUrl)
                {
                    _videoUrl = value;

                    WebView.Source = new HtmlWebViewSource
                    {
                        Html = BuildFinalHtml(BuildEmbedUrl(_videoUrl))
                    };
                }
            }
        }


        private string BuildEmbedUrl(string videoSource)
        {
            return $"<div class=\"videoContainer\"><div class=\"videoWrapper\"><iframe width=\"560\" height=\"315\" src=\"{videoSource}?autoplay=0&fs=0&rel=0&playsinline=1\" frameborder=\"0\"></iframe></div></div>";
        }

        private string BuildFinalHtml(string embedUrl)
        {
            string styles = "<style>html, body { background: #231E51; padding: 0; margin: 0; } .videoContainer { margin: 0 auto; max-height: 195px; } .videoWrapper { position: relative; padding-bottom: 56.25%; padding-top: 25px; height: 0; } .videoWrapper iframe { position: absolute; top: 0; left: 0; width: 100%; height: 100%; }</style>";
            return $"<!doctype html><head><meta charset=\"utf-8\"><meta name=\"viewport\" content=\"width=device-width\"></head><html><body>{styles}{embedUrl}</body></html>";
        }
    }
}