using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.GroupBy;

namespace RazorMarkup.Database.SqlServer.Parser.Query.GroupBy
{
    internal sealed class GroupByRollupFunction<TEndRollupType> : AbstractGroupBy
    {
        private readonly IGroupByRollupFunction<TEndRollupType> groupBy;

        public GroupByRollupFunction(IGroupByRollupFunction<TEndRollupType> groupBy)
            : base(groupBy)
        {
            this.groupBy = groupBy;
        }

        public override ICommonGroupBy GroupBy(Expression<Func<object>> expression)
        {
            return new GroupByGroup<IGroupByRollup<TEndRollupType>>(groupBy.Group(expression));
        }
    }
}
