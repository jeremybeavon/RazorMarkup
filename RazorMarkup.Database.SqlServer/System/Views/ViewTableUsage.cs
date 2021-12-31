using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ViewTableUsage
    {
        public static readonly ViewName ViewName = new("INFORMATION_SCHEMA.VIEW_TABLE_USAGE");

        public static readonly Column<SqlNVarchar> TableCatalog = new("TABLE_CATALOG");

        public static readonly Column<SqlSysname> TableName = new("TABLE_NAME");

        public static readonly Column<SqlNVarchar> TableSchema = new("TABLE_SCHEMA");

        public static readonly Column<SqlNVarchar> ViewCatalog = new("VIEW_CATALOG");

        public static readonly Column<SqlSysname> ViewNameColumn = new("VIEW_NAME");

        public static readonly Column<SqlNVarchar> ViewSchema = new("VIEW_SCHEMA");
    }
}
