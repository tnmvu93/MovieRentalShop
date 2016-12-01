using MovieRentalShop.Handler.Context;
using MovieRentalShop.Handler.Handlers.Movies;
using MovieRentalShop.Share.Queries.Movies;
using NUnit.Framework;
using System.Linq;

namespace MovieRentalShop.Test.HandlerTests.Movies
{
    public class GetListMoviesHandlerTest : BaseHandlerTest
    {
        private MovieRentalShopContext _dbContext;

        protected override void SetUp()
        {
            base.SetUp();
            _dbContext = new MovieRentalShopContext(GetTransientConnection());
            _dbContext.Database.CreateIfNotExists();
        }

        [Test]
        public void ShouldReturnAllMovies()
        {
            var numMovie = _dbContext.Movies.Count();
            var query = new GetListMoviesQuery();

            var handler = new GetListMoviesHandler(_dbContext, Mapper);

            var response = handler.Handle(query);

            Assert.AreEqual(numMovie, response.Movies.Count());
        }
    }
}
