using MovieRentalShop.Share.Commands;
using MovieRentalShop.Share.CommandResponses;

namespace MovieRentalShop.Api.Dispatchers
{
    public interface ICommandDispatcher
    {
        TCommandResponse Dispatch<TCommand, TCommandResponse>(TCommand query)
            where TCommand : ICommand
            where TCommandResponse : ICommandResponse;
    }
}
