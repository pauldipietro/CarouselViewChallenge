using System.Collections.ObjectModel;

namespace CarouselViewChallenge.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImageSource { get; set; }

        public Category Category { get; set; }
        
    }

    public class Cinema
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }


        public bool IsFavorite { get; set; }

        public ObservableCollection<Movie> Movies { get; set; }
    }

    public enum Category
    {
        Action,
        Romance,
        Comedian
    }
}
