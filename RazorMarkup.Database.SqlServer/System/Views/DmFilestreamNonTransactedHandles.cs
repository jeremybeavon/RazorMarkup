using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmFilestreamNonTransactedHandles
    {
        public static readonly ViewName ViewName = new("sys.dm_filestream_non_transacted_handles");

        public static readonly Column<SqlVarbinary> CorrelationProcessId = new("correlation_process_id");

        public static readonly Column<SqlVarbinary> CorrelationThreadId = new("correlation_thread_id");

        public static readonly Column<SqlInt> CreateDisposition = new("create_disposition");

        public static readonly Column<SqlInt> CurrentWorkitemType = new("current_workitem_type");

        public static readonly Column<SqlNVarchar> CurrentWorkitemTypeDesc = new("current_workitem_type_desc");

        public static readonly Column<SqlNVarchar> DatabaseDirectoryName = new("database_directory_name");

        public static readonly Column<SqlInt> DatabaseId = new("database_id");

        public static readonly Column<SqlBit> DeleteAccess = new("delete_access");

        public static readonly Column<SqlBigInt> FcbId = new("fcb_id");

        public static readonly Column<SqlVarbinary> FileContext = new("file_context");

        public static readonly Column<SqlInt> FileObjectType = new("file_object_type");

        public static readonly Column<SqlNVarchar> FileObjectTypeDesc = new("file_object_type_desc");

        public static readonly Column<SqlInt> Flags = new("flags");

        public static readonly Column<SqlInt> HandleId = new("handle_id");

        public static readonly Column<SqlBit> IsDirectory = new("is_directory");

        public static readonly Column<SqlVarbinary> ItemId = new("item_id");

        public static readonly Column<SqlNVarchar> ItemName = new("item_name");

        public static readonly Column<SqlInt> LoginId = new("login_id");

        public static readonly Column<SqlNVarchar> LoginName = new("login_name");

        public static readonly Column<SqlVarbinary> LoginSid = new("login_sid");

        public static readonly Column<SqlInt> ObjectId = new("object_id");

        public static readonly Column<SqlDateTime> OpenTime = new("open_time");

        public static readonly Column<SqlNVarchar> OpenedFileName = new("opened_file_name");

        public static readonly Column<SqlBit> ReadAccess = new("read_access");

        public static readonly Column<SqlNVarchar> RemainingFileName = new("remaining_file_name");

        public static readonly Column<SqlBit> ShareDelete = new("share_delete");

        public static readonly Column<SqlBit> ShareRead = new("share_read");

        public static readonly Column<SqlBit> ShareWrite = new("share_write");

        public static readonly Column<SqlInt> State = new("state");

        public static readonly Column<SqlNVarchar> StateDesc = new("state_desc");

        public static readonly Column<SqlNVarchar> TableDirectoryName = new("table_directory_name");

        public static readonly Column<SqlBit> WriteAccess = new("write_access");
    }
}
