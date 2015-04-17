using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmHadrAvailabilityGroupStates
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_hadr_availability_group_states");
        
        public static readonly Column<SqlUniqueIdentifier> GroupId = new Column<SqlUniqueIdentifier>("group_id");
        
        public static readonly Column<SqlTinyInt> PrimaryRecoveryHealth = new Column<SqlTinyInt>("primary_recovery_health");
        
        public static readonly Column<SqlNVarchar> PrimaryRecoveryHealthDesc = new Column<SqlNVarchar>("primary_recovery_health_desc");
        
        public static readonly Column<SqlNVarchar> PrimaryReplica = new Column<SqlNVarchar>("primary_replica");
        
        public static readonly Column<SqlTinyInt> SecondaryRecoveryHealth = new Column<SqlTinyInt>("secondary_recovery_health");
        
        public static readonly Column<SqlNVarchar> SecondaryRecoveryHealthDesc = new Column<SqlNVarchar>("secondary_recovery_health_desc");
        
        public static readonly Column<SqlTinyInt> SynchronizationHealth = new Column<SqlTinyInt>("synchronization_health");
        
        public static readonly Column<SqlNVarchar> SynchronizationHealthDesc = new Column<SqlNVarchar>("synchronization_health_desc");
    }
}
