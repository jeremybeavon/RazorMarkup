namespace RazorMarkup.Database.SqlServer.Merge
{
    internal class MergeWhenMatched : AbstractStatement<MergeStatementBuilder>, IMergeWhenMatched
    {
        public MergeWhenMatched(MergeStatementBuilder statement)
            : base(statement)
        {
        }

        public IMergeMatched Then()
        {
            Statement.Append((IMergeWhenMatched input) => input.Then());
            return new MergeMatched(Statement);
        }
    }
}
