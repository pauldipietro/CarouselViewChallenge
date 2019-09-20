﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarouselViewChallenge.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselViewChallengePage : ContentPage
    {
        public CarouselViewChallengePage()
        {
            InitializeComponent();
            this.BindingContext = new CarouselViewChallengePageViewModel();
        }
    }
}