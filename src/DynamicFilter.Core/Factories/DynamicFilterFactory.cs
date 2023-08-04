using DynamicFilter.Core.Abstractions;
using DynamicFilter.Core.Interpreters;
using DynamicFilter.Core.Model;


namespace DynamicFilter.Core.Factories
{
    public class DynamicFilterFactory : IDynamicFilterFactory
    {
        public IFilterTypeAbstractInterpreter<TFilteredClass> Create<TFilteredClass>(Filter filter)
        {
            return filter.FilterType switch
            {
                FilterTypeConstants.Contains => new ContainsInterpreter<TFilteredClass>(filter),
                FilterTypeConstants.Equals => new EqualsInterpreter<TFilteredClass>(filter),
                FilterTypeConstants.GreaterThan => new GreaterThanInterpreter<TFilteredClass>(filter),
                FilterTypeConstants.LessThan => new LessThanInterpreter<TFilteredClass>(filter),
                FilterTypeConstants.StartsWith => new StartsWithInterpreter<TFilteredClass>(filter),
                _ => throw new ArgumentException($"the filter type {filter.FilterType} is invalid")
            };
        }

    }
}
