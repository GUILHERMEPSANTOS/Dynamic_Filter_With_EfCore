using System.Linq.Expressions;
using DynamicFilter.Core.Abstractions;
using DynamicFilter.Core.Model;

namespace DynamicFilter.Core.Interpreters
{
    public class EqualsInterpreter<TFilteredClass> : FilterTypeAbstractInterpreter<TFilteredClass>
    {
        public EqualsInterpreter(Filter filter) : base(filter)
        {
        }

        public override Expression CreateExpression(MemberExpression property, ConstantExpression constant)
        {
            return Expression.Equal(property, constant);
        }
    }
}
