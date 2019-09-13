using System;
using System.Collections.Generic;

namespace CarouselViewChallenge.Models
{
    public class Podcast
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Episode> Episodes { get; set; }
    }

    public class Episode
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public DateTime Published { get; set; }
        public string ImageUrl { get; set; }
    }
}