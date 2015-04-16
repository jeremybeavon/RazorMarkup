using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Query.GroupBy;

namespace RazorMarkup.Database.SqlServer.Parser.Query.GroupBy
{
    internal sealed class GroupByRollup<TEndRollupType> : AbstractGroupBy
    {
        private readonly IGroupByRollup<TEndRollupType> groupByRollup;

        public GroupByRollup(IGroupByRollup<TEndRollupType> groupByRollup)
            : base(groupByRollup)
        {
            this.groupByRollup = groupByRollup;
        }

        public override ICommonGroupBy GroupBy(Expression<Func<object>> expression)
        {
            return new GroupByRollup<TEndRollupType>(groupByRollup.And(expression));
        }

        public override ICommonGroupBy Group(IList<GroupingSpecification> arguments)
        {
            ICommonGroupBy end = arguments.AcceptWithResult(new GroupByRollupFunction<TEndRollupType>(groupByRollup.And()));
            return new GroupByRollup<TEndRollupType>(end.End<IGroupByGroup<IGroupByRollup<TEndRollupType>>>().EndGroup());
        }
    }
}
