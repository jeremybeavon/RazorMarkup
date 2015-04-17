using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ServerSqlModules
    {
        public static readonly ViewName ViewName = new ViewName("sys.server_sql_modules");
        
        public static readonly Column<SqlNVarchar> Definition = new Column<SqlNVarchar>("definition");
        
        public static readonly Column<SqlInt> ExecuteAsPrincipalId = new Column<SqlInt>("execute_as_principal_id");
        
        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");
        
        public static readonly Column<SqlBit> UsesAnsiNulls = new Column<SqlBit>("uses_ansi_nulls");
        
        public static readonly Column<SqlBit> UsesQuotedIdentifier = new Column<SqlBit>("uses_quoted_identifier");
    }
}
