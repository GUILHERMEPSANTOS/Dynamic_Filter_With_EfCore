using System.Linq.Expressions;
using System.Reflection;
using DynamicFilter.Core.Model;

namespace DynamicFilter.Core.Abstractions
{
    public abstract class FilterTypeAbstractInterpreter<TFilteredClass> : IFilterTypeAbstractInterpreter<TFilteredClass>
    {
        private Filter _filter;

        protected FilterTypeAbstractInterpreter(Filter filter)
        {
            _filter = filter;
        }

        public Expression<Func<TFilteredClass, bool>> Interpret()
        {
            var dynamicType = typeof(TFilteredClass);
            var parameter = Expression.Parameter(dynamicType, dynamicType.Name.First().ToString());
            var property = Expression.Property(parameter, _filter.Property);
            var propertyMember = (PropertyInfo)property.Member;
            var value = Convert.ChangeType(_filter.Value.ToString(), propertyMember.PropertyType);
            var constant = Expression.Constant(value);
            var expression = CreateExpression(property, constant);

            return Expression.Lambda<Func<TFilteredClass, bool>>(expression, parameter);
        }

        internal abstract Expression CreateExpression(MemberExpression property, ConstantExpression constant);
    }
}
