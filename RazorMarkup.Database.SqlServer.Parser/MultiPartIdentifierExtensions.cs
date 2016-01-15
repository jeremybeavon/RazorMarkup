using System.Linq;
using Microsoft.SqlServer.TransactSql.ScriptDom;

namespace RazorMarkup.Database.SqlServer.Parser
{
    internal static class MultiPartIdentifierExtensions
    {
        public static TableName ToTableName(this MultiPartIdentifier identifier)
        {
            return new TableName(string.Join(".", identifier.Identifiers.Select(part => part.Value)));
        }

        public static ClrColumnName ToClrColumnName(this MultiPartIdentifier identifier)
        {
            return new ClrColumnName(string.Join(".", identifier.Identifiers.Select(part => part.Value)));
        }
    }
}
