using System;
using MovieRentalShop.Share.Queries.Movies;
using MovieRentalShop.Share.QueryResponses.Movies;
using MovieRentalShop.Handler.Context;
using System.Linq;
using MovieRentalShop.Handler.Entities;
using AutoMapper;

namespace MovieRentalShop.Handler.Handlers.Movies
{
    public class GetMovieHandler : IQueryHandler<GetMovieQuery, GetMovieQueryResponse>
    {
        private readonly MovieRentalShopContext _dbContext;
        private readonly IMapper _mapper;

        public GetMovieHandler(MovieRentalShopContext _dbContext, IMapper _mapper)
        {
            this._dbContext = _dbContext;
            this._mapper = _mapper;
        }

        public GetMovieQueryResponse Handle(GetMovieQuery query)
        {
            var response = new GetMovieQueryResponse();
            if (query == null) return response;

            var movie = _dbContext.Movies.FirstOrDefault(x => x.Id == query.Id);
            if (movie == null) return response;

            response = _mapper.Map<Movie, GetMovieQueryResponse>(movie);
            return response;
        }
    }
}
