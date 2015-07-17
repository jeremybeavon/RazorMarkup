using Microsoft.SqlServer.TransactSql.ScriptDom;

namespace RazorMarkup.Database.SqlServer.Parser
{
    internal static class IdentifierOrValueExpressionExtensions
    {
        public static ColumnAlias ToColumnAlias(this IdentifierOrValueExpression node)
        {
            return new ColumnAlias(node.Identifier == null ? node.Value : node.Identifier.Value);
        }
    }
}
