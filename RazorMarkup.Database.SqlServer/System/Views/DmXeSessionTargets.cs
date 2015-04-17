using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmXeSessionTargets
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_xe_session_targets");
        
        public static readonly Column<SqlVarbinary> EventSessionAddress = new Column<SqlVarbinary>("event_session_address");
        
        public static readonly Column<SqlBigInt> ExecutionCount = new Column<SqlBigInt>("execution_count");
        
        public static readonly Column<SqlBigInt> ExecutionDurationMs = new Column<SqlBigInt>("execution_duration_ms");
        
        public static readonly Column<SqlNVarchar> TargetData = new Column<SqlNVarchar>("target_data");
        
        public static readonly Column<SqlNVarchar> TargetName = new Column<SqlNVarchar>("target_name");
        
        public static readonly Column<SqlUniqueIdentifier> TargetPackageGuid = new Column<SqlUniqueIdentifier>("target_package_guid");
    }
}
