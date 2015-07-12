using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Query;
using RazorMarkup.Database.SqlServer.Query.GroupBy;

namespace RazorMarkup.Database.SqlServer.Parser.Query.GroupBy
{
    internal sealed class GroupByClause<TEndType> : AbstractGroupBy, ICommonGroupBy
    {
        private readonly IGroupByClause<TEndType> groupByClause;

        public GroupByClause(IGroupByClause<TEndType> groupByClause)
            : base(groupByClause)
        {
            this.groupByClause = groupByClause;
        }

        public override ICommonGroupBy GroupBy(Expression<Func<object>> expression)
        {
            return new GroupByAnd<TEndType>(groupByClause.GroupBy(expression));
        }

        public override ICommonGroupBy Group(IList<GroupingSpecification> arguments)
        {
            ICommonGroupBy end = arguments.AcceptWithResult(groupByClause.GroupBy(), GroupByFunctionType.Group);
            return new GroupByAnd<TEndType>(end.End<IGroupByGroup<IGroupByAnd<TEndType>>>().EndGroup());
        }

        public override ICommonGroupBy Cube(IList<GroupingSpecification> arguments)
        {
            ICommonGroupBy end = arguments.AcceptWithResult(groupByClause.GroupBy(), GroupByFunctionType.Cube);
            return new GroupByAnd<TEndType>(end.End<IGroupByCube<IGroupByAnd<TEndType>>>().EndCube());
        }

        public override ICommonGroupBy Rollup(IList<GroupingSpecification> arguments)
        {
            ICommonGroupBy end = arguments.AcceptWithResult(groupByClause.GroupBy(), GroupByFunctionType.Rollup);
            return new GroupByAnd<TEndType>(end.End<IGroupByRollup<IGroupByAnd<TEndType>>>().EndRollup());
        }

        public override ICommonGroupBy GroupingSet(IList<GroupingSpecification> arguments)
        {
            ICommonGroupBy end = arguments.AcceptWithResult(groupByClause.GroupBy(), GroupByFunctionType.GroupingSets);
            return new GroupByAnd<TEndType>(end.End<IGroupByGroupingSets<TEndType>>().EndGroupingSets());
        }

        public override ICommonGroupBy GrandTotal()
        {
            return new GroupByAnd<TEndType>(groupByClause.GroupBy().GrandTotal());
        }
    }
}
