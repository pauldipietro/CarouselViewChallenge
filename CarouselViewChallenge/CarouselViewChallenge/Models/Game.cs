using System;
using System.Collections.Generic;
using System.Text;

namespace CarouselViewChallenge.Models
{
    public class Game
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public string Platform { get; set; }
        public string Key { get; set; }
        public string State { get; set; }
        //public Visibility ShowKey { get; set; }
        public bool BtnState { get; set; }
        //public Brush StateColor { get; set; }
    }
}
