using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Services
    {
        public static readonly ViewName ViewName = new("sys.services");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlInt> PrincipalId = new("principal_id");

        public static readonly Column<SqlInt> ServiceId = new("service_id");

        public static readonly Column<SqlInt> ServiceQueueId = new("service_queue_id");
    }
}
