using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Services
    {
        public static readonly ViewName ViewName = new ViewName("sys.services");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlInt> PrincipalId = new Column<SqlInt>("principal_id");
        
        public static readonly Column<SqlInt> ServiceId = new Column<SqlInt>("service_id");
        
        public static readonly Column<SqlInt> ServiceQueueId = new Column<SqlInt>("service_queue_id");
    }
}
