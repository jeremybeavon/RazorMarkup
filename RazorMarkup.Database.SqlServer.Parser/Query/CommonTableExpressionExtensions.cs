using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Query;
using RazorMarkup.Database.SqlServer.Query.CommonTableExpressions;

namespace RazorMarkup.Database.SqlServer.Parser.Query
{
    internal static class CommonTableExpressionExtensions
    {
        public static IEndCommonTableExpression As(this ICommonTableExpression expression, QueryExpression query)
        {
            return query.AcceptWithResult(expression.As()).End().With();
        }
    }
}
