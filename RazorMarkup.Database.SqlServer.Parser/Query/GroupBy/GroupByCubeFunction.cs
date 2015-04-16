using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.GroupBy;

namespace RazorMarkup.Database.SqlServer.Parser.Query.GroupBy
{
    internal sealed class GroupByCubeFunction<TEndCubeType> : AbstractGroupBy
    {
        private readonly IGroupByCubeFunction<TEndCubeType> groupBy;

        public GroupByCubeFunction(IGroupByCubeFunction<TEndCubeType> groupBy)
            : base(groupBy)
        {
            this.groupBy = groupBy;
        }

        public override ICommonGroupBy GroupBy(Expression<Func<object>> expression)
        {
            return new GroupByGroup<IGroupByCube<TEndCubeType>>(groupBy.Group(expression));
        }
    }
}
