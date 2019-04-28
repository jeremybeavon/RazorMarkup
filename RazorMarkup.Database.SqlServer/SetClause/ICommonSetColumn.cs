using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.SetClause
{
    public interface ICommonSetColumn<TSetClauseAnd, TSetFieldOrProperty> : ICommonSetValue<TSetClauseAnd>
    {
        TSetFieldOrProperty Field(ClrFieldName fieldName);

        TSetFieldOrProperty Property(ClrPropertyName propertyName);

        TSetClauseAnd Method(ClrMethodName methodName, params Expression<Func<object>>[] parameters);

        TSetClauseAnd Write(Expression<Func<object>> expression, int offset, int length);
    }
}
