using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace CarouselViewChallenge.ViewModels
{
    public class ItemClass
    {
        public string ItemText {get; set;}
        public ImageSource Image { get; set; }
        public string Description { get; set; }
        public string Price { get; set;  }
    }

    public class CaroselViewChallengePageViewModel : INotifyPropertyChanged
    {   
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<ItemClass> _items { get; set; }

        public CaroselViewChallengePageViewModel()
        {
            _items = new ObservableCollection<ItemClass>
            {
                new ItemClass
                {
                    ItemText = "Movic Air Platinum",
                    Image = ImageSource.FromResource("CarouselViewChallenge.Resources.blackDrone.png"),
                    Description = "Creates highly accurate and detailed models of whatever area is being scanned.",
                    Price = "$714,00"
                },
                new ItemClass
                {
                    ItemText = "AirCraft",
                    Image = ImageSource.FromResource("CarouselViewChallenge.Resources.Drone-PNG-Transparent-Picture.png"),
                    Description = "These models can be used to extrapolate accurate measurements of distance and volume from building locations",
                    Price = "$1.230,00"
                },
                new ItemClass
                {
                    ItemText = "White Ghost",
                    Image = ImageSource.FromResource("CarouselViewChallenge.Resources.Drone-PNG-Image.png"),
                    Description = "Has a distinct advantage over traditional aerial photogrammetry by being able to penetrate dense canopies",
                    Price = "$892,00"
                }
            };
        }

        private void OnPropertyChanged(PropertyChangedEventArgs eventArgs)
        {
            PropertyChanged?.Invoke(this, eventArgs);
        }
    }
}
