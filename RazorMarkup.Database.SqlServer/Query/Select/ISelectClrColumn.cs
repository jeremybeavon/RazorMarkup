using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query.Select
{
    public interface ISelectClrColumn<TEndType> : ISelectClauseWithFrom<TEndType>
    {
        ISelectClauseWithFrom<TEndType> Field(ClrFieldName field);

        ISelectClauseWithFrom<TEndType> Property(ClrPropertyName property);

        ISelectClauseWithFrom<TEndType> StaticField(ClrFieldName field);

        ISelectClauseWithFrom<TEndType> StaticProperty(ClrPropertyName property);

        ISelectClauseWithFrom<TEndType> Method(ClrMethodName method, params Expression<Func<object>>[] parameters);

        ISelectClauseWithFrom<TEndType> StaticMethod(ClrMethodName method, params Expression<Func<object>>[] parameters);
    }
}
