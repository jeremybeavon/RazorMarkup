using RazorMarkup.Database.SqlServer.System.Views.Values;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public abstract class AvailabilityReplicas
    {
        public static readonly ViewName ViewName = new ViewName("sys.availablity_replicas");

        public static readonly Column<SqlUniqueIdentifier> ReplicaId = new Column<SqlUniqueIdentifier>("replica_id");

        public static readonly Column<SqlUniqueIdentifier> GroupId = new Column<SqlUniqueIdentifier>("group_id");

        public static readonly Column<SqlInt> ReplicaMetadataId = new Column<SqlInt>("replica_metadata_id");

        public static readonly Column<SqlNVarchar> ReplicaServerName = new Column<SqlNVarchar>("replica_server_name");

        public static readonly Column<SqlVarbinary> OwnerSid = new Column<SqlVarbinary>("owner_sid");

        public static readonly Column<SqlInt> EndpointUrl = new Column<SqlInt>("endpoint_url");

        public static readonly Column<SqlTinyInt, AvailabilityReplicasAvailabilityMode> AvailabilityMode =
            new Column<SqlTinyInt, AvailabilityReplicasAvailabilityMode>("availability_mode");

        public static readonly Column<SqlNVarchar, AvailabilityReplicasAvailabilityModeDescriptions> AvailabilityModeDescription =
             new Column<SqlNVarchar, AvailabilityReplicasAvailabilityModeDescriptions>("availability_mode_desc");

        public static readonly Column<SqlTinyInt, AvailabilityReplicasFailoverMode> FailureMode =
            new Column<SqlTinyInt, AvailabilityReplicasFailoverMode>("failure_mode");

        public static readonly Column<SqlNVarchar, AvailabilityReplicasFailoverModeDescriptions> FailureModeDescription =
             new Column<SqlNVarchar, AvailabilityReplicasFailoverModeDescriptions>("failure_mode_desc");

        public static readonly Column<SqlInt> SessionTimeout = new Column<SqlInt>("session_timeout");

        public static readonly Column<SqlTinyInt, AvailabilityReplicasPrimaryRoleAllowConnections> PrimaryRoleAllowConnections =
            new Column<SqlTinyInt, AvailabilityReplicasPrimaryRoleAllowConnections>("primary_role_allow_connections");

        public static readonly Column<SqlNVarchar, AvailabilityReplicasPrimaryRoleAllowConnectionsDescriptions> PrimaryRoleAllowConnectionsDescription =
             new Column<SqlNVarchar, AvailabilityReplicasPrimaryRoleAllowConnectionsDescriptions>("primary_role_allow_connections_desc");

        public static readonly Column<SqlTinyInt, AvailabilityReplicasSecondaryRoleAllowConnections> SecondaryRoleAllowConnections =
            new Column<SqlTinyInt, AvailabilityReplicasSecondaryRoleAllowConnections>("secondary_role_allow_connections");

        public static readonly Column<SqlNVarchar, AvailabilityReplicasSecondaryRoleAllowConnectionsDescriptions> SecondaryRoleAllowConnectionsDescription =
             new Column<SqlNVarchar, AvailabilityReplicasSecondaryRoleAllowConnectionsDescriptions>("secondary_role_allow_connections_desc");

        public static readonly Column<SqlDateTime> CreateDate = new Column<SqlDateTime>("create_date");

        public static readonly Column<SqlDateTime> ModifyDate = new Column<SqlDateTime>("modify_date");

        public static readonly Column<SqlInt> BackupPriority = new Column<SqlInt>("backup_priority");

        public static readonly Column<SqlNVarchar> ReadOnlyRoutingUrl = new Column<SqlNVarchar>("read_only_routing_url");
    }
}
