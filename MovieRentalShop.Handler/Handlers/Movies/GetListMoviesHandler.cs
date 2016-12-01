using AutoMapper;
using MovieRentalShop.Handler.Context;
using MovieRentalShop.Handler.Entities;
using MovieRentalShop.Share.Queries.Movies;
using MovieRentalShop.Share.QueryResponses.Movies;
using MovieRentalShop.Share.ViewModels.Movies;
using System.Collections.Generic;
using System.Linq;

namespace MovieRentalShop.Handler.Handlers.Movies
{
    public class GetListMoviesHandler : IQueryHandler<GetListMoviesQuery, GetListMoviesQueryResponse>
    {
        private readonly MovieRentalShopContext _dbContext;
        private readonly IMapper _mapper;

        public GetListMoviesHandler(MovieRentalShopContext dbContext, IMapper mapper)
        {
            this._dbContext = dbContext;
            this._mapper = mapper;
        }

        public GetListMoviesQueryResponse Handle(GetListMoviesQuery query)
        {
            var movies = _dbContext.Movies.ToList();
            var movieVMs = _mapper.Map<List<Movie>, List<GetMoviesViewModel>>(movies);

            return new GetListMoviesQueryResponse
            {
                Movies = movieVMs
            };
        }
    }
}
