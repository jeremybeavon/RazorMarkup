using RazorMarkup.Database.SqlServer.System.Views.Values;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public abstract class AvailabilityGroupsCluster
    {
        public static readonly ViewName ViewName = new("sys.availablity_groups_cluster");

        public static readonly Column<SqlUniqueIdentifier> GroupId = new("group_id");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlNVarchar> ResourceId = new("resource_id");

        public static readonly Column<SqlNVarchar> ResourceGroupId = new("resource_group_id");

        public static readonly Column<SqlInt> FailureConditionLevel = new("failure_condition_level");

        public static readonly Column<SqlInt> HealthCheckTimeout = new("health_check_timeout");

        public static readonly Column<SqlTinyInt, AvailabilityGroupsAutomatedBackupPreference> AutomatedBackupPreference =
            new("automated_backup_preference");

        public static readonly Column<SqlNVarchar, AvailabilityGroupsAutomatedBackupPreferenceDescriptions> AutomatedBackupPreferenceDescriptions =
             new("automated_backup_preference_desc");
    }
}
