using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Procedures
{
    public abstract class ColumnPrivilegesOutput
    {
        public static readonly Column<SqlSysname> TableQualifier = new Column<SqlSysname>("TABLE_QUALIFIER");

        public static readonly Column<SqlSysname> TableOwner = new Column<SqlSysname>("TABLE_OWNER");

        public static readonly Column<SqlSysname> TableName = new Column<SqlSysname>("TABLE_NAME");

        public static readonly Column<SqlSysname> ColumnName = new Column<SqlSysname>("COLUMN_NAME");

        public static readonly Column<SqlSysname> Grantor = new Column<SqlSysname>("GRANTOR");

        public static readonly Column<SqlSysname> Grantee = new Column<SqlSysname>("GRANTEE");

        public static readonly Column<SqlVarchar, ColumnPrivilegesOutputPrivileges> Privilege =
            new Column<SqlVarchar, ColumnPrivilegesOutputPrivileges>("PRIVILEGE");

        public static readonly Column<SqlVarchar, YesNoNull> IsGrantable =
            new Column<SqlVarchar, YesNoNull>("IS_GRANTABLE");
    }
}
