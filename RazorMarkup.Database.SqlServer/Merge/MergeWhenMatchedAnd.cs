using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Merge
{
    internal class MergeWhenMatchedAnd : MergeWhenMatched, IMergeWhenMatchedAnd
    {
        public MergeWhenMatchedAnd(MergeStatementBuilder statement)
            : base(statement)
        {
        }

        public IMergeWhenMatched And(Expression<Func<bool>> condition)
        {
            Statement.LastNotMatchedClause.ClauseSearchCondition = new ExpressionBuilder<bool>(condition);
            Statement.Append((IMergeWhenMatchedAnd input) => input.And(null), condition);
            return this;
        }
    }
}
