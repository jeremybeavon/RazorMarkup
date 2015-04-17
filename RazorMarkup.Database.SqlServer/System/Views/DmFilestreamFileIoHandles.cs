using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmFilestreamFileIoHandles
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_filestream_file_io_handles");
        
        public static readonly Column<SqlNVarchar> AccessType = new Column<SqlNVarchar>("access_type");
        
        public static readonly Column<SqlVarbinary> CreationClientProcessId = new Column<SqlVarbinary>("creation_client_process_id");
        
        public static readonly Column<SqlVarbinary> CreationClientThreadId = new Column<SqlVarbinary>("creation_client_thread_id");
        
        public static readonly Column<SqlInt> CreationIrpId = new Column<SqlInt>("creation_irp_id");
        
        public static readonly Column<SqlInt> CreationRequestId = new Column<SqlInt>("creation_request_id");
        
        public static readonly Column<SqlVarbinary> FilestreamTransactionId = new Column<SqlVarbinary>("filestream_transaction_id");
        
        public static readonly Column<SqlVarbinary> HandleContextAddress = new Column<SqlVarbinary>("handle_context_address");
        
        public static readonly Column<SqlInt> HandleId = new Column<SqlInt>("handle_id");
        
        public static readonly Column<SqlNVarchar> LogicalPath = new Column<SqlNVarchar>("logical_path");
        
        public static readonly Column<SqlNVarchar> PhysicalPath = new Column<SqlNVarchar>("physical_path");
    }
}
