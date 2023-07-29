using System.Linq.Expressions;

namespace DynamicFilter.Core.Abstractions
{
    public interface IFilterTypeAbstractInterpreter<TFilteredClass>
    {
        Expression<Func<TFilteredClass, bool>> Interpret();
    }
}
