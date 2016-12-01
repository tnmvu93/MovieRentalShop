using MovieRentalShop.Share.ViewModels.Movies;
using System.Collections.Generic;

namespace MovieRentalShop.Share.QueryResponses.Movies
{
    public class GetListMoviesQueryResponse : IQueryResponse
    {
        public IEnumerable<GetMoviesViewModel> Movies { get; set; }
    }
}
