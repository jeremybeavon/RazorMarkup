using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Query.Select;

namespace RazorMarkup.Database.SqlServer.Parser.Query.Select
{
    internal static class SelectClauseExtensions
    {
        public static ISelectClauseWithInto<TEndType> BuildColumns<TEndType>(
            this ISelectClause<TEndType> select,
            QuerySpecification node)
        {
            return new SelectClauseVisitor<TEndType>(select, node.SelectElements).Result;
        }
    }
}
