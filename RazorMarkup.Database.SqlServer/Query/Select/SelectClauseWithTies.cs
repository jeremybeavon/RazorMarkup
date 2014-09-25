using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.Select
{
    internal class SelectClauseWithTies<TEndType> : SelectClause<TEndType>,
        ISelectClauseWithTies<TEndType>
    {
        public SelectClauseWithTies(SelectClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public ISelectClause<TEndType> WithTies()
        {
            Statement.WithTies = true;
            Statement.Append((ISelectClauseWithTies<TEndType> input) => input.WithTies());
            return this;
        }
    }
}
