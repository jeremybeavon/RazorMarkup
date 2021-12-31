using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Procedures
{
    public abstract class PrimaryKeysOutput
    {
        public static readonly Column<SqlSysname> TableQualifier = new("TABLE_QUALIFIER");

        public static readonly Column<SqlSysname> TableOwner = new("TABLE_OWNER");

        public static readonly Column<SqlSysname> TableName = new("TABLE_NAME");

        public static readonly Column<SqlSysname> ColumnName = new("COLUMN_NAME");

        public static readonly Column<SqlSmallInt> KeySequenceNumber = new("KEY_SEQ");

        public static readonly Column<SqlSysname> PrimaryKeyConstraintName = new("PK_NAME");
    }
}
