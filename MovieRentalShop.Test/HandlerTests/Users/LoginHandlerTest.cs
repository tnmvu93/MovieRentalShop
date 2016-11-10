using MovieRentalShop.Handler.Context;
using MovieRentalShop.Handler.Handlers;
using MovieRentalShop.Handler.Queries.Users;
using NUnit.Framework;

namespace MovieRentalShop.Test.HandlerTests.Users
{
    [TestFixture]
    public class LoginHandlerTest : BaseHandlerTest
    {
        private MovieRentalShopContext _dbContext;

        protected override void SetUp()
        {
            base.SetUp();
            _dbContext = new MovieRentalShopContext(GetTransientConnection());
            _dbContext.Database.CreateIfNotExists();
        }

        [Test]
        public void ShouldReturnNull()
        {
            var query = new LoginQuery { Email = "vutran1@gmail.com", Password = "abc123" };

            var handler = new LoginHandler(_dbContext);

            var response = handler.Handle(query);

            Assert.IsTrue(response.Success);
        }
    }
}
