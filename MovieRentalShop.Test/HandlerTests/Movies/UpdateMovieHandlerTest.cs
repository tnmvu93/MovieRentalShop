using MovieRentalShop.Handler.Context;
using MovieRentalShop.Handler.Entities;
using MovieRentalShop.Handler.Handlers.Movies;
using MovieRentalShop.Share.Commands.Movies;
using NUnit.Framework;
using System.Linq;

namespace MovieRentalShop.Test.HandlerTests.Movies
{
    public class pdateMovieHandlerTest : BaseHandlerTest
    {
        private MovieRentalShopContext _dbContext;

        protected override void SetUp()
        {
            base.SetUp();
            _dbContext = new MovieRentalShopContext(GetTransientConnection());
            _dbContext.Database.CreateIfNotExists();
        }

        [Test]
        public void ShouldUpdateMovieSuccessfully()
        {
            var movie = new Movie
            {
                Name = "test",
                Description = "description"
            };
            _dbContext.Movies.Add(movie);
            _dbContext.SaveChanges();

            var command = new UpdateMovieCommand
            {
                Id = movie.Id,
                Name = movie.Name,
                Description = "new description"
            };

            var handler = new UpdateMovieHandler(_dbContext, Mapper);

            handler.Handle(command);

            var newMovie = _dbContext.Movies.FirstOrDefault(x => x.Id == movie.Id);
            Assert.IsNotNull(newMovie);
            Assert.AreEqual(command.Description, newMovie.Description);
        }

    }
}
