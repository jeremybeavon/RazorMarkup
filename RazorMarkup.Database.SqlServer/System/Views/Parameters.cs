using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Parameters
    {
        public static readonly ViewName ViewName = new ViewName("INFORMATION_SCHEMA.PARAMETERS");
        
        public static readonly Column<SqlNVarchar> AsLocator = new Column<SqlNVarchar>("AS_LOCATOR");
        
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
        
        public static readonly Column<SqlSmallInt> IntervalPrecision = new Column<SqlSmallInt>("INTERVAL_PRECISION");
        
        public static readonly Column<SqlNVarchar> IntervalType = new Column<SqlNVarchar>("INTERVAL_TYPE");
        
        public static readonly Column<SqlNVarchar> IsResult = new Column<SqlNVarchar>("IS_RESULT");
        
        public static readonly Column<SqlTinyInt> NumericPrecision = new Column<SqlTinyInt>("NUMERIC_PRECISION");
        
        public static readonly Column<SqlSmallInt> NumericPrecisionRadix = new Column<SqlSmallInt>("NUMERIC_PRECISION_RADIX");
        
        public static readonly Column<SqlInt> NumericScale = new Column<SqlInt>("NUMERIC_SCALE");
        
        public static readonly Column<SqlInt> OrdinalPosition = new Column<SqlInt>("ORDINAL_POSITION");
        
        public static readonly Column<SqlNVarchar> ParameterMode = new Column<SqlNVarchar>("PARAMETER_MODE");
        
        public static readonly Column<SqlSysname> ParameterName = new Column<SqlSysname>("PARAMETER_NAME");
        
        public static readonly Column<SqlSysname> ScopeCatalog = new Column<SqlSysname>("SCOPE_CATALOG");
        
        public static readonly Column<SqlSysname> ScopeName = new Column<SqlSysname>("SCOPE_NAME");
        
        public static readonly Column<SqlSysname> ScopeSchema = new Column<SqlSysname>("SCOPE_SCHEMA");
        
        public static readonly Column<SqlNVarchar> SpecificCatalog = new Column<SqlNVarchar>("SPECIFIC_CATALOG");
        
        public static readonly Column<SqlSysname> SpecificName = new Column<SqlSysname>("SPECIFIC_NAME");
        
        public static readonly Column<SqlNVarchar> SpecificSchema = new Column<SqlNVarchar>("SPECIFIC_SCHEMA");
        
        public static readonly Column<SqlSysname> UserDefinedTypeCatalog = new Column<SqlSysname>("USER_DEFINED_TYPE_CATALOG");
        
        public static readonly Column<SqlSysname> UserDefinedTypeName = new Column<SqlSysname>("USER_DEFINED_TYPE_NAME");
        
        public static readonly Column<SqlSysname> UserDefinedTypeSchema = new Column<SqlSysname>("USER_DEFINED_TYPE_SCHEMA");
    }
}
