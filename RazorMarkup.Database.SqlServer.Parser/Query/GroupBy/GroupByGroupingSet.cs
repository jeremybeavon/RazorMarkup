using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Query.GroupBy;

namespace RazorMarkup.Database.SqlServer.Parser.Query.GroupBy
{
    internal sealed class GroupByGroupingSet<TEndGroupingSetType> : AbstractGroupBy
    {
        private readonly IGroupByGroupingSets<TEndGroupingSetType> groupByGroupingSet;

        public GroupByGroupingSet(IGroupByGroupingSets<TEndGroupingSetType> groupByGroupingSet)
            : base(groupByGroupingSet)
        {
            this.groupByGroupingSet = groupByGroupingSet;
        }

        public override ICommonGroupBy GroupBy(Expression<Func<object>> expression)
        {
            return new GroupByGroupingSet<TEndGroupingSetType>(groupByGroupingSet.And(expression));
        }

        public override ICommonGroupBy Group(IList<GroupingSpecification> arguments)
        {
            ICommonGroupBy end = arguments.AcceptWithResult(groupByGroupingSet.And(), GroupByFunctionType.GroupingSet);
            return new GroupByGroupingSet<TEndGroupingSetType>(
                end.End<IGroupByGroup<IGroupByGroupingSets<TEndGroupingSetType>>>().EndGroup());
        }
    }
}
