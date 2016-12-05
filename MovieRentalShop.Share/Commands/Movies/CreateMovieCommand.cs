

namespace MovieRentalShop.Share.Commands.Movies
{
    public class CreateMovieCommand : ICommand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Imdb { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public string ImageUrl { get; set; }
    }
}
