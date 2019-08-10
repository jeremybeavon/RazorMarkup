using RazorMarkup.Database.SqlServer.Query;
using RazorMarkup.Database.SqlServer.Query.Builders;
using System;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    internal sealed class EndCommonSubquery<TSubqueryWithAlias> :
        AbstractStatement<SubqueryBuilder>,
        IEndSubquery<TSubqueryWithAlias>
    {
        private readonly FromClauseBuilder fromClause;
        private readonly Func<FromClauseBuilder, TSubqueryWithAlias> subqueryWithAliasBuilder;

        public EndCommonSubquery(
            SubqueryBuilder statement,
            FromClauseBuilder fromClause,
            Func<FromClauseBuilder, TSubqueryWithAlias> subqueryWithAliasBuilder)
            : base(statement)
        {
            this.fromClause = fromClause;
            this.subqueryWithAliasBuilder = subqueryWithAliasBuilder;
        }

        public TSubqueryWithAlias Subquery()
        {
            Statement.Append((IEndSubquery<TSubqueryWithAlias> input) => input.Subquery());
            return subqueryWithAliasBuilder(fromClause);
        }
    }
}
