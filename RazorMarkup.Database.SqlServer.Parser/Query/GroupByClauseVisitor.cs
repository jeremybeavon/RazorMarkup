using RazorMarkup.Database.SqlServer.Query;

namespace RazorMarkup.Database.SqlServer.Parser.Query
{
    internal sealed class GroupByClauseVisitor<TEndType> : AbstractSqlVisitor<IEndGroupByClause<TEndType>>
    {
        private readonly IGroupByClause<TEndType> groupBy;

        public GroupByClauseVisitor()
        {

        }
    }
}
