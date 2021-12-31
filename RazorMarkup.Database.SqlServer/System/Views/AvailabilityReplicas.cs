using RazorMarkup.Database.SqlServer.System.Views.Values;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public abstract class AvailabilityReplicas
    {
        public static readonly ViewName ViewName = new("sys.availablity_replicas");

        public static readonly Column<SqlUniqueIdentifier> ReplicaId = new("replica_id");

        public static readonly Column<SqlUniqueIdentifier> GroupId = new("group_id");

        public static readonly Column<SqlInt> ReplicaMetadataId = new("replica_metadata_id");

        public static readonly Column<SqlNVarchar> ReplicaServerName = new("replica_server_name");

        public static readonly Column<SqlVarbinary> OwnerSid = new("owner_sid");

        public static readonly Column<SqlInt> EndpointUrl = new("endpoint_url");

        public static readonly Column<SqlTinyInt, AvailabilityReplicasAvailabilityMode> AvailabilityMode =
            new("availability_mode");

        public static readonly Column<SqlNVarchar, AvailabilityReplicasAvailabilityModeDescriptions> AvailabilityModeDescription =
             new("availability_mode_desc");

        public static readonly Column<SqlTinyInt, AvailabilityReplicasFailoverMode> FailureMode =
            new("failure_mode");

        public static readonly Column<SqlNVarchar, AvailabilityReplicasFailoverModeDescriptions> FailureModeDescription =
             new("failure_mode_desc");

        public static readonly Column<SqlInt> SessionTimeout = new("session_timeout");

        public static readonly Column<SqlTinyInt, AvailabilityReplicasPrimaryRoleAllowConnections> PrimaryRoleAllowConnections =
            new("primary_role_allow_connections");

        public static readonly Column<SqlNVarchar, AvailabilityReplicasPrimaryRoleAllowConnectionsDescriptions> PrimaryRoleAllowConnectionsDescription =
             new("primary_role_allow_connections_desc");

        public static readonly Column<SqlTinyInt, AvailabilityReplicasSecondaryRoleAllowConnections> SecondaryRoleAllowConnections =
            new("secondary_role_allow_connections");

        public static readonly Column<SqlNVarchar, AvailabilityReplicasSecondaryRoleAllowConnectionsDescriptions> SecondaryRoleAllowConnectionsDescription =
             new("secondary_role_allow_connections_desc");

        public static readonly Column<SqlDateTime> CreateDate = new("create_date");

        public static readonly Column<SqlDateTime> ModifyDate = new("modify_date");

        public static readonly Column<SqlInt> BackupPriority = new("backup_priority");

        public static readonly Column<SqlNVarchar> ReadOnlyRoutingUrl = new("read_only_routing_url");
    }
}
