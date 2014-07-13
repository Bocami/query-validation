using Bocami.Practices.DecoratorPattern;

namespace Bocami.Practices.Query.Validation
{
    public abstract class ValidationQueryHandlerDecorator<TQuery, TQueryResult> : IQueryHandler<TQuery, TQueryResult>, IDecorator<IQueryHandler<TQuery, TQueryResult>>
        where TQuery : class, IQuery
        where TQueryResult : class, IQueryResult
    {
        private readonly IQueryHandler<TQuery, TQueryResult> queryHandler;
        private readonly IQueryValidator<TQuery> queryValidator;

        public ValidationQueryHandlerDecorator(IQueryHandler<TQuery, TQueryResult> queryHandler, IQueryValidator<TQuery> queryValidator)
        {
            this.queryHandler = queryHandler;
            this.queryValidator = queryValidator;
        }

        public TQueryResult Handle(TQuery Query)
        {
            queryValidator.Validate(Query);

            return queryHandler.Handle(Query);
        }
    }
}
