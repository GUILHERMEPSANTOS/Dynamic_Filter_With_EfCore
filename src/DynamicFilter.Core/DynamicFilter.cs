
using System.Linq.Expressions;
using DynamicFilter.Core.Extensions;
using DynamicFilter.Core.Factories;
using DynamicFilter.Core.Model;

namespace DynamicFilter.Core
{
    public class DynamicFilter : IDynamicFilter
    {
        private readonly IDynamicFilterFactory _factory;

        public DynamicFilter(IDynamicFilterFactory factory)
        {
            _factory = factory;
        }

        public Expression<Func<TFilteredClass, bool>> Generate<TFilteredClass>(IReadOnlyList<Filter> filters)
        {
            return filters.Select(filter => _factory.Create<TFilteredClass>(filter))
                            .Aggregate((curr, next) => curr.And(next))
                            .Interpret();
        }
    }
}
