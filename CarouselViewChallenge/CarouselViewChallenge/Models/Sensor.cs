using System;
using System.Collections.Generic;
using System.Text;

namespace CarouselViewChallenge.Models
{
    public class Sensor
    {

        public int Sensor_ID { get; set; }
        
        public string Name { get; set; }

        public double Temperature { get; set; }
      
        public double AvgTemperature { get; set; }

        public string imageSrc { get; set; }


        public string TemperatureFormatted { get {
                return "Current: "+Temperature + "\xB0"+"F";

            } }
        public string AvgTemperatureFormatted
        {
            get
            {
                return "Avg: "+AvgTemperature + "\xB0"+"F";
            }
        }

    }
}
