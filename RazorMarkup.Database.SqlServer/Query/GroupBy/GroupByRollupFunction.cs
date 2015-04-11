using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Query.GroupBy
{
    internal class GroupByRollupFunction<TEndRollupType> : AbstractStatement<GroupFunctionQueryBuilder>,
        IGroupByRollupFunction<TEndRollupType>
    {
        private readonly TEndRollupType rollupClosure;

        public GroupByRollupFunction(GroupFunctionQueryBuilder statement, TEndRollupType rollupClosure)
            : base(statement)
        {
            this.rollupClosure = rollupClosure;
        }

        public IGroupByGroup<IGroupByRollup<TEndRollupType>> Group(Expression<Func<object>> groupingExpression)
        {
            GroupByGroupQueryBuilder queryBuilder = new GroupByGroupQueryBuilder();
            Statement.Groupings.Add(queryBuilder);
            Statement.Append((IGroupByRollupFunction<TEndRollupType> input) => input.Group(null), groupingExpression);
            IGroupByRollup<TEndRollupType> groupClosure = new GroupByRollup<TEndRollupType>(Statement, rollupClosure);
            return new GroupByGroup<IGroupByRollup<TEndRollupType>>(queryBuilder, groupClosure);
        }
    }
}
