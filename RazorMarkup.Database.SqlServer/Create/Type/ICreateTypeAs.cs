using RazorMarkup.Database.SqlServer.Create.Type.ComputedColumns;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Create.Type
{
    public interface ICreateTypeAs : IHideObjectMethods
    {
        ICreateTypePersisted As(Expression<Func<object>> computedColumnExpression);
    }
}
