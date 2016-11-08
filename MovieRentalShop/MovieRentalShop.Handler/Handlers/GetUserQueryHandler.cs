using MovieRentalShop.Handler.Handlers.BaseQuery;
using MovieRentalShop.Handler.Queries;
using MovieRentalShop.Handler.QueryResponses;

namespace MovieRentalShop.Handler.Handlers
{
    public class GetUserQueryHandler : IQueryHandler<GetUserQuery, GetUserQueryResponse>
    {

        public TOut Handle<TInt, TOut>(TInt query)
            where TInt : IQuery
            where TOut : IQueryResponse
        {
            throw new System.NotImplementedException();
        }
    }
}
