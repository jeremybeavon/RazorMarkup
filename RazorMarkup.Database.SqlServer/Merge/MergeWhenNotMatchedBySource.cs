namespace RazorMarkup.Database.SqlServer.Merge
{
    internal class MergeWhenNotMatchedBySource : AbstractStatement<MergeStatementBuilder>, IMergeWhenNotMatchedBySource
    {
        public MergeWhenNotMatchedBySource(MergeStatementBuilder statement)
            : base(statement)
        {
        }

        public IMergeNotMatched Then()
        {
            Statement.Append((IMergeWhenNotMatchedBySource input) => input.Then());
            return new MergeNotMatched(Statement);
        }
    }
}
