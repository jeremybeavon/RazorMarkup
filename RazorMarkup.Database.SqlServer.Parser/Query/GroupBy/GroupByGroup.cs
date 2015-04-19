using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Query.GroupBy;

namespace RazorMarkup.Database.SqlServer.Parser.Query.GroupBy
{
    internal sealed class GroupByGroup<TEndGroupType> : AbstractGroupBy, ICommonGroupBy
    {
        private readonly IGroupByGroup<TEndGroupType> groupBy;

        public GroupByGroup(IGroupByGroup<TEndGroupType> groupBy)
            : base(groupBy)
        {
            this.groupBy = groupBy;
        }

        public override ICommonGroupBy GroupBy(Expression<Func<object>> expression)
        {
            return new GroupByGroup<TEndGroupType>(groupBy.And(expression));
        }
    }
}
