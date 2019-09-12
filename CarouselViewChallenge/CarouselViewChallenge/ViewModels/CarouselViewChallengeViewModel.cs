using System;
using System.Collections.Generic;
using CarouselViewChallenge.Models;

namespace CarouselViewChallenge.ViewModels
{
    public class CarouselViewChallengeViewModel
    {
        public List<Destination> Destinations { get; set; } = new List<Destination>();
        public List<Category> Categories { get; set; } = new List<Category>();
    }
}
