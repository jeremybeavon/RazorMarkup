using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Query;

namespace RazorMarkup.Database.SqlServer.Parser.Query.GroupBy
{
    public interface ICommonGroupBy
    {
        ICommonGroupBy GroupBy(Expression<Func<object>> expression);

        ICommonGroupBy Group(IList<GroupingSpecification> arguments);

        ICommonGroupBy Cube(IList<GroupingSpecification> arguments);

        ICommonGroupBy Rollup(IList<GroupingSpecification> arguments);

        ICommonGroupBy GrandTotal();

        ICommonGroupBy GroupingSet(IList<GroupingSpecification> arguments);

        TEndType End<TEndType>();
    }
}
