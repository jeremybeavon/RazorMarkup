using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ColumnDomainUsage
    {
        public static readonly ViewName ViewName = new ViewName("INFORMATION_SCHEMA.COLUMN_DOMAIN_USAGE");
        
        public static readonly Column<SqlSysname> ColumnName = new Column<SqlSysname>("COLUMN_NAME");
        
        public static readonly Column<SqlNVarchar> DomainCatalog = new Column<SqlNVarchar>("DOMAIN_CATALOG");
        
        public static readonly Column<SqlSysname> DomainName = new Column<SqlSysname>("DOMAIN_NAME");
        
        public static readonly Column<SqlNVarchar> DomainSchema = new Column<SqlNVarchar>("DOMAIN_SCHEMA");
        
        public static readonly Column<SqlNVarchar> TableCatalog = new Column<SqlNVarchar>("TABLE_CATALOG");
        
        public static readonly Column<SqlSysname> TableName = new Column<SqlSysname>("TABLE_NAME");
        
        public static readonly Column<SqlNVarchar> TableSchema = new Column<SqlNVarchar>("TABLE_SCHEMA");
    }
}
