using DynamicFilter.Core.Abstractions;
using DynamicFilter.Core.Interpreters;

namespace DynamicFilter.Core.Extensions
{
    public static class InterpreterTypeExtensions
    {
        public static IFilterTypeAbstractInterpreter<TFilteredClass> And<TFilteredClass>(this IFilterTypeAbstractInterpreter<TFilteredClass> left, IFilterTypeAbstractInterpreter<TFilteredClass> right)
        {
            return new AndInterpreter<TFilteredClass>(left, right);
        }
    }
}
