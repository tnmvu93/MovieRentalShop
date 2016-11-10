using MovieRentalShop.Handler.Context;
using MovieRentalShop.Handler.Queries.Users;
using MovieRentalShop.Handler.QueryResponses.Users;
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

            if (query != null)
            {
                response.Success = _dbContext.Users.Any(x => x.Email == query.Email && x.Password == query.Password);
            }
            return response;
        }
    }
}
