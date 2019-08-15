namespace RazorMarkup.Database.SqlServer.Merge
{
    internal class MergeWithHint : MergeAsTableAlias, IMergeWithHint
    {
        public MergeWithHint(MergeStatementBuilder statement) : base(statement)
        {
        }

        public IMergeHint With()
        {
            Statement.Append((IMergeWithHint input) => input.With());
            return new MergeHint(Statement);
        }
    }
}
