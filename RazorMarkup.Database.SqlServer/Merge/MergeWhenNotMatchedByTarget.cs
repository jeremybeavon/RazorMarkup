namespace RazorMarkup.Database.SqlServer.Merge
{
    internal class MergeWhenNotMatchedByTarget : AbstractStatement<MergeStatementBuilder>, IMergeWhenNotMatchedByTarget
    {
        public MergeWhenNotMatchedByTarget(MergeStatementBuilder statement)
            : base(statement)
        {
        }

        public IMergeMatched Then()
        {
            Statement.Append((IMergeWhenNotMatchedByTarget input) => input.Then());
            return new MergeMatched(Statement);
        }
    }
}
