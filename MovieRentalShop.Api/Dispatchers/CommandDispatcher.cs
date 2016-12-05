using Autofac;
using MovieRentalShop.Handler.Handlers;
using MovieRentalShop.Share.CommandResponses;
using MovieRentalShop.Share.Commands;

namespace MovieRentalShop.Api.Dispatchers
{
    public class CommandDispatcher : ICommandDispatcher
    {
        private readonly IComponentContext _componentContext;

        public CommandDispatcher(IComponentContext componentContext)
        {
            this._componentContext = componentContext;
        }

        public TQueryResponse Dispatch<TQuery, TQueryResponse>(TQuery query)
            where TQuery : ICommand
            where TQueryResponse : ICommandResponse
        {
            // populate some filters here before resolving and calling handler

            var queryHandler = _componentContext.Resolve<ICommandHandler<TQuery, TQueryResponse>>();
            return queryHandler.Handle(query);
        }
    }
}