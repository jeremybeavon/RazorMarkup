using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Procedures
{
    public abstract class PrimaryKeysOutput
    {
        public static readonly Column<SqlSysname> TableQualifier = new Column<SqlSysname>("TABLE_QUALIFIER");

        public static readonly Column<SqlSysname> TableOwner = new Column<SqlSysname>("TABLE_OWNER");

        public static readonly Column<SqlSysname> TableName = new Column<SqlSysname>("TABLE_NAME");

        public static readonly Column<SqlSysname> ColumnName = new Column<SqlSysname>("COLUMN_NAME");

        public static readonly Column<SqlSmallInt> KeySequenceNumber = new Column<SqlSmallInt>("KEY_SEQ");

        public static readonly Column<SqlSysname> PrimaryKeyConstraintName = new Column<SqlSysname>("PK_NAME");
    }
}
