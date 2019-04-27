using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Merge
{
    internal class EndFromClause : AbstractStatement<FromClauseBuilder>
    {
        public EndFromClause(FromClauseBuilder statement) : base(statement)
        {
        }
    }
}
