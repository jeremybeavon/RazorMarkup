using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.Select
{
    internal class SelectClauseWithFrom<TEndType> : AbstractQueryStatement<SelectClauseBuilder, TEndType>,
        ISelectClauseWithFrom<TEndType>
    {
        public SelectClauseWithFrom(SelectClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public IFromClause<TEndType> From()
        {
            Statement.Append((ISelectClauseWithFrom<TEndType> input) => input.From());
            return new FromClause<TEndType>(ExpressionBuilder, EndClosure).AsNextClause(Statement);
        }
    }
}
