using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.Select
{
    internal class SelectClauseWithFrom<TEndType> : SelectClause<TEndType>, ISelectClauseWithFrom<TEndType>
    {
        public SelectClauseWithFrom(SelectClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public IFromClause<TEndType> From()
        {
            return new FromClause<TEndType>(EndClosure);
        }
    }
}
