using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Sysconstraints
    {
        public static readonly ViewName ViewName = new ViewName("sys.sysconstraints");
        
        public static readonly Column<SqlInt> Actions = new Column<SqlInt>("actions");
        
        public static readonly Column<SqlSmallInt> Colid = new Column<SqlSmallInt>("colid");
        
        public static readonly Column<SqlInt> Constid = new Column<SqlInt>("constid");
        
        public static readonly Column<SqlInt> Error = new Column<SqlInt>("error");
        
        public static readonly Column<SqlInt> Id = new Column<SqlInt>("id");
        
        public static readonly Column<SqlTinyInt> Spare1 = new Column<SqlTinyInt>("spare1");
        
        public static readonly Column<SqlInt> Status = new Column<SqlInt>("status");
    }
}
