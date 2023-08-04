using System.Linq.Expressions;
using DynamicFilter.Core.Abstractions;
using DynamicFilter.Core.Model;

namespace DynamicFilter.Core.Interpreters
{
    public class GreaterThanInterpreter<TFilteredClass> : FilterTypeAbstractInterpreter<TFilteredClass>
    {
        public GreaterThanInterpreter(Filter filter) : base(filter)
        {
        }

        public override Expression CreateExpression(MemberExpression property, ConstantExpression constant)
        {
            throw new NotImplementedException();
        }
    }
}
