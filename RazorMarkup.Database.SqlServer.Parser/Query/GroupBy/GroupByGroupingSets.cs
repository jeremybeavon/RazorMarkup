using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Query.GroupBy;

namespace RazorMarkup.Database.SqlServer.Parser.Query.GroupBy
{
    internal sealed class GroupByGroupingSets<TEndGroupingSetType> : AbstractGroupBy
    {
        private readonly IGroupByGroupingSets<TEndGroupingSetType> groupByGroupingSets;

        public GroupByGroupingSets(IGroupByGroupingSets<TEndGroupingSetType> groupByGroupingSets)
            : base(groupByGroupingSets)
        {
            this.groupByGroupingSets = groupByGroupingSets;
        }

        public override ICommonGroupBy GroupBy(Expression<Func<object>> expression)
        {
            return new GroupByGroupingSets<TEndGroupingSetType>(groupByGroupingSets.And(expression));
        }

        public override ICommonGroupBy Group(IList<GroupingSpecification> arguments)
        {
            ICommonGroupBy end = arguments.AcceptWithResult(groupByGroupingSets.And(), GroupByFunctionType.GroupingSets);
            return new GroupByGroupingSets<TEndGroupingSetType>(
                end.End<IGroupByGroup<IGroupByGroupingSets<TEndGroupingSetType>>>().EndGroup());
        }
    }
}
