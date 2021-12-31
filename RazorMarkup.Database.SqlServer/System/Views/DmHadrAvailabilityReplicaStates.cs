using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmHadrAvailabilityReplicaStates
    {
        public static readonly ViewName ViewName = new("sys.dm_hadr_availability_replica_states");

        public static readonly Column<SqlTinyInt> ConnectedState = new("connected_state");

        public static readonly Column<SqlNVarchar> ConnectedStateDesc = new("connected_state_desc");

        public static readonly Column<SqlUniqueIdentifier> GroupId = new("group_id");

        public static readonly Column<SqlBit> IsLocal = new("is_local");

        public static readonly Column<SqlNVarchar> LastConnectErrorDescription = new("last_connect_error_description");

        public static readonly Column<SqlInt> LastConnectErrorNumber = new("last_connect_error_number");

        public static readonly Column<SqlDateTime> LastConnectErrorTimestamp = new("last_connect_error_timestamp");

        public static readonly Column<SqlTinyInt> OperationalState = new("operational_state");

        public static readonly Column<SqlNVarchar> OperationalStateDesc = new("operational_state_desc");

        public static readonly Column<SqlTinyInt> RecoveryHealth = new("recovery_health");

        public static readonly Column<SqlNVarchar> RecoveryHealthDesc = new("recovery_health_desc");

        public static readonly Column<SqlUniqueIdentifier> ReplicaId = new("replica_id");

        public static readonly Column<SqlTinyInt> Role = new("role");

        public static readonly Column<SqlNVarchar> RoleDesc = new("role_desc");

        public static readonly Column<SqlTinyInt> SynchronizationHealth = new("synchronization_health");

        public static readonly Column<SqlNVarchar> SynchronizationHealthDesc = new("synchronization_health_desc");
    }
}
