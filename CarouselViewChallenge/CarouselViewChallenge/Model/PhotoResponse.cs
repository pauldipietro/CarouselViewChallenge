namespace CarouselViewChallenge.Model
{
    public class PhotoResponse
    {
        public int total { get; set; }

        public int total_pages { get; set; }

        public PhotoInfo[] results { get; set; }
    }
}
