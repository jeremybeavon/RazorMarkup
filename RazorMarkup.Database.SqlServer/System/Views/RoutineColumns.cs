using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class RoutineColumns
    {
        public static readonly ViewName ViewName = new("INFORMATION_SCHEMA.ROUTINE_COLUMNS");

        public static readonly Column<SqlInt> CharacterMaximumLength = new("CHARACTER_MAXIMUM_LENGTH");

        public static readonly Column<SqlInt> CharacterOctetLength = new("CHARACTER_OCTET_LENGTH");

        public static readonly Column<SqlSysname> CharacterSetCatalog = new("CHARACTER_SET_CATALOG");

        public static readonly Column<SqlSysname> CharacterSetName = new("CHARACTER_SET_NAME");

        public static readonly Column<SqlSysname> CharacterSetSchema = new("CHARACTER_SET_SCHEMA");

        public static readonly Column<SqlSysname> CollationCatalog = new("COLLATION_CATALOG");

        public static readonly Column<SqlSysname> CollationName = new("COLLATION_NAME");

        public static readonly Column<SqlSysname> CollationSchema = new("COLLATION_SCHEMA");

        public static readonly Column<SqlNVarchar> ColumnDefault = new("COLUMN_DEFAULT");

        public static readonly Column<SqlSysname> ColumnName = new("COLUMN_NAME");

        public static readonly Column<SqlNVarchar> DataType = new("DATA_TYPE");

        public static readonly Column<SqlSmallInt> DatetimePrecision = new("DATETIME_PRECISION");

        public static readonly Column<SqlSysname> DomainCatalog = new("DOMAIN_CATALOG");

        public static readonly Column<SqlSysname> DomainName = new("DOMAIN_NAME");

        public static readonly Column<SqlSysname> DomainSchema = new("DOMAIN_SCHEMA");

        public static readonly Column<SqlVarchar> IsNullable = new("IS_NULLABLE");

        public static readonly Column<SqlTinyInt> NumericPrecision = new("NUMERIC_PRECISION");

        public static readonly Column<SqlSmallInt> NumericPrecisionRadix = new("NUMERIC_PRECISION_RADIX");

        public static readonly Column<SqlInt> NumericScale = new("NUMERIC_SCALE");

        public static readonly Column<SqlInt> OrdinalPosition = new("ORDINAL_POSITION");

        public static readonly Column<SqlNVarchar> TableCatalog = new("TABLE_CATALOG");

        public static readonly Column<SqlSysname> TableName = new("TABLE_NAME");

        public static readonly Column<SqlNVarchar> TableSchema = new("TABLE_SCHEMA");
    }
}
