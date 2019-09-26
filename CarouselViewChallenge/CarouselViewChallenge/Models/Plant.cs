using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CarouselViewChallenge.Models
{
    public class Plant
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string FlowerDate { get; set; }
        public string FruitDate { get; set; }
        public string HardinessZone { get; set; }
        public string Description { get; set; }
        public List<ImageSource> Images { get; set; }
    }
}
