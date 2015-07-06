using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Query.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query
{
    internal sealed class EndSubquery<TEndType> : AbstractQueryStatement<SubqueryBuilder, TEndType>,
        IEndSubquery<ISubqueryWithAlias<TEndType>>
    {
        private readonly FromClauseBuilder fromClause;

        public EndSubquery(SubqueryBuilder statement, FromClauseBuilder fromClause, TEndType endClosure)
            : base(statement, endClosure)
        {
            this.fromClause = fromClause;
        }

        public ISubqueryWithAlias<TEndType> Subquery()
        {
            Statement.End();
            Statement.Append((IEndSubquery<ISubqueryWithAlias<TEndType>> input) => input.Subquery());
            fromClause.UpdateExpression(Expression);
            return new SubqueryWithAlias<TEndType>(fromClause, EndClosure);
        }
    }
}
