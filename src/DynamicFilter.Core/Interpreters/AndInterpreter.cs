using System.Linq.Expressions;
using DynamicFilter.Core.Abstractions;

namespace DynamicFilter.Core.Interpreters
{
    public class AndInterpreter<TFilteredClass> : IFilterTypeAbstractInterpreter<TFilteredClass>
    {
        private readonly IFilterTypeAbstractInterpreter<TFilteredClass> _leftInterpreter;
        private readonly IFilterTypeAbstractInterpreter<TFilteredClass> _rightInterpreter;

        public AndInterpreter(IFilterTypeAbstractInterpreter<TFilteredClass> leftInterpreter, IFilterTypeAbstractInterpreter<TFilteredClass> rightInterpreter)
        {
            _leftInterpreter = leftInterpreter;
            _rightInterpreter = rightInterpreter;
        }

        public Expression<Func<TFilteredClass, bool>> Interpret()
        {
            var leftExpression = _leftInterpreter.Interpret();
            var rightExpression = _rightInterpreter.Interpret();

            var rightExpressionInvoked = Expression.Invoke(rightExpression, leftExpression.Parameters);
            var andExpression = Expression.AndAlso(leftExpression.Body, rightExpressionInvoked);

            return Expression.Lambda<Func<TFilteredClass, bool>>(andExpression, leftExpression.Parameters);
        }

    }
}
