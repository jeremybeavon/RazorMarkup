using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Query.GroupBy;

namespace RazorMarkup.Database.SqlServer.Parser.Query.GroupBy
{
    internal sealed class GroupByAnd<TEndType> : AbstractGroupBy, ICommonGroupBy
    {
        private readonly IGroupByAnd<TEndType> groupBy;

        public GroupByAnd(IGroupByAnd<TEndType> groupBy)
            : base(groupBy)
        {
            this.groupBy = groupBy;
        }

        public override ICommonGroupBy GroupBy(Expression<Func<object>> expression)
        {
            return new GroupByAnd<TEndType>(groupBy.And(expression));
        }

        public override ICommonGroupBy GrandTotal()
        {
            return new GroupByAnd<TEndType>(groupBy.And().GrandTotal());
        }
    }
}
