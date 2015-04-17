using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ViewColumnUsage
    {
        public static readonly ViewName ViewName = new ViewName("INFORMATION_SCHEMA.VIEW_COLUMN_USAGE");
        
        public static readonly Column<SqlSysname> ColumnName = new Column<SqlSysname>("COLUMN_NAME");
        
        public static readonly Column<SqlNVarchar> TableCatalog = new Column<SqlNVarchar>("TABLE_CATALOG");
        
        public static readonly Column<SqlSysname> TableName = new Column<SqlSysname>("TABLE_NAME");
        
        public static readonly Column<SqlNVarchar> TableSchema = new Column<SqlNVarchar>("TABLE_SCHEMA");
        
        public static readonly Column<SqlNVarchar> ViewCatalog = new Column<SqlNVarchar>("VIEW_CATALOG");
        
        public static readonly Column<SqlSysname> ViewNameColumn = new Column<SqlSysname>("VIEW_NAME");
        
        public static readonly Column<SqlNVarchar> ViewSchema = new Column<SqlNVarchar>("VIEW_SCHEMA");
    }
}
