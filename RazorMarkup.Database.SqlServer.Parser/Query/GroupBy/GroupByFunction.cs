using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Query.GroupBy;

namespace RazorMarkup.Database.SqlServer.Parser.Query.GroupBy
{
    internal sealed class GroupByFunction<TEndType> : AbstractGroupBy
    {
        private readonly IGroupByFunction<TEndType> groupBy;
        private readonly GroupByFunctionType groupByFunctionType;

        public GroupByFunction(IGroupByFunction<TEndType> groupBy, GroupByFunctionType groupByFunctionType)
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
                    return new GroupByCube<IGroupByAnd<TEndType>>(groupBy.Cube(expression));
                case GroupByFunctionType.Group:
                    return new GroupByGroup<IGroupByAnd<TEndType>>(groupBy.Group(expression));
                case GroupByFunctionType.GroupingSet:
                    return new GroupByGroupingSet<TEndType>(groupBy.GroupingSet(expression));
                case GroupByFunctionType.Rollup:
                    return new GroupByRollup<IGroupByAnd<TEndType>>(groupBy.Rollup(expression));
            }

            return base.GroupBy(expression);
        }

        public override ICommonGroupBy Group(IList<GroupingSpecification> arguments)
        {
            ICommonGroupBy end;
            switch (groupByFunctionType)
            {
                case GroupByFunctionType.Cube:
                    end = arguments.AcceptWithResult(new GroupByCubeFunction<IGroupByAnd<TEndType>>(groupBy.Cube()));
                    return new GroupByAnd<TEndType>(end.End<IGroupByCube<IGroupByAnd<TEndType>>>().EndCube());
                case GroupByFunctionType.Rollup:
                    end = arguments.AcceptWithResult(new GroupByRollupFunction<IGroupByAnd<TEndType>>(groupBy.Rollup()));
                    return new GroupByAnd<TEndType>(end.End<IGroupByRollup<IGroupByAnd<TEndType>>>().EndRollup());
                case GroupByFunctionType.GroupingSet:
                    end = arguments.AcceptWithResult(
                        new GroupByGroupingSetFunction<TEndType>(groupBy.GroupingSet(), GroupByFunctionType.GroupingSet));
                    return new GroupByAnd<TEndType>(end.End<IGroupByGroupingSet<TEndType>>().EndGroupingSet());
            }
                
            return base.Group(arguments);
        }

        private TEndGroupType EndGroup<TEndGroupType>(ICommonGroupBy end)
        {
            return end.End<IGroupByGroup<TEndGroupType>>().EndGroup();
        }
    }
}
