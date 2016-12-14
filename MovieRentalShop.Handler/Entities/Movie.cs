

namespace MovieRentalShop.Handler.Entities
{
    public class Movie : BaseClass
    {
        public string Name { get; set; }
        public float Imdb { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public byte[] Image { get; set; }
        public string Director { get; set; }
        public string Star { get; set; }
    }
}
