using CarouselViewChallenge.Views;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CarouselViewChallenge
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("video", typeof(VideoPage));
        }
    }
}
