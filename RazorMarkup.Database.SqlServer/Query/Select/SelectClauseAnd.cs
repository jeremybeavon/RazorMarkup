using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.Select
{
    internal class SelectClauseAnd<TEndType> : SelectClauseWithInto<TEndType>, ISelectClauseAnd<TEndType>
    {
        public SelectClauseAnd(SelectClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public ISelectClause<TEndType> And()
        {
            Statement.Append((ISelectClauseAnd<TEndType> input) => input.And());
            return new SelectClause<TEndType>(Statement, EndClosure);
        }
    }
}
