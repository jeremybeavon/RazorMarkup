using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class PartitionParameters
    {
        public static readonly ViewName ViewName = new("sys.partition_parameters");

        public static readonly Column<SqlSysname> CollationName = new("collation_name");

        public static readonly Column<SqlInt> FunctionId = new("function_id");

        public static readonly Column<SqlSmallInt> MaxLength = new("max_length");

        public static readonly Column<SqlInt> ParameterId = new("parameter_id");

        public static readonly Column<SqlTinyInt> Precision = new("precision");

        public static readonly Column<SqlTinyInt> Scale = new("scale");

        public static readonly Column<SqlTinyInt> SystemTypeId = new("system_type_id");

        public static readonly Column<SqlInt> UserTypeId = new("user_type_id");
    }
}
