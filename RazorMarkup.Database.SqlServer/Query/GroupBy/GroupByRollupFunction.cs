using System;
using System.Linq.Expressions;

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
            Statement.Append((IGroupByRollupFunction<TEndRollupType> input) => input.Group(null), groupingExpression);
            GroupByGroupQueryBuilder queryBuilder = new(ExpressionBuilder);
            Statement.Groupings.Add(queryBuilder);
            queryBuilder.Groupings.Add(new ExpressionBuilder<object>(groupingExpression));
            GroupByRollup<TEndRollupType> groupClosure = new(Statement, rollupClosure);
            return new GroupByGroup<IGroupByRollup<TEndRollupType>>(queryBuilder, groupClosure);
        }
    }
}
