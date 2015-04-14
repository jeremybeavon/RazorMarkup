using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Query.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query
{
    internal sealed class EndSubquery<TEndType> : AbstractQueryStatement<SubqueryBuilder, TEndType>,
        IEndSubquery<ISubqueryWithAlias<TEndType>>
    {
        public EndSubquery(SubqueryBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public ISubqueryWithAlias<TEndType> Subquery()
        {
            Statement.End();
            Statement.Append((IEndSubquery<ISubqueryWithAlias<TEndType>> input) => input.Subquery());
            return new SubqueryWithAlias<TEndType>(new FromClauseBuilder(Expression), EndClosure);
        }
    }
}
