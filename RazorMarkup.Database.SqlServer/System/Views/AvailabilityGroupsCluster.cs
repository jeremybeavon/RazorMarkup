using RazorMarkup.Database.SqlServer.System.Views.Values;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public abstract class AvailabilityGroupsCluster
    {
        public static readonly ViewName ViewName = new ViewName("sys.availablity_groups_cluster");

        public static readonly Column<SqlUniqueIdentifier> GroupId = new Column<SqlUniqueIdentifier>("group_id");

        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");

        public static readonly Column<SqlNVarchar> ResourceId = new Column<SqlNVarchar>("resource_id");

        public static readonly Column<SqlNVarchar> ResourceGroupId = new Column<SqlNVarchar>("resource_group_id");

        public static readonly Column<SqlInt> FailureConditionLevel = new Column<SqlInt>("failure_condition_level");

        public static readonly Column<SqlInt> HealthCheckTimeout = new Column<SqlInt>("health_check_timeout");

        public static readonly Column<SqlTinyInt, AvailabilityGroupsAutomatedBackupPreference> AutomatedBackupPreference =
            new Column<SqlTinyInt, AvailabilityGroupsAutomatedBackupPreference>("automated_backup_preference");

        public static readonly Column<SqlNVarchar, AvailabilityGroupsAutomatedBackupPreferenceDescriptions> AutomatedBackupPreferenceDescriptions =
             new Column<SqlNVarchar, AvailabilityGroupsAutomatedBackupPreferenceDescriptions>("automated_backup_preference_desc");
    }
}
