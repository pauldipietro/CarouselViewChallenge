﻿using CarouselViewChallenge.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselViewChallengePage : ContentPage
    {
        public PodcastsViewModel model { get; set; }

        public CarouselViewChallengePage()
        {
            InitializeComponent();
            model = new PodcastsViewModel();
           
            BindingContext = model;
        }
    }
}