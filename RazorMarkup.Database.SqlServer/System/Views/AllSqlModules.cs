using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class AllSqlModules
    {
        public static readonly ViewName ViewName = new ViewName("sys.all_sql_modules");
        
        public static readonly Column<SqlNVarchar> Definition = new Column<SqlNVarchar>("definition");
        
        public static readonly Column<SqlInt> ExecuteAsPrincipalId = new Column<SqlInt>("execute_as_principal_id");
        
        public static readonly Column<SqlBit> IsRecompiled = new Column<SqlBit>("is_recompiled");
        
        public static readonly Column<SqlBit> IsSchemaBound = new Column<SqlBit>("is_schema_bound");
        
        public static readonly Column<SqlBit> NullOnNullInput = new Column<SqlBit>("null_on_null_input");
        
        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");
        
        public static readonly Column<SqlBit> UsesAnsiNulls = new Column<SqlBit>("uses_ansi_nulls");
        
        public static readonly Column<SqlBit> UsesDatabaseCollation = new Column<SqlBit>("uses_database_collation");
        
        public static readonly Column<SqlBit> UsesQuotedIdentifier = new Column<SqlBit>("uses_quoted_identifier");
    }
}
