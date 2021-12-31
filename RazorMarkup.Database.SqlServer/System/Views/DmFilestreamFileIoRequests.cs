using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmFilestreamFileIoRequests
    {
        public static readonly ViewName ViewName = new("sys.dm_filestream_file_io_requests");

        public static readonly Column<SqlVarbinary> ClientProcessId = new("client_process_id");

        public static readonly Column<SqlVarbinary> ClientThreadId = new("client_thread_id");

        public static readonly Column<SqlSmallInt> CurrentSpid = new("current_spid");

        public static readonly Column<SqlVarbinary> FilestreamTransactionId = new("filestream_transaction_id");

        public static readonly Column<SqlVarbinary> HandleContextAddress = new("handle_context_address");

        public static readonly Column<SqlInt> HandleId = new("handle_id");

        public static readonly Column<SqlInt> IrpId = new("irp_id");

        public static readonly Column<SqlVarbinary> RequestContextAddress = new("request_context_address");

        public static readonly Column<SqlInt> RequestId = new("request_id");

        public static readonly Column<SqlNVarchar> RequestState = new("request_state");

        public static readonly Column<SqlNVarchar> RequestType = new("request_type");
    }
}
