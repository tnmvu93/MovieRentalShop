


namespace MovieRentalShop.Share.Commands.Movies
{
    public class UpdateMovieCommand : ICommand
    {
        public string Name { get; set; }
        public float Imdb { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public byte[] Image { get; set; }
    }
}
