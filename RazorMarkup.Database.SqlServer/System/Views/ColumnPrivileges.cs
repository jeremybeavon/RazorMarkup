using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ColumnPrivileges
    {
        public static readonly ViewName ViewName = new("INFORMATION_SCHEMA.COLUMN_PRIVILEGES");

        public static readonly Column<SqlSysname> ColumnName = new("COLUMN_NAME");

        public static readonly Column<SqlNVarchar> Grantee = new("GRANTEE");

        public static readonly Column<SqlNVarchar> Grantor = new("GRANTOR");

        public static readonly Column<SqlVarchar> IsGrantable = new("IS_GRANTABLE");

        public static readonly Column<SqlVarchar> PrivilegeType = new("PRIVILEGE_TYPE");

        public static readonly Column<SqlNVarchar> TableCatalog = new("TABLE_CATALOG");

        public static readonly Column<SqlSysname> TableName = new("TABLE_NAME");

        public static readonly Column<SqlNVarchar> TableSchema = new("TABLE_SCHEMA");
    }
}
