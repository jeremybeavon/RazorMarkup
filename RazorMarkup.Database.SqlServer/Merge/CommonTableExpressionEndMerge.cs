namespace RazorMarkup.Database.SqlServer.Merge
{
    internal sealed class CommonTableExpressionEndMerge : AbstractStatement<MergeStatementBuilder>, ICommonTableExpressionEndMerge
    {
        public CommonTableExpressionEndMerge(MergeStatementBuilder statement)
            : base(statement)
        {
        }

        public IEndMergeCommonTableExpression With()
        {
            Statement.Append((ICommonTableExpressionEndMerge input) => input.With());
            return new EndMergeCommonTableExpression(Statement);
        }
    }
}
