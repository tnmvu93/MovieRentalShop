
namespace MovieRentalShop.Handler.Handlers.BaseQuery
{
    public interface IQueryHandler<TInt, TOut>
    {
        TOut Handle<TInt, TOut>(TInt query)
            where TInt : IQuery
            where TOut : IQueryResponse;
    }
}
