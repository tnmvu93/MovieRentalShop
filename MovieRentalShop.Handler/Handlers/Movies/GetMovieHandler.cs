using MovieRentalShop.Handler.Context;
using MovieRentalShop.Share.Queries.Movies;
using MovieRentalShop.Share.QueryResponses.Movies;
using MovieRentalShop.Share.ViewModels.Movies;
using System.Collections.Generic;

namespace MovieRentalShop.Handler.Handlers.Movies
{
    public class GetMovieHandler : IQueryHandler<GetMovieQuery, GetMovieQueryResponse>
    {
        private MovieRentalShopContext _dbContext;

        public GetMovieHandler(MovieRentalShopContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public GetMovieQueryResponse Handle(GetMovieQuery query)
        {
            return new GetMovieQueryResponse
            {
                Movies = new List<GetMovieViewModel>()
            };
        }
    }
}
