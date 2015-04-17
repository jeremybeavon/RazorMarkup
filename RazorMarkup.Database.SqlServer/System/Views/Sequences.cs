using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Sequences
    {
        public static readonly ViewName ViewName = new ViewName("INFORMATION_SCHEMA.SEQUENCES");
        
        public static readonly Column<SqlBit> CycleOption = new Column<SqlBit>("CYCLE_OPTION");
        
        public static readonly Column<SqlNVarchar> DataType = new Column<SqlNVarchar>("DATA_TYPE");
        
        public static readonly Column<SqlSysname> DeclaredDataType = new Column<SqlSysname>("DECLARED_DATA_TYPE");
        
        public static readonly Column<SqlTinyInt> DeclaredNumericPrecision = new Column<SqlTinyInt>("DECLARED_NUMERIC_PRECISION");
        
        public static readonly Column<SqlTinyInt> DeclaredNumericScale = new Column<SqlTinyInt>("DECLARED_NUMERIC_SCALE");
        
        public static readonly Column<SqlVariant> Increment = new Column<SqlVariant>("INCREMENT");
        
        public static readonly Column<SqlVariant> MaximumValue = new Column<SqlVariant>("MAXIMUM_VALUE");
        
        public static readonly Column<SqlVariant> MinimumValue = new Column<SqlVariant>("MINIMUM_VALUE");
        
        public static readonly Column<SqlTinyInt> NumericPrecision = new Column<SqlTinyInt>("NUMERIC_PRECISION");
        
        public static readonly Column<SqlSmallInt> NumericPrecisionRadix = new Column<SqlSmallInt>("NUMERIC_PRECISION_RADIX");
        
        public static readonly Column<SqlInt> NumericScale = new Column<SqlInt>("NUMERIC_SCALE");
        
        public static readonly Column<SqlNVarchar> SequenceCatalog = new Column<SqlNVarchar>("SEQUENCE_CATALOG");
        
        public static readonly Column<SqlSysname> SequenceName = new Column<SqlSysname>("SEQUENCE_NAME");
        
        public static readonly Column<SqlNVarchar> SequenceSchema = new Column<SqlNVarchar>("SEQUENCE_SCHEMA");
        
        public static readonly Column<SqlVariant> StartValue = new Column<SqlVariant>("START_VALUE");
    }
}
