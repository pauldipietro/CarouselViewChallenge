namespace CarouselViewChallenge.Models
{
    public class CityWeather
    {
        public Coord coord { get; set; }
        public Weather Weather { get; set; }
        public string @base { get; set; }
        public Main Main { get; set; }
        public int visibility { get; set; }
        public Wind Wind { get; set; }
        public Clouds clouds { get; set; }
        public int dt { get; set; }
        public Sys Sys { get; set; }
        public int id { get; set; }
        public string Name { get; set; }
        public int cod { get; set; }
        public string Image { get; set; }
    }

    public class Coord
    {
        public double lon { get; set; }
        public double lat { get; set; }
    }

    public class Weather
    {
        public int id { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }

    public class Main
    {
        public double Temp { get; set; }
        public int pressure { get; set; }
        public int Humidity { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
    }

    public class Wind
    {
        public double Speed { get; set; }
        public int Deg { get; set; }
    }

    public class Clouds
    {
        public int all { get; set; }
    }

    public class Sys
    {
        public int type { get; set; }
        public int id { get; set; }
        public double message { get; set; }
        public string Country { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }

}
