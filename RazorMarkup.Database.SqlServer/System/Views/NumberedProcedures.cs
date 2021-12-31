using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class NumberedProcedures
    {
        public static readonly ViewName ViewName = new("sys.numbered_procedures");

        public static readonly Column<SqlNVarchar> Definition = new("definition");

        public static readonly Column<SqlInt> ObjectId = new("object_id");

        public static readonly Column<SqlSmallInt> ProcedureNumber = new("procedure_number");
    }
}
