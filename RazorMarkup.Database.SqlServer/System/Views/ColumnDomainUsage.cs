using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ColumnDomainUsage
    {
        public static readonly ViewName ViewName = new("INFORMATION_SCHEMA.COLUMN_DOMAIN_USAGE");

        public static readonly Column<SqlSysname> ColumnName = new("COLUMN_NAME");

        public static readonly Column<SqlNVarchar> DomainCatalog = new("DOMAIN_CATALOG");

        public static readonly Column<SqlSysname> DomainName = new("DOMAIN_NAME");

        public static readonly Column<SqlNVarchar> DomainSchema = new("DOMAIN_SCHEMA");

        public static readonly Column<SqlNVarchar> TableCatalog = new("TABLE_CATALOG");

        public static readonly Column<SqlSysname> TableName = new("TABLE_NAME");

        public static readonly Column<SqlNVarchar> TableSchema = new("TABLE_SCHEMA");
    }
}
