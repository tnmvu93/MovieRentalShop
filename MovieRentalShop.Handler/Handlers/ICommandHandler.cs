using MovieRentalShop.Share.CommandResponses;
using MovieRentalShop.Share.Commands;

namespace MovieRentalShop.Handler.Handlers
{
    public interface ICommandHandler<TIntput, TOutput> where TIntput : ICommand where TOutput : ICommandResponse
    {
        TOutput Handle(TIntput query);
    }
}
