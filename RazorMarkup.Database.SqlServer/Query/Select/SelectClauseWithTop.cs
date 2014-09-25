using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Query.Select
{
    internal class SelectClauseWithTop<TEndType> : SelectClause<TEndType>, ISelectClauseWithTop<TEndType>
    {
        public SelectClauseWithTop(SelectClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public ISelectClauseWithPercent<TEndType> Top(Expression<Func<Integer>> count)
        {
            Statement.Top = new ExpressionBuilder<Integer>(count);
            Statement.Append((ISelectClauseWithTop<TEndType> input) => input.Top(count), count);
            return new SelectClauseWithPercent<TEndType>(Statement, EndClosure);
        }
    }
}
