using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public abstract class AvailabilityReadOnlyRoutingLists
    {
        public static readonly ViewName ViewName = new("sys.availablity_read_only_routing_lists");

        public static readonly Column<SqlUniqueIdentifier> ReplicaId = new("replica_id");

        public static readonly Column<SqlInt> RoutingPriority = new("routing_priority");

        public static readonly Column<SqlUniqueIdentifier> ReadOnlyReplicaId = new("read_only_replica_id");
    }
}
