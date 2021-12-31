using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmHadrAvailabilityGroupStates
    {
        public static readonly ViewName ViewName = new("sys.dm_hadr_availability_group_states");

        public static readonly Column<SqlUniqueIdentifier> GroupId = new("group_id");

        public static readonly Column<SqlTinyInt> PrimaryRecoveryHealth = new("primary_recovery_health");

        public static readonly Column<SqlNVarchar> PrimaryRecoveryHealthDesc = new("primary_recovery_health_desc");

        public static readonly Column<SqlNVarchar> PrimaryReplica = new("primary_replica");

        public static readonly Column<SqlTinyInt> SecondaryRecoveryHealth = new("secondary_recovery_health");

        public static readonly Column<SqlNVarchar> SecondaryRecoveryHealthDesc = new("secondary_recovery_health_desc");

        public static readonly Column<SqlTinyInt> SynchronizationHealth = new("synchronization_health");

        public static readonly Column<SqlNVarchar> SynchronizationHealthDesc = new("synchronization_health_desc");
    }
}
