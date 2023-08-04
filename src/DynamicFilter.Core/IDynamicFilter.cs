

using System.Linq.Expressions;
using DynamicFilter.Core.Model;


namespace DynamicFilter.Core
{
    public interface IDynamicFilter
    {
        Expression<Func<TClass, bool>> Generate<TClass>(IReadOnlyList<Filter> filters);
    }
}
