using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Procedures
{
    public abstract class ColumnPrivilegesOutput
    {
        public static readonly Column<SqlSysname> TableQualifier = new("TABLE_QUALIFIER");

        public static readonly Column<SqlSysname> TableOwner = new("TABLE_OWNER");

        public static readonly Column<SqlSysname> TableName = new("TABLE_NAME");

        public static readonly Column<SqlSysname> ColumnName = new("COLUMN_NAME");

        public static readonly Column<SqlSysname> Grantor = new("GRANTOR");

        public static readonly Column<SqlSysname> Grantee = new("GRANTEE");

        public static readonly Column<SqlVarchar, ColumnPrivilegesOutputPrivileges> Privilege =
            new("PRIVILEGE");

        public static readonly Column<SqlVarchar, YesNoNull> IsGrantable =
            new("IS_GRANTABLE");
    }
}
