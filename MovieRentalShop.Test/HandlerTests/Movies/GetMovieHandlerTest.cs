﻿using MovieRentalShop.Handler.Context;
using MovieRentalShop.Handler.Handlers.Movies;
using MovieRentalShop.Share.Queries.Movies;
using NUnit.Framework;
using System.Linq;

namespace MovieRentalShop.Test.HandlerTests.Movies
{
    public class GetMovieHandlerTest : BaseHandlerTest
    {
        private MovieRentalShopContext _dbContext;

        protected override void SetUp()
        {
            base.SetUp();
            _dbContext = new MovieRentalShopContext(GetTransientConnection());
            _dbContext.Database.CreateIfNotExists();
        }

        [Test]
        public void ShouldReturnExactlyMovieById()
        {
            var query = new GetMovieQuery { Id = 1 };

            var handler = new GetMovieHandler(_dbContext, Mapper);

            var response = handler.Handle(query);

            Assert.AreEqual("movie 1", response.Name);
        }
    }
}
