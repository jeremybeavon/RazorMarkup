using RazorMarkup.Database.SqlServer.Types.Wrappers;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Merge
{
    internal class MergeClause : MergeTargetTable, IMergeClause
    {
        public MergeClause(MergeStatementBuilder statement)
            : base(statement)
        {
        }

        public IMergeTopPercent Top(Expression<Func<Integer>> count)
        {
            Statement.Top = new ExpressionBuilder<Integer>(count);
            Statement.Append((IMergeClause input) => input.Top(null), count);
            return new MergeTopPercent(Statement);
        }
    }
}
