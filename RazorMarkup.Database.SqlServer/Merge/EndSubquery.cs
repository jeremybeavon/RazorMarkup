using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Merge.TableSelection;
using RazorMarkup.Database.SqlServer.Query;

namespace RazorMarkup.Database.SqlServer.Merge
{
    internal sealed class EndSubquery : AbstractStatement<SubqueryBuilder>, IEndSubquery<ISubqueryWithAlias>
    {
        private readonly FromClauseBuilder fromClause;

        public EndSubquery(SubqueryBuilder statement, FromClauseBuilder fromClause)
            : base(statement)
        {
            this.fromClause = fromClause;
        }

        public ISubqueryWithAlias Subquery()
        {
            Statement.Append((IEndSubquery<ISubqueryWithAlias> input) => input.Subquery());
            return new SubqueryWithAlias(fromClause);
        }
    }
}
