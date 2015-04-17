using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmDbScriptLevel
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_db_script_level");
        
        public static readonly Column<SqlInt> DatabaseId = new Column<SqlInt>("database_id");
        
        public static readonly Column<SqlInt> DowngradeStartLevel = new Column<SqlInt>("downgrade_start_level");
        
        public static readonly Column<SqlInt> DowngradeTargetLevel = new Column<SqlInt>("downgrade_target_level");
        
        public static readonly Column<SqlInt> ScriptId = new Column<SqlInt>("script_id");
        
        public static readonly Column<SqlInt> ScriptLevel = new Column<SqlInt>("script_level");
        
        public static readonly Column<SqlNVarchar> ScriptName = new Column<SqlNVarchar>("script_name");
        
        public static readonly Column<SqlInt> UpgradeStartLevel = new Column<SqlInt>("upgrade_start_level");
        
        public static readonly Column<SqlInt> UpgradeTargetLevel = new Column<SqlInt>("upgrade_target_level");
        
        public static readonly Column<SqlInt> Version = new Column<SqlInt>("version");
    }
}
