using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Merge
{
    internal class MergeNotMatchedInsert : AbstractStatement<MergeStatementBuilder>, IMergeNotMatchedInsert
    {
        public MergeNotMatchedInsert(MergeStatementBuilder statement)
            : base(statement)
        {
        }

        public IEndWhenClause DefaultValues()
        {
            Statement.Append((IMergeNotMatchedInsert input) => input.DefaultValues());
            return new EndWhenClause(Statement);
        }

        public IMergeNotMatchedInsertAnd Values(Expression<Func<object>> value)
        {
            Statement.LastNotMatchedClause.Values.Add(new ExpressionBuilder<object>(value));
            Statement.Append((IMergeNotMatchedInsert input) => input.Values(null), value);
            return new MergeNotMatchedInsertAnd(Statement);
        }
    }
}
