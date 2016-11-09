using Effort;
using MovieRentalShop.Handler.Context;
using NUnit.Framework;
using System;

namespace MovieRentalShop.Test.HandlerTests
{
    [TestFixture]
    public class BaseHandlerTest 
    {
        private MovieRentalShopContext _context;

        [SetUp]
        public void SetUp()
        {
            var dataFolder = AppDomain.CurrentDomain.BaseDirectory;

            var connection = DbConnectionFactory.CreateTransient();
            _context = new MovieRentalShopContext(connection);
        }

        [TearDown]
        public void TearDown()
        {
        }
    }
}
