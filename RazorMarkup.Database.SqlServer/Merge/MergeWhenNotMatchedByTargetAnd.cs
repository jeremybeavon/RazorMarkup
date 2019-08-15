using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Merge
{
    internal class MergeWhenNotMatchedByTargetAnd : MergeWhenNotMatchedByTarget, IMergeWhenNotMatchedByTargetAnd
    {
        public MergeWhenNotMatchedByTargetAnd(MergeStatementBuilder statement)
            : base(statement)
        {
        }

        public IMergeWhenNotMatchedByTarget And(Expression<Func<bool>> condition)
        {
            Statement.LastNotMatchedClause.ClauseSearchCondition = new ExpressionBuilder<bool>(condition);
            Statement.Append((IMergeWhenNotMatchedByTargetAnd input) => input.And(null), condition);
            return this;
        }
    }
}
