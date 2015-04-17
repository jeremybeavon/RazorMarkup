using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmIoPendingIoRequests
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_io_pending_io_requests");
        
        public static readonly Column<SqlVarbinary> IoCompletionRequestAddress = new Column<SqlVarbinary>("io_completion_request_address");
        
        public static readonly Column<SqlVarbinary> IoCompletionRoutineAddress = new Column<SqlVarbinary>("io_completion_routine_address");
        
        public static readonly Column<SqlVarbinary> IoHandle = new Column<SqlVarbinary>("io_handle");
        
        public static readonly Column<SqlBigInt> IoOffset = new Column<SqlBigInt>("io_offset");
        
        public static readonly Column<SqlInt> IoPending = new Column<SqlInt>("io_pending");
        
        public static readonly Column<SqlBigInt> IoPendingMsTicks = new Column<SqlBigInt>("io_pending_ms_ticks");
        
        public static readonly Column<SqlNVarchar> IoType = new Column<SqlNVarchar>("io_type");
        
        public static readonly Column<SqlVarbinary> IoUserDataAddress = new Column<SqlVarbinary>("io_user_data_address");
        
        public static readonly Column<SqlVarbinary> SchedulerAddress = new Column<SqlVarbinary>("scheduler_address");
    }
}
