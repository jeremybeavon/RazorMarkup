using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public abstract class AvailabilityReadOnlyRoutingLists
    {
        public static readonly ViewName ViewName = new ViewName("sys.availablity_read_only_routing_lists");

        public static readonly Column<SqlUniqueIdentifier> ReplicaId = new Column<SqlUniqueIdentifier>("replica_id");

        public static readonly Column<SqlInt> RoutingPriority = new Column<SqlInt>("routing_priority");

        public static readonly Column<SqlUniqueIdentifier> ReadOnlyReplicaId = new Column<SqlUniqueIdentifier>("read_only_replica_id");
    }
}
