using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Syspermissions
    {
        public static readonly ViewName ViewName = new ViewName("sys.syspermissions");
        
        public static readonly Column<SqlSmallInt> Actadd = new Column<SqlSmallInt>("actadd");
        
        public static readonly Column<SqlSmallInt> Actmod = new Column<SqlSmallInt>("actmod");
        
        public static readonly Column<SqlSmallInt> Grantee = new Column<SqlSmallInt>("grantee");
        
        public static readonly Column<SqlSmallInt> Grantor = new Column<SqlSmallInt>("grantor");
        
        public static readonly Column<SqlInt> Id = new Column<SqlInt>("id");
        
        public static readonly Column<SqlVarbinary> Refadd = new Column<SqlVarbinary>("refadd");
        
        public static readonly Column<SqlVarbinary> Refmod = new Column<SqlVarbinary>("refmod");
        
        public static readonly Column<SqlVarbinary> Seladd = new Column<SqlVarbinary>("seladd");
        
        public static readonly Column<SqlVarbinary> Selmod = new Column<SqlVarbinary>("selmod");
        
        public static readonly Column<SqlVarbinary> Updadd = new Column<SqlVarbinary>("updadd");
        
        public static readonly Column<SqlVarbinary> Updmod = new Column<SqlVarbinary>("updmod");
    }
}
