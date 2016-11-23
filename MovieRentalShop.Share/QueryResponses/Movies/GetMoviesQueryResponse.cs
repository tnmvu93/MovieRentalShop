using MovieRentalShop.Share.ViewModels.Movies;
using System.Collections.Generic;

namespace MovieRentalShop.Share.QueryResponses.Movies
{
    public class GetMoviesQueryResponse : IQueryResponse
    {
        public IEnumerable<GetMoviesViewModel> Movies { get; set; }
    }
}
