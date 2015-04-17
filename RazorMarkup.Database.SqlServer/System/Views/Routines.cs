using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Routines
    {
        public static readonly ViewName ViewName = new ViewName("INFORMATION_SCHEMA.ROUTINES");
        
        public static readonly Column<SqlInt> CharacterMaximumLength = new Column<SqlInt>("CHARACTER_MAXIMUM_LENGTH");
        
        public static readonly Column<SqlInt> CharacterOctetLength = new Column<SqlInt>("CHARACTER_OCTET_LENGTH");
        
        public static readonly Column<SqlSysname> CharacterSetCatalog = new Column<SqlSysname>("CHARACTER_SET_CATALOG");
        
        public static readonly Column<SqlSysname> CharacterSetName = new Column<SqlSysname>("CHARACTER_SET_NAME");
        
        public static readonly Column<SqlSysname> CharacterSetSchema = new Column<SqlSysname>("CHARACTER_SET_SCHEMA");
        
        public static readonly Column<SqlSysname> CollationCatalog = new Column<SqlSysname>("COLLATION_CATALOG");
        
        public static readonly Column<SqlSysname> CollationName = new Column<SqlSysname>("COLLATION_NAME");
        
        public static readonly Column<SqlSysname> CollationSchema = new Column<SqlSysname>("COLLATION_SCHEMA");
        
        public static readonly Column<SqlDateTime> Created = new Column<SqlDateTime>("CREATED");
        
        public static readonly Column<SqlSysname> DataType = new Column<SqlSysname>("DATA_TYPE");
        
        public static readonly Column<SqlSmallInt> DatetimePrecision = new Column<SqlSmallInt>("DATETIME_PRECISION");
        
        public static readonly Column<SqlSysname> DtdIdentifier = new Column<SqlSysname>("DTD_IDENTIFIER");
        
        public static readonly Column<SqlNVarchar> ExternalLanguage = new Column<SqlNVarchar>("EXTERNAL_LANGUAGE");
        
        public static readonly Column<SqlSysname> ExternalName = new Column<SqlSysname>("EXTERNAL_NAME");
        
        public static readonly Column<SqlSmallInt> IntervalPrecision = new Column<SqlSmallInt>("INTERVAL_PRECISION");
        
        public static readonly Column<SqlNVarchar> IntervalType = new Column<SqlNVarchar>("INTERVAL_TYPE");
        
        public static readonly Column<SqlNVarchar> IsDeterministic = new Column<SqlNVarchar>("IS_DETERMINISTIC");
        
        public static readonly Column<SqlNVarchar> IsImplicitlyInvocable = new Column<SqlNVarchar>("IS_IMPLICITLY_INVOCABLE");
        
        public static readonly Column<SqlNVarchar> IsNullCall = new Column<SqlNVarchar>("IS_NULL_CALL");
        
        public static readonly Column<SqlNVarchar> IsUserDefinedCast = new Column<SqlNVarchar>("IS_USER_DEFINED_CAST");
        
        public static readonly Column<SqlDateTime> LastAltered = new Column<SqlDateTime>("LAST_ALTERED");
        
        public static readonly Column<SqlSmallInt> MaxDynamicResultSets = new Column<SqlSmallInt>("MAX_DYNAMIC_RESULT_SETS");
        
        public static readonly Column<SqlBigInt> MaximumCardinality = new Column<SqlBigInt>("MAXIMUM_CARDINALITY");
        
        public static readonly Column<SqlSysname> ModuleCatalog = new Column<SqlSysname>("MODULE_CATALOG");
        
        public static readonly Column<SqlSysname> ModuleName = new Column<SqlSysname>("MODULE_NAME");
        
        public static readonly Column<SqlSysname> ModuleSchema = new Column<SqlSysname>("MODULE_SCHEMA");
        
        public static readonly Column<SqlTinyInt> NumericPrecision = new Column<SqlTinyInt>("NUMERIC_PRECISION");
        
        public static readonly Column<SqlSmallInt> NumericPrecisionRadix = new Column<SqlSmallInt>("NUMERIC_PRECISION_RADIX");
        
        public static readonly Column<SqlInt> NumericScale = new Column<SqlInt>("NUMERIC_SCALE");
        
        public static readonly Column<SqlNVarchar> ParameterStyle = new Column<SqlNVarchar>("PARAMETER_STYLE");
        
        public static readonly Column<SqlNVarchar> RoutineBody = new Column<SqlNVarchar>("ROUTINE_BODY");
        
        public static readonly Column<SqlNVarchar> RoutineCatalog = new Column<SqlNVarchar>("ROUTINE_CATALOG");
        
        public static readonly Column<SqlNVarchar> RoutineDefinition = new Column<SqlNVarchar>("ROUTINE_DEFINITION");
        
        public static readonly Column<SqlSysname> RoutineName = new Column<SqlSysname>("ROUTINE_NAME");
        
        public static readonly Column<SqlNVarchar> RoutineSchema = new Column<SqlNVarchar>("ROUTINE_SCHEMA");
        
        public static readonly Column<SqlNVarchar> RoutineType = new Column<SqlNVarchar>("ROUTINE_TYPE");
        
        public static readonly Column<SqlNVarchar> SchemaLevelRoutine = new Column<SqlNVarchar>("SCHEMA_LEVEL_ROUTINE");
        
        public static readonly Column<SqlSysname> ScopeCatalog = new Column<SqlSysname>("SCOPE_CATALOG");
        
        public static readonly Column<SqlSysname> ScopeName = new Column<SqlSysname>("SCOPE_NAME");
        
        public static readonly Column<SqlSysname> ScopeSchema = new Column<SqlSysname>("SCOPE_SCHEMA");
        
        public static readonly Column<SqlNVarchar> SpecificCatalog = new Column<SqlNVarchar>("SPECIFIC_CATALOG");
        
        public static readonly Column<SqlSysname> SpecificName = new Column<SqlSysname>("SPECIFIC_NAME");
        
        public static readonly Column<SqlNVarchar> SpecificSchema = new Column<SqlNVarchar>("SPECIFIC_SCHEMA");
        
        public static readonly Column<SqlNVarchar> SqlDataAccess = new Column<SqlNVarchar>("SQL_DATA_ACCESS");
        
        public static readonly Column<SqlSysname> SqlPath = new Column<SqlSysname>("SQL_PATH");
        
        public static readonly Column<SqlSysname> TypeUdtCatalog = new Column<SqlSysname>("TYPE_UDT_CATALOG");
        
        public static readonly Column<SqlSysname> TypeUdtName = new Column<SqlSysname>("TYPE_UDT_NAME");
        
        public static readonly Column<SqlSysname> TypeUdtSchema = new Column<SqlSysname>("TYPE_UDT_SCHEMA");
        
        public static readonly Column<SqlSysname> UdtCatalog = new Column<SqlSysname>("UDT_CATALOG");
        
        public static readonly Column<SqlSysname> UdtName = new Column<SqlSysname>("UDT_NAME");
        
        public static readonly Column<SqlSysname> UdtSchema = new Column<SqlSysname>("UDT_SCHEMA");
    }
}
