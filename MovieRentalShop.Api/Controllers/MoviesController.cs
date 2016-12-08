using MovieRentalShop.Api.Dispatchers;
using MovieRentalShop.Share.CommandResponses.Movies;
using MovieRentalShop.Share.Commands.Movies;
using MovieRentalShop.Share.Queries.Movies;
using MovieRentalShop.Share.QueryResponses.Movies;
using System.Web.Http;

namespace MovieRentalShop.Api.Controllers
{
    [RoutePrefix("movies")]
    public class MoviesController : ApiController
    {
        private readonly IQueryDispatcher _queryDispatcher;
        private readonly ICommandDispatcher _commandDispatcher;

        public MoviesController(IQueryDispatcher queryDispatcher, ICommandDispatcher commandDispatcher)
        {
            this._queryDispatcher = queryDispatcher;
            this._commandDispatcher = commandDispatcher;
        }

        [HttpGet]
        [Route("getmovies")]
        public IHttpActionResult GetMovies()
        {
            var result = _queryDispatcher.Dispatch<GetListMoviesQuery, GetListMoviesQueryResponse>(new GetListMoviesQuery());
            return Ok(result);
       } 

        [HttpPost]
        [Route("create")]
        public IHttpActionResult CreateMovie(CreateMovieCommand command)
        {
            var result = _commandDispatcher.Dispatch<CreateMovieCommand, CreateMovieCommandResponse>(command);
            return Ok(result);
        }

        [HttpGet]
        [Route("{movieId:int}")]
        public IHttpActionResult GetMovie(int movieId)
        {
            var result = _queryDispatcher.Dispatch<GetMovieQuery, GetMovieQueryResponse>(new GetMovieQuery
            {
                Id = movieId
            });
            return Ok(result);
        }        
    }
}
