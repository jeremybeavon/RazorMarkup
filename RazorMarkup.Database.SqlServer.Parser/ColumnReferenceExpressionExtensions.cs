using System.Linq;
using Microsoft.SqlServer.TransactSql.ScriptDom;

namespace RazorMarkup.Database.SqlServer.Parser
{
    internal static class ColumnReferenceExpressionExtensions
    {
        public static ColumnName ToColumnName(this ColumnReferenceExpression expression)
        {
            return new ColumnName(ToColumnNameText(expression));
        }

        public static string ToColumnNameText(this ColumnReferenceExpression expression)
        {
            return string.Join(".", expression.MultiPartIdentifier.Identifiers.Select(part => part.Value));
        }
    }
}
