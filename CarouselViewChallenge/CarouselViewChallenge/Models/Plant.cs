using System;
using Xamarin.Forms;

namespace CarouselViewChallenge.Models
{
    public class Plant
    {
        public Plant(string name, int wateringFrequency, DateTime lastWateringDate, ImageSource imageUrl)
        {
            Name = name;
            LastWateringDate = lastWateringDate;
            WateringFrequency = wateringFrequency;
            NextWatering = LastWateringDate.AddDays(WateringFrequency);
            ImageUrl = imageUrl;
        }

        public DateTime LastWateringDate { get; }

        public string Name { get; }

        public ImageSource ImageUrl { get; }

        public int WateringFrequency { get; }

        public DateTime NextWatering { get; }
    }
}