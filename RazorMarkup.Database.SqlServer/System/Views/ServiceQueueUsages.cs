using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ServiceQueueUsages
    {
        public static readonly ViewName ViewName = new("sys.service_queue_usages");

        public static readonly Column<SqlInt> ServiceId = new("service_id");

        public static readonly Column<SqlInt> ServiceQueueId = new("service_queue_id");
    }
}
