using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace CarouselViewChallenge.ViewModels
{
    public class PlantViewModel
    {
        public PlantViewModel(string name, int wateringFrequency, DateTime lastWateringDate, ImageSource imageSource)
        {
            Name = name;
            WateringFrequency = wateringFrequency;
            LastWateringDate = lastWateringDate;
            ImageUrl = imageSource;
            NextWatering = LastWateringDate.AddDays(WateringFrequency);
        }

        public DateTime LastWateringDate { get; }

        public string Name { get; }

        public ImageSource ImageUrl { get; }

        public int WateringFrequency { get; }

        public DateTime NextWatering { get; }

        public bool IsOverdue => DateTime.Now > NextWatering;

    }
}