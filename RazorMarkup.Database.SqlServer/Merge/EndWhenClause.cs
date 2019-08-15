namespace RazorMarkup.Database.SqlServer.Merge
{
    internal class EndWhenClause : MergeWhen, IEndWhenClause
    {
        public EndWhenClause(MergeStatementBuilder statement)
            : base(statement)
        {
        }
    }
}
