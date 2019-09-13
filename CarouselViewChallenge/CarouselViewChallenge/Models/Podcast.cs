using System;

namespace CarouselViewChallenge.Models
{
    public class Podcast
    {
        public string Title { get; set; }
        public string Episode { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public DateTime Published { get; set; }
        public byte[] Image { get; set; }
    }
}