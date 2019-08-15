using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Merge
{
    internal class EndFromClause : AbstractStatement<FromClauseBuilder>, IEndFromClause
    {
        public EndFromClause(FromClauseBuilder statement)
            : base(statement)
        {
        }

        public IMergeWhen On(Expression<Func<bool>> searchCondition)
        {
            MergeStatementBuilder statement = ((MergeFromClauseBuilder)Statement).Statement;
            statement.SearchCondition = new ExpressionBuilder<bool>(searchCondition);
            statement.Append((IEndFromClause input) => input.On(null), searchCondition);
            return null;
        }
    }
}
