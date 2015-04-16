using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Query.GroupBy;

namespace RazorMarkup.Database.SqlServer.Parser.Query.GroupBy
{
    internal sealed class GroupByGroupingSetFunction<TEndGroupingSetType> : AbstractGroupBy
    {
        private readonly IGroupByGroupingSetFunction<TEndGroupingSetType> groupBy;
        private readonly GroupByFunctionType groupByFunctionType;

        public GroupByGroupingSetFunction(
            IGroupByGroupingSetFunction<TEndGroupingSetType> groupBy,
            GroupByFunctionType groupByFunctionType)
            : base(groupBy)
        {
            this.groupBy = groupBy;
            this.groupByFunctionType = groupByFunctionType;
        }

        public override ICommonGroupBy GroupBy(Expression<Func<object>> expression)
        {
            switch (groupByFunctionType)
            {
                case GroupByFunctionType.Group:
                    return new GroupByGroup<IGroupByGroupingSet<TEndGroupingSetType>>(groupBy.Group(expression));
                case GroupByFunctionType.Cube:
                    return new GroupByCube<IGroupByGroupingSet<TEndGroupingSetType>>(groupBy.Cube(expression));
                case GroupByFunctionType.Rollup:
                    return new GroupByRollup<IGroupByGroupingSet<TEndGroupingSetType>>(groupBy.Rollup(expression));
            }

            return base.GroupBy(expression);
        }

        public override ICommonGroupBy Group(IList<GroupingSpecification> arguments)
        {
            ICommonGroupBy end = arguments.AcceptWithResult(groupBy, GroupByFunctionType.Group);
            return new GroupByGroupingSet<TEndGroupingSetType>(
                end.End<IGroupByGroup<IGroupByGroupingSet<TEndGroupingSetType>>>().EndGroup());
        }

        public override ICommonGroupBy Cube(IList<GroupingSpecification> arguments)
        {
            ICommonGroupBy end = arguments.AcceptWithResult(groupBy, GroupByFunctionType.Cube);
            return new GroupByGroupingSet<TEndGroupingSetType>(
                end.End<IGroupByCube<IGroupByGroupingSet<TEndGroupingSetType>>>().EndCube());
        }

        public override ICommonGroupBy Rollup(IList<GroupingSpecification> arguments)
        {
            ICommonGroupBy end = arguments.AcceptWithResult(groupBy, GroupByFunctionType.Rollup);
            return new GroupByGroupingSet<TEndGroupingSetType>(
                end.End<IGroupByRollup<IGroupByGroupingSet<TEndGroupingSetType>>>().EndRollup());
        }

        public override ICommonGroupBy GrandTotal()
        {
            return new GroupByGroupingSet<TEndGroupingSetType>(groupBy.GrandTotal());
        }
    }
}
