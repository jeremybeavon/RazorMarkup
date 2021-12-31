using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ServerSqlModules
    {
        public static readonly ViewName ViewName = new("sys.server_sql_modules");

        public static readonly Column<SqlNVarchar> Definition = new("definition");

        public static readonly Column<SqlInt> ExecuteAsPrincipalId = new("execute_as_principal_id");

        public static readonly Column<SqlInt> ObjectId = new("object_id");

        public static readonly Column<SqlBit> UsesAnsiNulls = new("uses_ansi_nulls");

        public static readonly Column<SqlBit> UsesQuotedIdentifier = new("uses_quoted_identifier");
    }
}
