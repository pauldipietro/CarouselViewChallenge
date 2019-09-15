using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CarouselViewChallenge.Models
{
    public class Card
    {
        public string CardImage { get; set; }
        public float OpeningBalance { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public List<Detail> Details { get; set; }
    };

    public class Detail
    {
        public string Icon { get; set; }
        public string DetailTitle { get; set; }
        public string DetailFact { get; set; }
    }
}
