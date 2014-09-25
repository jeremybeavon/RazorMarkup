using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query
{
    internal class EndForClause<TEndType> : AbstractQueryStatement<ForClauseBuilder, TEndType>, IEndForClause<TEndType>
    {
        public EndForClause(ForClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }
    }
}
