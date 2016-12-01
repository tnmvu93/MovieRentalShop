using MovieRentalShop.Api.Dispatchers;
using MovieRentalShop.Share.Queries.Movies;
using MovieRentalShop.Share.QueryResponses.Movies;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MovieRentalShop.Api.Controllers
{
    public class MoviesController : ApiController
    {
        private readonly IQueryDispatcher _queryDispatcher;

        public MoviesController(IQueryDispatcher queryDispatcher)
        {
            this._queryDispatcher = queryDispatcher;
        }

        [HttpGet]
        [Route("movies/getmovies")]
        public IHttpActionResult GetMovies()
        {
            var result = _queryDispatcher.Dispatch<GetMoviesQuery, GetMoviesQueryResponse>(new GetMoviesQuery());
            return Ok(result);
        }

        [HttpGet]
        [Route("movie/{movie:int}")]
        public IHttpActionResult GetMovie(int movieId)
        {
            var result = _queryDispatcher.Dispatch<GetMoviesQuery, GetMoviesQueryResponse>(new GetMoviesQuery
            {
                Id = movieId
            });
            return Ok(result);
        }
    }
}
