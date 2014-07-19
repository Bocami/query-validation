using Bocami.Practices.Validation;

namespace Bocami.Practices.Query.Validation
{
    public class NullQueryValidator<TQuery> : NullValidator<TQuery>, IQueryValidator<TQuery>
        where TQuery : IQuery
    {
    }
}
