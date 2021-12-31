using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Sequences
    {
        public static readonly ViewName ViewName = new("INFORMATION_SCHEMA.SEQUENCES");

        public static readonly Column<SqlBit> CycleOption = new("CYCLE_OPTION");

        public static readonly Column<SqlNVarchar> DataType = new("DATA_TYPE");

        public static readonly Column<SqlSysname> DeclaredDataType = new("DECLARED_DATA_TYPE");

        public static readonly Column<SqlTinyInt> DeclaredNumericPrecision = new("DECLARED_NUMERIC_PRECISION");

        public static readonly Column<SqlTinyInt> DeclaredNumericScale = new("DECLARED_NUMERIC_SCALE");

        public static readonly Column<SqlVariant> Increment = new("INCREMENT");

        public static readonly Column<SqlVariant> MaximumValue = new("MAXIMUM_VALUE");

        public static readonly Column<SqlVariant> MinimumValue = new("MINIMUM_VALUE");

        public static readonly Column<SqlTinyInt> NumericPrecision = new("NUMERIC_PRECISION");

        public static readonly Column<SqlSmallInt> NumericPrecisionRadix = new("NUMERIC_PRECISION_RADIX");

        public static readonly Column<SqlInt> NumericScale = new("NUMERIC_SCALE");

        public static readonly Column<SqlNVarchar> SequenceCatalog = new("SEQUENCE_CATALOG");

        public static readonly Column<SqlSysname> SequenceName = new("SEQUENCE_NAME");

        public static readonly Column<SqlNVarchar> SequenceSchema = new("SEQUENCE_SCHEMA");

        public static readonly Column<SqlVariant> StartValue = new("START_VALUE");
    }
}
