using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Procedures
{
    public abstract class ColumnsOutput
    {
        public static readonly Column<SqlSysname> TableQualifier = new("TABLE_QUALIFIER");

        public static readonly Column<SqlSysname> TableOwner = new("TABLE_OWNER");

        public static readonly Column<SqlSysname> TableName = new("TABLE_NAME");

        public static readonly Column<SqlSysname> ColumnName = new("COLUMN_NAME");

        public static readonly Column<SqlSmallInt> DataType = new("DATA_TYPE");

        public static readonly Column<SqlSysname> TypeName = new("TYPE_NAME");

        public static readonly Column<SqlInt> Precision = new("PRECISION");

        public static readonly Column<SqlInt> Length = new("LENGTH");

        public static readonly Column<SqlSmallInt> Scale = new("SCALE");

        public static readonly Column<SqlSmallInt> Radix = new("RADIX");

        public static readonly Column<SqlSmallInt, NullNotNull> Nullable =
            new("NULLABLE");

        public static readonly Column<SqlVarchar> Remarks = new("REMARKS");

        public static readonly Column<SqlNVarchar> ColumnDefault = new("COLUMN_DEF");

        public static readonly Column<SqlSmallInt> SqlDataType = new("SQL_DATA_TYPE");

        public static readonly Column<SqlSmallInt> SqlDateTimeSubType = new("SQL_DATETIME_SUB");

        public static readonly Column<SqlInt> CharOctetLength = new("CHAR_OCTET_LENGTH");

        public static readonly Column<SqlInt> OrdinalPosition = new("ORDINAL_POSITION");

        public static readonly Column<SqlVarchar, YesNo> IsNullable = new("IS_NULLABLE");

        public static readonly Column<SqlTinyInt> SqlServerDataType = new("SS_DATA_TYPE");
    }
}
