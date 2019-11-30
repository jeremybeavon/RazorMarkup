namespace RazorMarkup.Database.SqlServer.Merge
{
    internal class MergeTopPercent : MergeTargetTable, IMergeTopPercent
    {
        public MergeTopPercent(MergeStatementBuilder statement)
            : base(statement)
        {
        }

        public IMergeTargetTable Percent()
        {
            Statement.IsPercent = true;
            Statement.Append((IMergeTopPercent input) => input.Percent());
            return this;
        }
    }
}
