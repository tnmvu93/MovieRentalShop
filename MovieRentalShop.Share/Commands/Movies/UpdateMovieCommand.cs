


namespace MovieRentalShop.Share.Commands.Movies
{
    public class UpdateMovieCommand : ICommand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Imdb { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public byte[] Image { get; set; }
        public string Director { get; set; }
        public string Star { get; set; }
    }
}
