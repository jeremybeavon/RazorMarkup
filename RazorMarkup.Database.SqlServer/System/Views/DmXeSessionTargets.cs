using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmXeSessionTargets
    {
        public static readonly ViewName ViewName = new("sys.dm_xe_session_targets");

        public static readonly Column<SqlVarbinary> EventSessionAddress = new("event_session_address");

        public static readonly Column<SqlBigInt> ExecutionCount = new("execution_count");

        public static readonly Column<SqlBigInt> ExecutionDurationMs = new("execution_duration_ms");

        public static readonly Column<SqlNVarchar> TargetData = new("target_data");

        public static readonly Column<SqlNVarchar> TargetName = new("target_name");

        public static readonly Column<SqlUniqueIdentifier> TargetPackageGuid = new("target_package_guid");
    }
}
