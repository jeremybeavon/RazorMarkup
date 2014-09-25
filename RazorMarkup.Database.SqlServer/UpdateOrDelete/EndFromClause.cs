using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete
{
    internal class EndFromClause : AbstractStatement<FromClauseBuilder>
    {
        public EndFromClause(FromClauseBuilder statement)
            : base(statement)
        {
        }
    }
}
