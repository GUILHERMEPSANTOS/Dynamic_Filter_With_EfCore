using System.Linq.Expressions;
using DynamicFilter.Core.Abstractions;
using DynamicFilter.Core.Model;

namespace DynamicFilter.Core.Interpreters
{
    public class LessThanInterpreter<TFilteredClass> : FilterTypeAbstractInterpreter<TFilteredClass>
    {
        public LessThanInterpreter(Filter filter) : base(filter)
        {
        }

        public override Expression CreateExpression(MemberExpression property, ConstantExpression constant)
        {
            return Expression.LessThan(property, constant);
        }
    }
}
