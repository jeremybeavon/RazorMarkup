using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query.Select
{
    public interface ISelectClrColumn<TEndType> : ISelectColumn<TEndType>
    {
        ISelectColumn<TEndType> Field(ClrFieldName field);

        ISelectColumn<TEndType> Property(ClrPropertyName property);

        ISelectColumn<TEndType> StaticField(ClrFieldName field);

        ISelectColumn<TEndType> StaticProperty(ClrPropertyName property);

        ISelectColumn<TEndType> Method(ClrMethodName method, params Expression<Func<object>>[] parameters);

        ISelectColumn<TEndType> StaticMethod(ClrMethodName method, params Expression<Func<object>>[] parameters);
    }
}
