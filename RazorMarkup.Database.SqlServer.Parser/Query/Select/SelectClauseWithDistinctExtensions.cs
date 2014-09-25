using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Query.Select;

namespace RazorMarkup.Database.SqlServer.Parser.Query.Select
{
    internal static class SelectClauseWithDistinctExtensions
    {
        public static ISelectClauseWithTop<TEndType> BuildAllOrDistinct<TEndType>(
            this ISelectClauseWithDistinct<TEndType> select,
            QuerySpecification node)
        {
            switch (node.UniqueRowFilter)
            {
                case UniqueRowFilter.All:
                    return select.All();
                case UniqueRowFilter.Distinct:
                    return select.Distinct();
                default:
                    return select;
            }
        }
    }
}
