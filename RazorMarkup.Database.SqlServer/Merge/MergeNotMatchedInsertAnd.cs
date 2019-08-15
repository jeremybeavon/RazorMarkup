using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Merge
{
    internal sealed class MergeNotMatchedInsertAnd : EndWhenClause, IMergeNotMatchedInsertAnd
    {
        public MergeNotMatchedInsertAnd(MergeStatementBuilder statement)
            : base(statement)
        {
        }

        public IMergeNotMatchedInsertAnd And(Expression<Func<object>> value)
        {
            Statement.LastNotMatchedClause.Values.Add(new ExpressionBuilder<object>(value));
            Statement.Append((IMergeNotMatchedInsertAnd input) => input.And(null), value);
            return this;
        }
    }
}
