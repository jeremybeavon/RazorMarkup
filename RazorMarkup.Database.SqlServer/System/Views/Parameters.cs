using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Parameters
    {
        public static readonly ViewName ViewName = new("INFORMATION_SCHEMA.PARAMETERS");

        public static readonly Column<SqlNVarchar> AsLocator = new("AS_LOCATOR");

        public static readonly Column<SqlInt> CharacterMaximumLength = new("CHARACTER_MAXIMUM_LENGTH");

        public static readonly Column<SqlInt> CharacterOctetLength = new("CHARACTER_OCTET_LENGTH");

        public static readonly Column<SqlSysname> CharacterSetCatalog = new("CHARACTER_SET_CATALOG");

        public static readonly Column<SqlSysname> CharacterSetName = new("CHARACTER_SET_NAME");

        public static readonly Column<SqlSysname> CharacterSetSchema = new("CHARACTER_SET_SCHEMA");

        public static readonly Column<SqlSysname> CollationCatalog = new("COLLATION_CATALOG");

        public static readonly Column<SqlSysname> CollationName = new("COLLATION_NAME");

        public static readonly Column<SqlSysname> CollationSchema = new("COLLATION_SCHEMA");

        public static readonly Column<SqlNVarchar> DataType = new("DATA_TYPE");

        public static readonly Column<SqlSmallInt> DatetimePrecision = new("DATETIME_PRECISION");

        public static readonly Column<SqlSmallInt> IntervalPrecision = new("INTERVAL_PRECISION");

        public static readonly Column<SqlNVarchar> IntervalType = new("INTERVAL_TYPE");

        public static readonly Column<SqlNVarchar> IsResult = new("IS_RESULT");

        public static readonly Column<SqlTinyInt> NumericPrecision = new("NUMERIC_PRECISION");

        public static readonly Column<SqlSmallInt> NumericPrecisionRadix = new("NUMERIC_PRECISION_RADIX");

        public static readonly Column<SqlInt> NumericScale = new("NUMERIC_SCALE");

        public static readonly Column<SqlInt> OrdinalPosition = new("ORDINAL_POSITION");

        public static readonly Column<SqlNVarchar> ParameterMode = new("PARAMETER_MODE");

        public static readonly Column<SqlSysname> ParameterName = new("PARAMETER_NAME");

        public static readonly Column<SqlSysname> ScopeCatalog = new("SCOPE_CATALOG");

        public static readonly Column<SqlSysname> ScopeName = new("SCOPE_NAME");

        public static readonly Column<SqlSysname> ScopeSchema = new("SCOPE_SCHEMA");

        public static readonly Column<SqlNVarchar> SpecificCatalog = new("SPECIFIC_CATALOG");

        public static readonly Column<SqlSysname> SpecificName = new("SPECIFIC_NAME");

        public static readonly Column<SqlNVarchar> SpecificSchema = new("SPECIFIC_SCHEMA");

        public static readonly Column<SqlSysname> UserDefinedTypeCatalog = new("USER_DEFINED_TYPE_CATALOG");

        public static readonly Column<SqlSysname> UserDefinedTypeName = new("USER_DEFINED_TYPE_NAME");

        public static readonly Column<SqlSysname> UserDefinedTypeSchema = new("USER_DEFINED_TYPE_SCHEMA");
    }
}
