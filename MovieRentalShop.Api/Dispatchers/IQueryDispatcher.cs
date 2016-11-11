using MovieRentalShop.Handler.Queries;
using MovieRentalShop.Handler.QueryResponses;

namespace MovieRentalShop.Api.Dispatchers
{
    public interface IQueryDispatcher
    {
        TQueryResponse Dispatch<TQuery, TQueryResponse>(TQuery query)
            where TQuery : IQuery
            where TQueryResponse : IQueryResponse;
    }
}
