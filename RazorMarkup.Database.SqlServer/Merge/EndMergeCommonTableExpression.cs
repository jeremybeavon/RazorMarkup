using RazorMarkup.Database.SqlServer.Query.CommonTableExpressions;

namespace RazorMarkup.Database.SqlServer.Merge
{
    internal sealed class EndMergeCommonTableExpression : MergeClause,
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
    }
}
