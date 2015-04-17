using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ServiceQueueUsages
    {
        public static readonly ViewName ViewName = new ViewName("sys.service_queue_usages");
        
        public static readonly Column<SqlInt> ServiceId = new Column<SqlInt>("service_id");
        
        public static readonly Column<SqlInt> ServiceQueueId = new Column<SqlInt>("service_queue_id");
    }
}
