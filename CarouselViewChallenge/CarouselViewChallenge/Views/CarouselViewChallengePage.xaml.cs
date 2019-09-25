using CarouselViewChallenge.Models;
using CarouselViewChallenge.ViewModels;
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
    public partial class CarouselViewChallengePage : ContentPage
    {
        public CarouselViewChallengePage()
        {
            InitializeComponent();

            BindingContext = new CarouselViewChallengeViewModel
            {
                CorousalClassList = new List<CorousalClass>() 
                {
                 new CorousalClass
                 {
                     Text = "Universal Principle of Design",
                     Count = "10,023 Learners",
                     Amount = "$109",
                     ImageUrl = "https://devoirtech.com/pen.png",
                 GradientStartColor="#7655EE",
                 GradientEndColor="#A875EB"
                 
                 },
                 new CorousalClass
                 {
                     Text = "User Experiance Design Fundamentals",
                     Count = "10,023 Learners",
                     Amount = "$109",
                     ImageUrl = "https://devoirtech.com/pen.png",
                 GradientStartColor="#fa8765",
                 GradientEndColor="#e686cd"
                 }
                }

               ,
                CategoryClassList = new List<CategoryClass>() {
                 new CategoryClass
                 {
                     Text = "Marketing",
                     SubText = "25 Cources",

                     ImageUrl = "https://devoirtech.com/pie.png",
                 GradientStartColor="#27a9ff",
                 GradientEndColor="#05d8ea"

                 },
                new CategoryClass
                 {
                     Text = "Development",
                     SubText = "25 Cources",

                     ImageUrl = "https://devoirtech.com/coding.png",
                 GradientStartColor="#fd7e60",
                 GradientEndColor="#fcaa76"

                 },
                 new CategoryClass
                 {
                     Text = "Photography",
                     SubText = "25 Cources",

                     ImageUrl = "https://devoirtech.com/camera.png",
                 GradientStartColor="#07eab7",
                 GradientEndColor="#5aeba8"

                 }
                }
            };
        }
    }

    
}