using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SystemSqlModules
    {
        public static readonly ViewName ViewName = new("sys.system_sql_modules");

        public static readonly Column<SqlNVarchar> Definition = new("definition");

        public static readonly Column<SqlInt> ExecuteAsPrincipalId = new("execute_as_principal_id");

        public static readonly Column<SqlBit> IsRecompiled = new("is_recompiled");

        public static readonly Column<SqlBit> IsSchemaBound = new("is_schema_bound");

        public static readonly Column<SqlBit> NullOnNullInput = new("null_on_null_input");

        public static readonly Column<SqlInt> ObjectId = new("object_id");

        public static readonly Column<SqlBit> UsesAnsiNulls = new("uses_ansi_nulls");

        public static readonly Column<SqlBit> UsesDatabaseCollation = new("uses_database_collation");

        public static readonly Column<SqlBit> UsesQuotedIdentifier = new("uses_quoted_identifier");
    }
}
