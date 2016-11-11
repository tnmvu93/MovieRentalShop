using MovieRentalShop.Api.Dispatchers;
using MovieRentalShop.Handler.Queries.Users;
using MovieRentalShop.Handler.QueryResponses.Users;
using System.Web.Http;

namespace MovieRentalShop.Api.Controllers
{
    public class UsersController : ApiController
    {
        private IQueryDispatcher _queryDispatcher;

        public UsersController(IQueryDispatcher queryDispatcher)
        {
            this._queryDispatcher = queryDispatcher;
        }

        [Route("users/login")]
        [HttpPost]
        public IHttpActionResult Login(LoginQuery query)
        {
            var response = _queryDispatcher.Dispatch<LoginQuery, LoginQueryResponse>(query);
            return Ok(response);
        }
    }
}
