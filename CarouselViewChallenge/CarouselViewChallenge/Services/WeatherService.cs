using System;
using System.Text;
using System.Reflection;
using System.Collections.Generic;

using Newtonsoft.Json;
using CarouselViewChallenge.Models;

namespace CarouselViewChallenge.Services
{
    public static class WeatherService
    {
        public static List<CityWeather> GetWeather()
        {
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(WeatherService)).Assembly;
            var stream = assembly.GetManifestResourceStream("CarouselViewChallenge.Data.cities.json");

            var text = string.Empty;

            using (var reader = new System.IO.StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }

            return JsonConvert.DeserializeObject<List<CityWeather>>(text);
        }
    }
}
