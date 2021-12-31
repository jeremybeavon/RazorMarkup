using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmFilestreamFileIoHandles
    {
        public static readonly ViewName ViewName = new("sys.dm_filestream_file_io_handles");

        public static readonly Column<SqlNVarchar> AccessType = new("access_type");

        public static readonly Column<SqlVarbinary> CreationClientProcessId = new("creation_client_process_id");

        public static readonly Column<SqlVarbinary> CreationClientThreadId = new("creation_client_thread_id");

        public static readonly Column<SqlInt> CreationIrpId = new("creation_irp_id");

        public static readonly Column<SqlInt> CreationRequestId = new("creation_request_id");

        public static readonly Column<SqlVarbinary> FilestreamTransactionId = new("filestream_transaction_id");

        public static readonly Column<SqlVarbinary> HandleContextAddress = new("handle_context_address");

        public static readonly Column<SqlInt> HandleId = new("handle_id");

        public static readonly Column<SqlNVarchar> LogicalPath = new("logical_path");

        public static readonly Column<SqlNVarchar> PhysicalPath = new("physical_path");
    }
}
