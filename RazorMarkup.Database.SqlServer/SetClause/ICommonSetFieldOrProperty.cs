using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.SetClause
{
    public interface ICommonSetFieldOrProperty<TSetClauseAnd> : IHideObjectMethods
    {
        TSetClauseAnd Equals(Expression<Func<object>> expression);
    }
}
