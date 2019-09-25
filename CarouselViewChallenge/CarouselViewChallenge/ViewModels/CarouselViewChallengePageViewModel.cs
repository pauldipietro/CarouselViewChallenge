using CarouselViewChallenge.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CarouselViewChallenge.ViewModels
{
    public class CarouselViewChallengePageViewModel:BaseViewModel
    {
        Dictionary<string, string> sensorNameLocations;
        ObservableCollection<Sensor> sensors = new ObservableCollection<Sensor>();

        public CarouselViewChallengePageViewModel() {

            
            sensorNameLocations = new Dictionary<string, string>();
            sensorNameLocations.Add("Bar", "https://www.beveragefactory.com/images/MO24BNS1RS-built-in010516144751.jpg");
            sensorNameLocations.Add("Kitchen", "https://cdn-image.realsimple.com/sites/default/files/1537981754/matte-appliances-trend-kitchen.JPG");
            sensorNameLocations.Add("Bedroom", "https://www.ikea.com/ms/media/rooms/20201/bedroom/20201_rmbe05a/20201_rmbe05a_01_thumb_PH163122.jpg");
            sensorNameLocations.Add("Garage", "https://www.residencestyle.com/wp-content/uploads/2019/06/Garage.jpg");
            sensorNameLocations.Add("PC", "https://i.pinimg.com/originals/75/79/ee/7579ee363b374c6c02455b98a6eeaa6d.jpg");
            sensorNameLocations.Add("Attic", "https://49op3q1oapcpd3h2q1ys9f81-wpengine.netdna-ssl.com/wp-content/uploads/2017/08/attic-2416396_1920.jpg");
            sensorNameLocations.Add("Monkey Habitat", "https://pixfeeds.com/images/animals/monkeys/1280-669297382-sri-lankan-monkeys-at-yala-national-park.jpg");
            setupFakeData();
        }

        
       


        private void setupFakeData()
        {
            Random r = new Random();
            foreach (string s in sensorNameLocations.Keys) {
                var temp = Math.Round(r.Next(30, 104) + r.NextDouble(),2);
                Sensors.Add(new Sensor(){ Sensor_ID = 0,Name=s+" Sensor", Temperature=temp, AvgTemperature=temp+r.Next(-5,5), imageSrc= sensorNameLocations[s] });

            }
        }


        public ObservableCollection<Sensor> Sensors
        {
            get { return sensors; }
            set { SetProperty(ref sensors, value, "Sensors"); }
        }
    }
}
