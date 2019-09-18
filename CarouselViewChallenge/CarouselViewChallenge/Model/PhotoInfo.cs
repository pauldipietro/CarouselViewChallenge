namespace CarouselViewChallenge.Model
{
    public class PhotoInfo
    {
        public string id { get; set; }

        public string created_at { get; set; }

        public string updated_at { get; set; }

        public int width { get; set; }

        public int height { get; set; }

        public string color { get; set; }

        public string description { get; set; }

        public PhotoUrls urls { get; set; }
    }
}
