using Bocami.Practices.Validation;

namespace Bocami.Practices.Query.Validation
{
    public interface IQueryValidator<TQuery> : IValidator<TQuery>
        where TQuery : class, IQuery
    {
    }
}
