using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Routines
    {
        public static readonly ViewName ViewName = new("INFORMATION_SCHEMA.ROUTINES");

        public static readonly Column<SqlInt> CharacterMaximumLength = new("CHARACTER_MAXIMUM_LENGTH");

        public static readonly Column<SqlInt> CharacterOctetLength = new("CHARACTER_OCTET_LENGTH");

        public static readonly Column<SqlSysname> CharacterSetCatalog = new("CHARACTER_SET_CATALOG");

        public static readonly Column<SqlSysname> CharacterSetName = new("CHARACTER_SET_NAME");

        public static readonly Column<SqlSysname> CharacterSetSchema = new("CHARACTER_SET_SCHEMA");

        public static readonly Column<SqlSysname> CollationCatalog = new("COLLATION_CATALOG");

        public static readonly Column<SqlSysname> CollationName = new("COLLATION_NAME");

        public static readonly Column<SqlSysname> CollationSchema = new("COLLATION_SCHEMA");

        public static readonly Column<SqlDateTime> Created = new("CREATED");

        public static readonly Column<SqlSysname> DataType = new("DATA_TYPE");

        public static readonly Column<SqlSmallInt> DatetimePrecision = new("DATETIME_PRECISION");

        public static readonly Column<SqlSysname> DtdIdentifier = new("DTD_IDENTIFIER");

        public static readonly Column<SqlNVarchar> ExternalLanguage = new("EXTERNAL_LANGUAGE");

        public static readonly Column<SqlSysname> ExternalName = new("EXTERNAL_NAME");

        public static readonly Column<SqlSmallInt> IntervalPrecision = new("INTERVAL_PRECISION");

        public static readonly Column<SqlNVarchar> IntervalType = new("INTERVAL_TYPE");

        public static readonly Column<SqlNVarchar> IsDeterministic = new("IS_DETERMINISTIC");

        public static readonly Column<SqlNVarchar> IsImplicitlyInvocable = new("IS_IMPLICITLY_INVOCABLE");

        public static readonly Column<SqlNVarchar> IsNullCall = new("IS_NULL_CALL");

        public static readonly Column<SqlNVarchar> IsUserDefinedCast = new("IS_USER_DEFINED_CAST");

        public static readonly Column<SqlDateTime> LastAltered = new("LAST_ALTERED");

        public static readonly Column<SqlSmallInt> MaxDynamicResultSets = new("MAX_DYNAMIC_RESULT_SETS");

        public static readonly Column<SqlBigInt> MaximumCardinality = new("MAXIMUM_CARDINALITY");

        public static readonly Column<SqlSysname> ModuleCatalog = new("MODULE_CATALOG");

        public static readonly Column<SqlSysname> ModuleName = new("MODULE_NAME");

        public static readonly Column<SqlSysname> ModuleSchema = new("MODULE_SCHEMA");

        public static readonly Column<SqlTinyInt> NumericPrecision = new("NUMERIC_PRECISION");

        public static readonly Column<SqlSmallInt> NumericPrecisionRadix = new("NUMERIC_PRECISION_RADIX");

        public static readonly Column<SqlInt> NumericScale = new("NUMERIC_SCALE");

        public static readonly Column<SqlNVarchar> ParameterStyle = new("PARAMETER_STYLE");

        public static readonly Column<SqlNVarchar> RoutineBody = new("ROUTINE_BODY");

        public static readonly Column<SqlNVarchar> RoutineCatalog = new("ROUTINE_CATALOG");

        public static readonly Column<SqlNVarchar> RoutineDefinition = new("ROUTINE_DEFINITION");

        public static readonly Column<SqlSysname> RoutineName = new("ROUTINE_NAME");

        public static readonly Column<SqlNVarchar> RoutineSchema = new("ROUTINE_SCHEMA");

        public static readonly Column<SqlNVarchar> RoutineType = new("ROUTINE_TYPE");

        public static readonly Column<SqlNVarchar> SchemaLevelRoutine = new("SCHEMA_LEVEL_ROUTINE");

        public static readonly Column<SqlSysname> ScopeCatalog = new("SCOPE_CATALOG");

        public static readonly Column<SqlSysname> ScopeName = new("SCOPE_NAME");

        public static readonly Column<SqlSysname> ScopeSchema = new("SCOPE_SCHEMA");

        public static readonly Column<SqlNVarchar> SpecificCatalog = new("SPECIFIC_CATALOG");

        public static readonly Column<SqlSysname> SpecificName = new("SPECIFIC_NAME");

        public static readonly Column<SqlNVarchar> SpecificSchema = new("SPECIFIC_SCHEMA");

        public static readonly Column<SqlNVarchar> SqlDataAccess = new("SQL_DATA_ACCESS");

        public static readonly Column<SqlSysname> SqlPath = new("SQL_PATH");

        public static readonly Column<SqlSysname> TypeUdtCatalog = new("TYPE_UDT_CATALOG");

        public static readonly Column<SqlSysname> TypeUdtName = new("TYPE_UDT_NAME");

        public static readonly Column<SqlSysname> TypeUdtSchema = new("TYPE_UDT_SCHEMA");

        public static readonly Column<SqlSysname> UdtCatalog = new("UDT_CATALOG");

        public static readonly Column<SqlSysname> UdtName = new("UDT_NAME");

        public static readonly Column<SqlSysname> UdtSchema = new("UDT_SCHEMA");
    }
}
