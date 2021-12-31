using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmAuditActions
    {
        public static readonly ViewName ViewName = new("sys.dm_audit_actions");

        public static readonly Column<SqlVarchar> ActionId = new("action_id");

        public static readonly Column<SqlBit> ActionInLog = new("action_in_log");

        public static readonly Column<SqlNVarchar> ClassDesc = new("class_desc");

        public static readonly Column<SqlNVarchar> ConfigurationLevel = new("configuration_level");

        public static readonly Column<SqlNVarchar> ContainingGroupName = new("containing_group_name");

        public static readonly Column<SqlNVarchar> CoveringActionName = new("covering_action_name");

        public static readonly Column<SqlNVarchar> CoveringParentActionName = new("covering_parent_action_name");

        public static readonly Column<SqlNVarchar> Name = new("name");

        public static readonly Column<SqlNVarchar> ParentClassDesc = new("parent_class_desc");
    }
}
