using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmDbScriptLevel
    {
        public static readonly ViewName ViewName = new("sys.dm_db_script_level");

        public static readonly Column<SqlInt> DatabaseId = new("database_id");

        public static readonly Column<SqlInt> DowngradeStartLevel = new("downgrade_start_level");

        public static readonly Column<SqlInt> DowngradeTargetLevel = new("downgrade_target_level");

        public static readonly Column<SqlInt> ScriptId = new("script_id");

        public static readonly Column<SqlInt> ScriptLevel = new("script_level");

        public static readonly Column<SqlNVarchar> ScriptName = new("script_name");

        public static readonly Column<SqlInt> UpgradeStartLevel = new("upgrade_start_level");

        public static readonly Column<SqlInt> UpgradeTargetLevel = new("upgrade_target_level");

        public static readonly Column<SqlInt> Version = new("version");
    }
}
