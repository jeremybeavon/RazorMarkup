using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmFilestreamFileIoRequests
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_filestream_file_io_requests");
        
        public static readonly Column<SqlVarbinary> ClientProcessId = new Column<SqlVarbinary>("client_process_id");
        
        public static readonly Column<SqlVarbinary> ClientThreadId = new Column<SqlVarbinary>("client_thread_id");
        
        public static readonly Column<SqlSmallInt> CurrentSpid = new Column<SqlSmallInt>("current_spid");
        
        public static readonly Column<SqlVarbinary> FilestreamTransactionId = new Column<SqlVarbinary>("filestream_transaction_id");
        
        public static readonly Column<SqlVarbinary> HandleContextAddress = new Column<SqlVarbinary>("handle_context_address");
        
        public static readonly Column<SqlInt> HandleId = new Column<SqlInt>("handle_id");
        
        public static readonly Column<SqlInt> IrpId = new Column<SqlInt>("irp_id");
        
        public static readonly Column<SqlVarbinary> RequestContextAddress = new Column<SqlVarbinary>("request_context_address");
        
        public static readonly Column<SqlInt> RequestId = new Column<SqlInt>("request_id");
        
        public static readonly Column<SqlNVarchar> RequestState = new Column<SqlNVarchar>("request_state");
        
        public static readonly Column<SqlNVarchar> RequestType = new Column<SqlNVarchar>("request_type");
    }
}
