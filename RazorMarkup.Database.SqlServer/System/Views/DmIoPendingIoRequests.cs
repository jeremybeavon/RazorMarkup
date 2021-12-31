using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmIoPendingIoRequests
    {
        public static readonly ViewName ViewName = new("sys.dm_io_pending_io_requests");

        public static readonly Column<SqlVarbinary> IoCompletionRequestAddress = new("io_completion_request_address");

        public static readonly Column<SqlVarbinary> IoCompletionRoutineAddress = new("io_completion_routine_address");

        public static readonly Column<SqlVarbinary> IoHandle = new("io_handle");

        public static readonly Column<SqlBigInt> IoOffset = new("io_offset");

        public static readonly Column<SqlInt> IoPending = new("io_pending");

        public static readonly Column<SqlBigInt> IoPendingMsTicks = new("io_pending_ms_ticks");

        public static readonly Column<SqlNVarchar> IoType = new("io_type");

        public static readonly Column<SqlVarbinary> IoUserDataAddress = new("io_user_data_address");

        public static readonly Column<SqlVarbinary> SchedulerAddress = new("scheduler_address");
    }
}
