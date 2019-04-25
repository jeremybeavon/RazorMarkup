using RazorMarkup.Database.SqlServer.Query.CommonTableExpressions;

namespace RazorMarkup.Database.SqlServer.Merge
{
    internal sealed class CommonTableExpressionEndMerge : AbstractStatement<MergeStatementBuilder>,
        ICommonTableExpressionEnd<IEndMergeCommonTableExpression>
    {
        public CommonTableExpressionEndMerge(MergeStatementBuilder statement)
            : base(statement)
        {
        }

        public IEndMergeCommonTableExpression With()
        {
            Statement.Append((ICommonTableExpressionEnd<IEndMergeCommonTableExpression> input) => input.With());
            return new EndMergeCommonTableExpression(Statement);
        }
    }
}
