using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace CarouselViewChallenge.Models
{
    public class Place
    {
        public PromotionInfo Special { get; set; }
        public PromotionInfo Activity { get; set; }
        public PromotionInfo FreeActivity { get; set; }
        public bool HasSpecial { get; set; }
        public bool HasActivity { get; set; }
        public bool HasFreeActivity { get; set; }
    }

    public class PromotionInfo
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}
