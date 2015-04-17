using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmAuditActions
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_audit_actions");
        
        public static readonly Column<SqlVarchar> ActionId = new Column<SqlVarchar>("action_id");
        
        public static readonly Column<SqlBit> ActionInLog = new Column<SqlBit>("action_in_log");
        
        public static readonly Column<SqlNVarchar> ClassDesc = new Column<SqlNVarchar>("class_desc");
        
        public static readonly Column<SqlNVarchar> ConfigurationLevel = new Column<SqlNVarchar>("configuration_level");
        
        public static readonly Column<SqlNVarchar> ContainingGroupName = new Column<SqlNVarchar>("containing_group_name");
        
        public static readonly Column<SqlNVarchar> CoveringActionName = new Column<SqlNVarchar>("covering_action_name");
        
        public static readonly Column<SqlNVarchar> CoveringParentActionName = new Column<SqlNVarchar>("covering_parent_action_name");
        
        public static readonly Column<SqlNVarchar> Name = new Column<SqlNVarchar>("name");
        
        public static readonly Column<SqlNVarchar> ParentClassDesc = new Column<SqlNVarchar>("parent_class_desc");
    }
}
