using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Tables
    {
        public static readonly ViewName ViewName = new("INFORMATION_SCHEMA.TABLES");

        public static readonly Column<SqlNVarchar> TableCatalog = new("TABLE_CATALOG");

        public static readonly Column<SqlSysname> TableName = new("TABLE_NAME");

        public static readonly Column<SqlSysname> TableSchema = new("TABLE_SCHEMA");

        public static readonly Column<SqlVarchar> TableType = new("TABLE_TYPE");
    }
}
