using System;
using System.Linq.Expressions;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Query.Select;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Parser.Query.Select
{
    internal static class SelectClauseWithTopExtensions
    {
        public static ISelectClause<TEndType> BuildTop<TEndType>(
            this ISelectClauseWithTop<TEndType> select,
            QuerySpecification node)
        {
            TopRowFilter topRowFilter = node.TopRowFilter;
            if (topRowFilter == null)
            {
                return select;
            }

            Expression<Func<Integer>> count = topRowFilter.Expression.ToExpression<Integer>();
            ISelectClauseWithPercent<TEndType> selectWithPercent = select.Top(count);
            ISelectClauseWithTies<TEndType> selectWithTies = selectWithPercent;
            if (topRowFilter.Percent)
            {
                selectWithTies = selectWithPercent.Percent();
            }

            return topRowFilter.WithTies ? selectWithTies.WithTies() : selectWithTies;
        }
    }
}
