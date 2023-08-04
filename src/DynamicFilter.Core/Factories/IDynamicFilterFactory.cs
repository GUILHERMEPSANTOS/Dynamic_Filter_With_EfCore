using DynamicFilter.Core.Abstractions;
using DynamicFilter.Core.Model;

namespace DynamicFilter.Core.Factories
{
    public interface IDynamicFilterFactory
    {
        IFilterTypeAbstractInterpreter<TFilteredClass>Create<TFilteredClass>(Filter filter);
    }
}
