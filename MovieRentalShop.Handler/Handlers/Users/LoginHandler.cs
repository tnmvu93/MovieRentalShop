using MovieRentalShop.Handler.Context;
using MovieRentalShop.Share.Queries.Users;
using MovieRentalShop.Share.QueryResponses.Users;
using System.Linq;

namespace MovieRentalShop.Handler.Handlers
{
    public class LoginHandler : IQueryHandler<LoginQuery, LoginQueryResponse>
    {
        private MovieRentalShopContext _dbContext;

        public LoginHandler(MovieRentalShopContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public LoginQueryResponse Handle(LoginQuery query)
        {
            var response = new LoginQueryResponse { Success = false };

            var test = _dbContext.Users.ToList();

            if (query != null)
            {
                response.Success = _dbContext.Users.Any(x => x.Email == query.Email && x.Password == query.Password);
            }
            return response;
        }
    }
}
