using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class NumberedProcedures
    {
        public static readonly ViewName ViewName = new ViewName("sys.numbered_procedures");
        
        public static readonly Column<SqlNVarchar> Definition = new Column<SqlNVarchar>("definition");
        
        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");
        
        public static readonly Column<SqlSmallInt> ProcedureNumber = new Column<SqlSmallInt>("procedure_number");
    }
}
