using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class NumberedProcedureParameters
    {
        public static readonly ViewName ViewName = new("sys.numbered_procedure_parameters");

        public static readonly Column<SqlBit> IsCursorRef = new("is_cursor_ref");

        public static readonly Column<SqlBit> IsOutput = new("is_output");

        public static readonly Column<SqlSmallInt> MaxLength = new("max_length");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlInt> ObjectId = new("object_id");

        public static readonly Column<SqlInt> ParameterId = new("parameter_id");

        public static readonly Column<SqlTinyInt> Precision = new("precision");

        public static readonly Column<SqlSmallInt> ProcedureNumber = new("procedure_number");

        public static readonly Column<SqlTinyInt> Scale = new("scale");

        public static readonly Column<SqlTinyInt> SystemTypeId = new("system_type_id");

        public static readonly Column<SqlInt> UserTypeId = new("user_type_id");
    }
}
