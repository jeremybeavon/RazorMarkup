using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Tables
    {
        public static readonly ViewName ViewName = new ViewName("INFORMATION_SCHEMA.TABLES");
        
        public static readonly Column<SqlNVarchar> TableCatalog = new Column<SqlNVarchar>("TABLE_CATALOG");
        
        public static readonly Column<SqlSysname> TableName = new Column<SqlSysname>("TABLE_NAME");
        
        public static readonly Column<SqlSysname> TableSchema = new Column<SqlSysname>("TABLE_SCHEMA");
        
        public static readonly Column<SqlVarchar> TableType = new Column<SqlVarchar>("TABLE_TYPE");
    }
}
