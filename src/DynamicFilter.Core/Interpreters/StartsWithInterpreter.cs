using System.Linq.Expressions;
using DynamicFilter.Core.Abstractions;
using DynamicFilter.Core.Model;

namespace DynamicFilter.Core.Interpreters
{
    public class StartsWithInterpreter<TFilteredClass> : FilterTypeAbstractInterpreter<TFilteredClass>
    {
        public StartsWithInterpreter(Filter filter) : base(filter)
        {
        }

        public override Expression CreateExpression(MemberExpression property, ConstantExpression constant)
        {
            var methodInfo = typeof(string).GetMethod(nameof(string.StartsWith), new Type[] { typeof(string) });

            return Expression.Call(property, methodInfo, constant);
        }
    }
}
