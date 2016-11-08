
namespace MovieRentalShop.Handler.Handlers.BaseQuery
{
    public interface IQueryHandler<TIntput, TOutput> where TIntput : IQuery where TOutput : IQueryResponse
    {
        TOutput Handle(TIntput query);
    }
}
