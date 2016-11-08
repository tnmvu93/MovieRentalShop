using MovieRentalShop.Handler.Handlers.BaseQuery;
using MovieRentalShop.Handler.Queries;
using MovieRentalShop.Handler.QueryResponses;

namespace MovieRentalShop.Handler.Handlers
{
    public class GetUserQueryHandler : IQueryHandler<GetUserQuery, GetUserQueryResponse>
    {
        public GetUserQueryResponse Handle(GetUserQuery query)
        {
            throw new System.NotImplementedException();
        }
    }
}
