﻿using MovieRentalShop.Api.Dispatchers;
using MovieRentalShop.Share.Queries.Movies;
using MovieRentalShop.Share.QueryResponses.Movies;
using System.Web.Http;

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
    }
}