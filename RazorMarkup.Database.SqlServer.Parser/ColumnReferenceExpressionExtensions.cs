using System.Linq;
using Microsoft.SqlServer.TransactSql.ScriptDom;

namespace RazorMarkup.Database.SqlServer.Parser
{
    internal static class ColumnReferenceExpressionExtensions
    {
        public static ColumnName ToColumnName(this ColumnReferenceExpression expression)
        {
            return new ColumnName(string.Join(".", expression.MultiPartIdentifier.Identifiers.Select(part => part.Value)));
        }
    }
}
