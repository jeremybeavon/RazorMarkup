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
                case GroupByFunctionType.GroupingSets:
                    return new GroupByGroupingSets<TEndType>(groupBy.GroupingSets(expression));
                case GroupByFunctionType.Rollup:
                    return new GroupByRollup<IGroupByAnd<TEndType>>(groupBy.Rollup(expression));
            }

            return base.GroupBy(expression);
        }

        public override ICommonGroupBy Cube(IList<GroupingSpecification> arguments)
        {
            ICommonGroupBy end = arguments.AcceptWithResult(groupBy.GroupingSets(), GroupByFunctionType.Cube);
            return new GroupByGroupingSets<TEndType>(end.End<IGroupByCube<IGroupByGroupingSets<TEndType>>>().EndCube());
        }

        public override ICommonGroupBy Rollup(IList<GroupingSpecification> arguments)
        {
            ICommonGroupBy end = arguments.AcceptWithResult(groupBy.GroupingSets(), GroupByFunctionType.Rollup);
            return new GroupByGroupingSets<TEndType>(end.End<IGroupByRollup<IGroupByGroupingSets<TEndType>>>().EndRollup());
        }   

        public override ICommonGroupBy Group(IList<GroupingSpecification> arguments)
        {
            ICommonGroupBy end;
            switch (groupByFunctionType)
            {
                case GroupByFunctionType.Cube:
                    end = arguments.AcceptWithResult(new GroupByCubeFunction<IGroupByAnd<TEndType>>(groupBy.Cube()));
                    return new GroupByCube<IGroupByAnd<TEndType>>(end.End<IGroupByGroup<IGroupByCube<IGroupByAnd<TEndType>>>>().EndGroup());
                case GroupByFunctionType.Rollup:
                    end = arguments.AcceptWithResult(new GroupByRollupFunction<IGroupByAnd<TEndType>>(groupBy.Rollup()));
                    return new GroupByRollup<IGroupByAnd<TEndType>>(end.End<IGroupByGroup<IGroupByRollup<IGroupByAnd<TEndType>>>>().EndGroup());
                case GroupByFunctionType.GroupingSets:
                    end = arguments.AcceptWithResult(
                        new GroupByGroupingSetsFunction<TEndType>(groupBy.GroupingSets(), GroupByFunctionType.GroupingSets));
                    return new GroupByGroupingSets<TEndType>(end.End<IGroupByGroup<IGroupByGroupingSets<TEndType>>>().EndGroup());
            }
                
            return base.Group(arguments);
        }

        private TEndGroupType EndGroup<TEndGroupType>(ICommonGroupBy end)
        {
            return end.End<IGroupByGroup<TEndGroupType>>().EndGroup();
        }
    }
}
