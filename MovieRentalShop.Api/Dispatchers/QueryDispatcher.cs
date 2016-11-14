using System;
using Autofac;
using MovieRentalShop.Handler.Handlers;
using MovieRentalShop.Share.Queries;
using MovieRentalShop.Share.QueryResponses;

namespace MovieRentalShop.Api.Dispatchers
{
    public class QueryDispatcher : IQueryDispatcher
    {
        private readonly IComponentContext _componentContext;

        public QueryDispatcher(IComponentContext componentContext)
        {
            this._componentContext = componentContext;
        }

        public TQueryResponse Dispatch<TQuery, TQueryResponse>(TQuery query)
            where TQuery : IQuery
            where TQueryResponse : IQueryResponse
        {
            // populate some filters here before resolving and calling handler

            var queryHandler = _componentContext.Resolve<IQueryHandler<TQuery, TQueryResponse>>();
            return queryHandler.Handle(query);
        }
    }
}