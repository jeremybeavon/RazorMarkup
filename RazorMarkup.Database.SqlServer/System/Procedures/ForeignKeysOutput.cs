using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Procedures
{
    public abstract class ForeignKeysOutput
    {
        public static readonly Column<SqlSysname> PrimaryKeyTableQualifier = new("PKTABLE_QUALIFIER");

        public static readonly Column<SqlSysname> PrimaryKeyTableOwner = new("PKTABLE_OWNER");

        public static readonly Column<SqlSysname> PrimaryKeyTableName = new("PKTABLE_NAME");

        public static readonly Column<SqlSysname> PrimaryKeyColumnName = new("PKCOLUMN_NAME");

        public static readonly Column<SqlSysname> ForeignKeyTableQualifier = new("FKTABLE_QUALIFIER");

        public static readonly Column<SqlSysname> ForeignKeyTableOwner = new("FKTABLE_OWNER");

        public static readonly Column<SqlSysname> ForeignKeyTableName = new("FKTABLE_NAME");

        public static readonly Column<SqlSysname> ForeignKeyColumnName = new("FKCOLUMN_NAME");

        public static readonly Column<SqlSmallInt> KeySequenceNumber = new("KEY_SEQ");

        public static readonly Column<SqlSmallInt, CascadeNoAction> UpdateRule =
            new("UPDATE_RULE");

        public static readonly Column<SqlSmallInt, CascadeNoAction> DeleteRule =
            new("DELETE_RULE");

        public static readonly Column<SqlSysname> ForeignKeyConstraintName = new("FK_NAME");

        public static readonly Column<SqlSysname> PrimaryKeyConstraintName = new("PK_NAME");
    }
}
