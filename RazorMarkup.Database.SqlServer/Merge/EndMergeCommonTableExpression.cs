using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.CommonTableExpressions;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Merge
{
    internal sealed class EndMergeCommonTableExpression : AbstractStatement<MergeStatementBuilder>,
        IEndMergeCommonTableExpression
    {
        public EndMergeCommonTableExpression(MergeStatementBuilder statement) 
            : base(statement)
        {
        }

        public IWithClause<ICommonTableExpressionEnd<IEndMergeCommonTableExpression>> And()
        {
            Statement.Append((IEndMergeCommonTableExpression input) => input.And());
            return new WithClause<ICommonTableExpressionEnd<IEndMergeCommonTableExpression>>(
                Statement.WithClause,
                new CommonTableExpressionEndMerge(Statement));
        }

        public object Top(Expression<Func<Integer>> count)
        {
            throw new NotImplementedException();
        }
    }
}
