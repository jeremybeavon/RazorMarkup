using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Procedures
{
    public abstract class ForeignKeysOutput
    {
        public static readonly Column<SqlSysname> PrimaryKeyTableQualifier = new Column<SqlSysname>("PKTABLE_QUALIFIER");

        public static readonly Column<SqlSysname> PrimaryKeyTableOwner = new Column<SqlSysname>("PKTABLE_OWNER");

        public static readonly Column<SqlSysname> PrimaryKeyTableName = new Column<SqlSysname>("PKTABLE_NAME");

        public static readonly Column<SqlSysname> PrimaryKeyColumnName = new Column<SqlSysname>("PKCOLUMN_NAME");

        public static readonly Column<SqlSysname> ForeignKeyTableQualifier = new Column<SqlSysname>("FKTABLE_QUALIFIER");

        public static readonly Column<SqlSysname> ForeignKeyTableOwner = new Column<SqlSysname>("FKTABLE_OWNER");

        public static readonly Column<SqlSysname> ForeignKeyTableName = new Column<SqlSysname>("FKTABLE_NAME");

        public static readonly Column<SqlSysname> ForeignKeyColumnName = new Column<SqlSysname>("FKCOLUMN_NAME");

        public static readonly Column<SqlSmallInt> KeySequenceNumber = new Column<SqlSmallInt>("KEY_SEQ");

        public static readonly Column<SqlSmallInt, CascadeNoAction> UpdateRule =
            new Column<SqlSmallInt, CascadeNoAction>("UPDATE_RULE");

        public static readonly Column<SqlSmallInt, CascadeNoAction> DeleteRule =
            new Column<SqlSmallInt, CascadeNoAction>("DELETE_RULE");

        public static readonly Column<SqlSysname> ForeignKeyConstraintName = new Column<SqlSysname>("FK_NAME");

        public static readonly Column<SqlSysname> PrimaryKeyConstraintName = new Column<SqlSysname>("PK_NAME");
    }
}
