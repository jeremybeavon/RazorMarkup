using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types;

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
            return this;
        }

        public TEndGroupType EndGroup()
        {
            return groupClosure;
        }
    }
}
