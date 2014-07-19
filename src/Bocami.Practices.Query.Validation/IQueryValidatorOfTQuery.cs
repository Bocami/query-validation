using Bocami.Practices.Validation;

namespace Bocami.Practices.Query.Validation
{
    public interface IQueryValidator<in TQuery> : IValidator<TQuery>
        where TQuery : IQuery
    {
    }
}
