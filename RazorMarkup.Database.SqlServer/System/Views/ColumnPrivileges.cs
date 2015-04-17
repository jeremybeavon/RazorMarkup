using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ColumnPrivileges
    {
        public static readonly ViewName ViewName = new ViewName("INFORMATION_SCHEMA.COLUMN_PRIVILEGES");
        
        public static readonly Column<SqlSysname> ColumnName = new Column<SqlSysname>("COLUMN_NAME");
        
        public static readonly Column<SqlNVarchar> Grantee = new Column<SqlNVarchar>("GRANTEE");
        
        public static readonly Column<SqlNVarchar> Grantor = new Column<SqlNVarchar>("GRANTOR");
        
        public static readonly Column<SqlVarchar> IsGrantable = new Column<SqlVarchar>("IS_GRANTABLE");
        
        public static readonly Column<SqlVarchar> PrivilegeType = new Column<SqlVarchar>("PRIVILEGE_TYPE");
        
        public static readonly Column<SqlNVarchar> TableCatalog = new Column<SqlNVarchar>("TABLE_CATALOG");
        
        public static readonly Column<SqlSysname> TableName = new Column<SqlSysname>("TABLE_NAME");
        
        public static readonly Column<SqlNVarchar> TableSchema = new Column<SqlNVarchar>("TABLE_SCHEMA");
    }
}
