using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmHadrAvailabilityReplicaStates
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_hadr_availability_replica_states");
        
        public static readonly Column<SqlTinyInt> ConnectedState = new Column<SqlTinyInt>("connected_state");
        
        public static readonly Column<SqlNVarchar> ConnectedStateDesc = new Column<SqlNVarchar>("connected_state_desc");
        
        public static readonly Column<SqlUniqueIdentifier> GroupId = new Column<SqlUniqueIdentifier>("group_id");
        
        public static readonly Column<SqlBit> IsLocal = new Column<SqlBit>("is_local");
        
        public static readonly Column<SqlNVarchar> LastConnectErrorDescription = new Column<SqlNVarchar>("last_connect_error_description");
        
        public static readonly Column<SqlInt> LastConnectErrorNumber = new Column<SqlInt>("last_connect_error_number");
        
        public static readonly Column<SqlDateTime> LastConnectErrorTimestamp = new Column<SqlDateTime>("last_connect_error_timestamp");
        
        public static readonly Column<SqlTinyInt> OperationalState = new Column<SqlTinyInt>("operational_state");
        
        public static readonly Column<SqlNVarchar> OperationalStateDesc = new Column<SqlNVarchar>("operational_state_desc");
        
        public static readonly Column<SqlTinyInt> RecoveryHealth = new Column<SqlTinyInt>("recovery_health");
        
        public static readonly Column<SqlNVarchar> RecoveryHealthDesc = new Column<SqlNVarchar>("recovery_health_desc");
        
        public static readonly Column<SqlUniqueIdentifier> ReplicaId = new Column<SqlUniqueIdentifier>("replica_id");
        
        public static readonly Column<SqlTinyInt> Role = new Column<SqlTinyInt>("role");
        
        public static readonly Column<SqlNVarchar> RoleDesc = new Column<SqlNVarchar>("role_desc");
        
        public static readonly Column<SqlTinyInt> SynchronizationHealth = new Column<SqlTinyInt>("synchronization_health");
        
        public static readonly Column<SqlNVarchar> SynchronizationHealthDesc = new Column<SqlNVarchar>("synchronization_health_desc");
    }
}
