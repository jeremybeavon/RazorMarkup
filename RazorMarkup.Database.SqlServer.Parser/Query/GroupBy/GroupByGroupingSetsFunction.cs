﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Query.GroupBy;

namespace RazorMarkup.Database.SqlServer.Parser.Query.GroupBy
{
    internal sealed class GroupByGroupingSetsFunction<TEndGroupingSetType> : AbstractGroupBy
    {
        private readonly IGroupByGroupingSetsFunction<TEndGroupingSetType> groupBy;
        private readonly GroupByFunctionType groupByFunctionType;

        public GroupByGroupingSetsFunction(
            IGroupByGroupingSetsFunction<TEndGroupingSetType> groupBy,
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
                case GroupByFunctionType.Cube:
                    return new GroupByCube<IGroupByGroupingSets<TEndGroupingSetType>>(groupBy.Cube(expression));
                case GroupByFunctionType.Rollup:
                    return new GroupByRollup<IGroupByGroupingSets<TEndGroupingSetType>>(groupBy.Rollup(expression));
            }

            return base.GroupBy(expression);
        }

        public override ICommonGroupBy Group(IList<GroupingSpecification> arguments)
        {
            ICommonGroupBy end = arguments.AcceptWithResult(groupBy, GroupByFunctionType.Group);
            return new GroupByGroupingSets<TEndGroupingSetType>(
                end.End<IGroupByGroup<IGroupByGroupingSets<TEndGroupingSetType>>>().EndGroup());
        }

        public override ICommonGroupBy Cube(IList<GroupingSpecification> arguments)
        {
            ICommonGroupBy end = arguments.AcceptWithResult(groupBy, GroupByFunctionType.Cube);
            return new GroupByGroupingSets<TEndGroupingSetType>(
                end.End<IGroupByCube<IGroupByGroupingSets<TEndGroupingSetType>>>().EndCube());
        }

        public override ICommonGroupBy Rollup(IList<GroupingSpecification> arguments)
        {
            ICommonGroupBy end = arguments.AcceptWithResult(groupBy, GroupByFunctionType.Rollup);
            return new GroupByGroupingSets<TEndGroupingSetType>(
                end.End<IGroupByRollup<IGroupByGroupingSets<TEndGroupingSetType>>>().EndRollup());
        }

        public override ICommonGroupBy GrandTotal()
        {
            return new GroupByGroupingSets<TEndGroupingSetType>(groupBy.GrandTotal());
        }
    }
}
