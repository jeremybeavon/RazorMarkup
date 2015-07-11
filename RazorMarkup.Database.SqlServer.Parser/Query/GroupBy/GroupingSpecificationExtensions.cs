using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Query.GroupBy;

namespace RazorMarkup.Database.SqlServer.Parser.Query.GroupBy
{
    internal static class GroupingSpecificationExtensions
    {
        public static ICommonGroupBy AcceptWithResult(this IList<GroupingSpecification> groups, ICommonGroupBy groupBy)
        {
            foreach (GroupingSpecification group in groups)
            {
                groupBy = group.AcceptWithResult(new GroupingSpecificationVisitor(groupBy));
            }

            return groupBy;
        }

        public static ICommonGroupBy AcceptWithResult<TEndType>(
            this IList<GroupingSpecification> groups,
            IGroupByFunction<TEndType> groupBy,
            GroupByFunctionType groupByFunctionType)
        {
            return groups.AcceptWithResult(new GroupByFunction<TEndType>(groupBy, groupByFunctionType));
        }

        public static ICommonGroupBy AcceptWithResult<TEndType>(
            this IList<GroupingSpecification> groups,
            IGroupByGroupingSetsFunction<TEndType> groupBy,
            GroupByFunctionType groupByFunctionType)
        {
            return groups.AcceptWithResult(new GroupByGroupingSetFunction<TEndType>(groupBy, groupByFunctionType));
        }
    }
}
