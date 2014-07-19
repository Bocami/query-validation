using System;
using Bocami.Practices.Decorator;

namespace Bocami.Practices.Query.Validation
{
    public abstract class ValidationQueryHandlerDecorator<TQuery, TQueryResult> : IQueryHandler<TQuery, TQueryResult>, IDecorator<IQueryHandler<TQuery, TQueryResult>>
        where TQuery : class, IQuery
        where TQueryResult : class, IQueryResult
    {
        private readonly IQueryHandler<TQuery, TQueryResult> queryHandler;
        private readonly IQueryValidator<TQuery> queryValidator;

        protected ValidationQueryHandlerDecorator(IQueryHandler<TQuery, TQueryResult> queryHandler, IQueryValidator<TQuery> queryValidator)
        {
            if (queryHandler == null)
                throw new ArgumentNullException("queryHandler");

            if (queryValidator == null)
                throw new ArgumentNullException("queryValidator");

            this.queryHandler = queryHandler;
            this.queryValidator = queryValidator;
        }

        public TQueryResult Handle(TQuery query)
        {
            queryValidator.Validate(query);

            return queryHandler.Handle(query);
        }
    }
}
