

namespace MovieRentalShop.Handler.Entities
{
    public class Movie : BaseClass
    {
        public string Name { get; set; }
        public float Imdb { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public string ImageUrl { get; set; }
    }
}
