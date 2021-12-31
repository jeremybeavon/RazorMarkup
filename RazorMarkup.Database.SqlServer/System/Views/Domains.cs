using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Domains
    {
        public static readonly ViewName ViewName = new("INFORMATION_SCHEMA.DOMAINS");

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

        public static readonly Column<SqlNVarchar> DomainCatalog = new("DOMAIN_CATALOG");

        public static readonly Column<SqlNVarchar> DomainDefault = new("DOMAIN_DEFAULT");

        public static readonly Column<SqlSysname> DomainName = new("DOMAIN_NAME");

        public static readonly Column<SqlNVarchar> DomainSchema = new("DOMAIN_SCHEMA");

        public static readonly Column<SqlTinyInt> NumericPrecision = new("NUMERIC_PRECISION");

        public static readonly Column<SqlSmallInt> NumericPrecisionRadix = new("NUMERIC_PRECISION_RADIX");

        public static readonly Column<SqlInt> NumericScale = new("NUMERIC_SCALE");
    }
}
