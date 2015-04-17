using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Views
    {
        public static readonly ViewName ViewName = new ViewName("INFORMATION_SCHEMA.VIEWS");
        
        public static readonly Column<SqlVarchar> CheckOption = new Column<SqlVarchar>("CHECK_OPTION");
        
        public static readonly Column<SqlVarchar> IsUpdatable = new Column<SqlVarchar>("IS_UPDATABLE");
        
        public static readonly Column<SqlNVarchar> TableCatalog = new Column<SqlNVarchar>("TABLE_CATALOG");
        
        public static readonly Column<SqlSysname> TableName = new Column<SqlSysname>("TABLE_NAME");
        
        public static readonly Column<SqlNVarchar> TableSchema = new Column<SqlNVarchar>("TABLE_SCHEMA");
        
        public static readonly Column<SqlNVarchar> ViewDefinition = new Column<SqlNVarchar>("VIEW_DEFINITION");
    }
}
