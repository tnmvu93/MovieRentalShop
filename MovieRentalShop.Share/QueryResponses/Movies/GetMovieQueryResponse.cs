using MovieRentalShop.Share.ViewModels.Movies;
using System.Collections.Generic;

namespace MovieRentalShop.Share.QueryResponses.Movies
{
    public class GetMovieQueryResponse : IQueryResponse
    {
        public IEnumerable<GetMovieViewModel> Movies { get; set; }
    }
}
