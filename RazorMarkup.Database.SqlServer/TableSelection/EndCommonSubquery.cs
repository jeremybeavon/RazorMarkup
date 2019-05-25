using RazorMarkup.Database.SqlServer.Query;
using RazorMarkup.Database.SqlServer.Query.Builders;
using System;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    internal sealed class EndCommonSubquery<TJoinEndType, TSubqueryWithAlias> :
        AbstractStatement<SubqueryBuilder>,
        IEndSubquery<TSubqueryWithAlias>
    {
        private readonly FromClauseBuilder fromClause;
        private readonly TJoinEndType joinClosure;
        private readonly Func<FromClauseBuilder, TJoinEndType, TSubqueryWithAlias> subqueryWithAliasBuilder;

        public EndCommonSubquery(
            SubqueryBuilder statement,
            FromClauseBuilder fromClause,
            TJoinEndType joinClosure,
            Func<FromClauseBuilder, TJoinEndType, TSubqueryWithAlias> subqueryWithAliasBuilder)
            : base(statement)
        {
            this.fromClause = fromClause;
            this.joinClosure = joinClosure;
            this.subqueryWithAliasBuilder = subqueryWithAliasBuilder;
        }

        public TSubqueryWithAlias Subquery()
        {
            Statement.Append((IEndSubquery<TSubqueryWithAlias> input) => input.Subquery());
            return subqueryWithAliasBuilder(fromClause, joinClosure);
        }
    }
}
