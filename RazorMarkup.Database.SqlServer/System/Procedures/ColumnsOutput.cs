using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Procedures
{
    public abstract class ColumnsOutput
    {
        public static readonly Column<SqlSysname> TableQualifier = new Column<SqlSysname>("TABLE_QUALIFIER");

        public static readonly Column<SqlSysname> TableOwner = new Column<SqlSysname>("TABLE_OWNER");

        public static readonly Column<SqlSysname> TableName = new Column<SqlSysname>("TABLE_NAME");

        public static readonly Column<SqlSysname> ColumnName = new Column<SqlSysname>("COLUMN_NAME");

        public static readonly Column<SqlSmallInt> DataType = new Column<SqlSmallInt>("DATA_TYPE");

        public static readonly Column<SqlSysname> TypeName = new Column<SqlSysname>("TYPE_NAME");

        public static readonly Column<SqlInt> Precision = new Column<SqlInt>("PRECISION");

        public static readonly Column<SqlInt> Length = new Column<SqlInt>("LENGTH");

        public static readonly Column<SqlSmallInt> Scale = new Column<SqlSmallInt>("SCALE");

        public static readonly Column<SqlSmallInt> Radix = new Column<SqlSmallInt>("RADIX");

        public static readonly Column<SqlSmallInt, NullNotNull> Nullable =
            new Column<SqlSmallInt, NullNotNull>("NULLABLE");

        public static readonly Column<SqlVarchar> Remarks = new Column<SqlVarchar>("REMARKS");

        public static readonly Column<SqlNVarchar> ColumnDefault = new Column<SqlNVarchar>("COLUMN_DEF");

        public static readonly Column<SqlSmallInt> SqlDataType = new Column<SqlSmallInt>("SQL_DATA_TYPE");

        public static readonly Column<SqlSmallInt> SqlDateTimeSubType = new Column<SqlSmallInt>("SQL_DATETIME_SUB");

        public static readonly Column<SqlInt> CharOctetLength = new Column<SqlInt>("CHAR_OCTET_LENGTH");

        public static readonly Column<SqlInt> OrdinalPosition = new Column<SqlInt>("ORDINAL_POSITION");

        public static readonly Column<SqlVarchar, YesNo> IsNullable = new Column<SqlVarchar, YesNo>("IS_NULLABLE");

        public static readonly Column<SqlTinyInt> SqlServerDataType = new Column<SqlTinyInt>("SS_DATA_TYPE");
    }
}
