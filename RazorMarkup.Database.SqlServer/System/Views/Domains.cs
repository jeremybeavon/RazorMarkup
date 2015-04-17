using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Domains
    {
        public static readonly ViewName ViewName = new ViewName("INFORMATION_SCHEMA.DOMAINS");
        
        public static readonly Column<SqlInt> CharacterMaximumLength = new Column<SqlInt>("CHARACTER_MAXIMUM_LENGTH");
        
        public static readonly Column<SqlInt> CharacterOctetLength = new Column<SqlInt>("CHARACTER_OCTET_LENGTH");
        
        public static readonly Column<SqlSysname> CharacterSetCatalog = new Column<SqlSysname>("CHARACTER_SET_CATALOG");
        
        public static readonly Column<SqlSysname> CharacterSetName = new Column<SqlSysname>("CHARACTER_SET_NAME");
        
        public static readonly Column<SqlSysname> CharacterSetSchema = new Column<SqlSysname>("CHARACTER_SET_SCHEMA");
        
        public static readonly Column<SqlSysname> CollationCatalog = new Column<SqlSysname>("COLLATION_CATALOG");
        
        public static readonly Column<SqlSysname> CollationName = new Column<SqlSysname>("COLLATION_NAME");
        
        public static readonly Column<SqlSysname> CollationSchema = new Column<SqlSysname>("COLLATION_SCHEMA");
        
        public static readonly Column<SqlNVarchar> DataType = new Column<SqlNVarchar>("DATA_TYPE");
        
        public static readonly Column<SqlSmallInt> DatetimePrecision = new Column<SqlSmallInt>("DATETIME_PRECISION");
        
        public static readonly Column<SqlNVarchar> DomainCatalog = new Column<SqlNVarchar>("DOMAIN_CATALOG");
        
        public static readonly Column<SqlNVarchar> DomainDefault = new Column<SqlNVarchar>("DOMAIN_DEFAULT");
        
        public static readonly Column<SqlSysname> DomainName = new Column<SqlSysname>("DOMAIN_NAME");
        
        public static readonly Column<SqlNVarchar> DomainSchema = new Column<SqlNVarchar>("DOMAIN_SCHEMA");
        
        public static readonly Column<SqlTinyInt> NumericPrecision = new Column<SqlTinyInt>("NUMERIC_PRECISION");
        
        public static readonly Column<SqlSmallInt> NumericPrecisionRadix = new Column<SqlSmallInt>("NUMERIC_PRECISION_RADIX");
        
        public static readonly Column<SqlInt> NumericScale = new Column<SqlInt>("NUMERIC_SCALE");
    }
}
