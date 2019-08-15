using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Merge
{
    internal class MergeWhenNotMatchedBySourceAnd : MergeWhenNotMatchedBySource, IMergeWhenNotMatchedBySourceAnd
    {
        public MergeWhenNotMatchedBySourceAnd(MergeStatementBuilder statement)
            : base(statement)
        {
        }

        public IMergeWhenNotMatchedBySource And(Expression<Func<bool>> condition)
        {
            Statement.LastNotMatchedClause.ClauseSearchCondition = new ExpressionBuilder<bool>(condition);
            Statement.Append((IMergeWhenNotMatchedBySourceAnd input) => input.And(null), condition);
            return this;
        }
    }
}
