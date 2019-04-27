using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query.GroupBy
{
    internal class GroupByGroup<TEndGroupType> : AbstractStatement<GroupByGroupQueryBuilder>,
        IGroupByGroup<TEndGroupType>
    {
        private readonly TEndGroupType groupClosure;

        public GroupByGroup(GroupByGroupQueryBuilder statement, TEndGroupType groupClosure)
            : base(statement)
        {
            this.groupClosure = groupClosure;
        }

        public IGroupByGroup<TEndGroupType> And(Expression<Func<object>> groupingExpression)
        {
            Statement.Groupings.Add(new ExpressionBuilder<object>(groupingExpression));
            Statement.Append((IGroupByGroup<TEndGroupType> input) => input.And(null), groupingExpression);
            return this;
        }

        public TEndGroupType EndGroup()
        {
            Statement.Append((IGroupByGroup<TEndGroupType> input) => input.EndGroup());
            return groupClosure;
        }
    }
}
