using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Views
    {
        public static readonly ViewName ViewName = new("INFORMATION_SCHEMA.VIEWS");

        public static readonly Column<SqlVarchar> CheckOption = new("CHECK_OPTION");

        public static readonly Column<SqlVarchar> IsUpdatable = new("IS_UPDATABLE");

        public static readonly Column<SqlNVarchar> TableCatalog = new("TABLE_CATALOG");

        public static readonly Column<SqlSysname> TableName = new("TABLE_NAME");

        public static readonly Column<SqlNVarchar> TableSchema = new("TABLE_SCHEMA");

        public static readonly Column<SqlNVarchar> ViewDefinition = new("VIEW_DEFINITION");
    }
}
