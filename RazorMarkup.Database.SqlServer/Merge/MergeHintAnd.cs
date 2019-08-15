namespace RazorMarkup.Database.SqlServer.Merge
{
    internal class MergeHintAnd : MergeAsTableAlias, IMergeHintAnd
    {
        public MergeHintAnd(MergeStatementBuilder statement)
            : base(statement)
        {
        }

        public IMergeHint And()
        {
            Statement.Append((IMergeHintAnd input) => input.And());
            return new MergeHint(Statement);
        }
    }
}
