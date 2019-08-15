using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.SetClauses
{
    public interface ICommonSetValue<TSetClauseAnd> : IHideObjectMethods
    {
        TSetClauseAnd Equals(Expression<Func<object>> expression);

        TSetClauseAnd PlusEquals(Expression<Func<object>> expression);

        TSetClauseAnd MinusEquals(Expression<Func<object>> expression);

        TSetClauseAnd MultiplyEquals(Expression<Func<object>> expression);

        TSetClauseAnd DivideEquals(Expression<Func<object>> expression);

        TSetClauseAnd ModuloEquals(Expression<Func<object>> expression);

        TSetClauseAnd BitwiseAndEquals(Expression<Func<object>> expression);

        TSetClauseAnd BitwiseOrEquals(Expression<Func<object>> expression);

        TSetClauseAnd BitwiseXorEquals(Expression<Func<object>> expression);
    }
}
