using MovieRentalShop.Handler.Queries;
using MovieRentalShop.Handler.QueryResponses;

namespace MovieRentalShop.Handler.Handlers
{
    public interface IQueryHandler<TIntput, TOutput> where TIntput : IQuery where TOutput : IQueryResponse
    {
        TOutput Handle(TIntput query);
    }
}
