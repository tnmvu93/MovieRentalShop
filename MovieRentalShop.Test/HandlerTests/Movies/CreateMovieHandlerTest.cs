using MovieRentalShop.Handler.Context;
using MovieRentalShop.Handler.Handlers.Movies;
using MovieRentalShop.Share.Commands.Movies;
using NUnit.Framework;
using System.Linq;

namespace MovieRentalShop.Test.HandlerTests.Movies
{
    public class CreateMovieHandlerTest : BaseHandlerTest
    {
        private MovieRentalShopContext _dbContext;

        protected override void SetUp()
        {
            base.SetUp();
            _dbContext = new MovieRentalShopContext(GetTransientConnection());
            _dbContext.Database.CreateIfNotExists();
        }

        [Test]
        public void ShouldCreateMovieSuccessfully()
        {
            var command = new CreateMovieCommand { Name = "test" };
            var handler = new CreateMovieHandler(_dbContext, Mapper);

            handler.Handle(command);

            var movie = _dbContext.Movies.FirstOrDefault(x => x.Name == command.Name);

            Assert.IsNotNull(movie);
        }

        [Test]
        public void ShouldReturnMovieIdWhenMovieIsCreatedSuccessfully()
        {
            var command = new CreateMovieCommand { Name = "test" };
            var handler = new CreateMovieHandler(_dbContext, Mapper);

            var response = handler.Handle(command);

            var movie = _dbContext.Movies.FirstOrDefault(x => x.Name == command.Name);

            Assert.IsNotNull(movie);
            Assert.AreEqual(movie.Id, response.Id);
        }
    }
}
