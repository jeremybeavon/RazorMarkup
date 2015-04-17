using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmFilestreamNonTransactedHandles
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_filestream_non_transacted_handles");
        
        public static readonly Column<SqlVarbinary> CorrelationProcessId = new Column<SqlVarbinary>("correlation_process_id");
        
        public static readonly Column<SqlVarbinary> CorrelationThreadId = new Column<SqlVarbinary>("correlation_thread_id");
        
        public static readonly Column<SqlInt> CreateDisposition = new Column<SqlInt>("create_disposition");
        
        public static readonly Column<SqlInt> CurrentWorkitemType = new Column<SqlInt>("current_workitem_type");
        
        public static readonly Column<SqlNVarchar> CurrentWorkitemTypeDesc = new Column<SqlNVarchar>("current_workitem_type_desc");
        
        public static readonly Column<SqlNVarchar> DatabaseDirectoryName = new Column<SqlNVarchar>("database_directory_name");
        
        public static readonly Column<SqlInt> DatabaseId = new Column<SqlInt>("database_id");
        
        public static readonly Column<SqlBit> DeleteAccess = new Column<SqlBit>("delete_access");
        
        public static readonly Column<SqlBigInt> FcbId = new Column<SqlBigInt>("fcb_id");
        
        public static readonly Column<SqlVarbinary> FileContext = new Column<SqlVarbinary>("file_context");
        
        public static readonly Column<SqlInt> FileObjectType = new Column<SqlInt>("file_object_type");
        
        public static readonly Column<SqlNVarchar> FileObjectTypeDesc = new Column<SqlNVarchar>("file_object_type_desc");
        
        public static readonly Column<SqlInt> Flags = new Column<SqlInt>("flags");
        
        public static readonly Column<SqlInt> HandleId = new Column<SqlInt>("handle_id");
        
        public static readonly Column<SqlBit> IsDirectory = new Column<SqlBit>("is_directory");
        
        public static readonly Column<SqlVarbinary> ItemId = new Column<SqlVarbinary>("item_id");
        
        public static readonly Column<SqlNVarchar> ItemName = new Column<SqlNVarchar>("item_name");
        
        public static readonly Column<SqlInt> LoginId = new Column<SqlInt>("login_id");
        
        public static readonly Column<SqlNVarchar> LoginName = new Column<SqlNVarchar>("login_name");
        
        public static readonly Column<SqlVarbinary> LoginSid = new Column<SqlVarbinary>("login_sid");
        
        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");
        
        public static readonly Column<SqlDateTime> OpenTime = new Column<SqlDateTime>("open_time");
        
        public static readonly Column<SqlNVarchar> OpenedFileName = new Column<SqlNVarchar>("opened_file_name");
        
        public static readonly Column<SqlBit> ReadAccess = new Column<SqlBit>("read_access");
        
        public static readonly Column<SqlNVarchar> RemainingFileName = new Column<SqlNVarchar>("remaining_file_name");
        
        public static readonly Column<SqlBit> ShareDelete = new Column<SqlBit>("share_delete");
        
        public static readonly Column<SqlBit> ShareRead = new Column<SqlBit>("share_read");
        
        public static readonly Column<SqlBit> ShareWrite = new Column<SqlBit>("share_write");
        
        public static readonly Column<SqlInt> State = new Column<SqlInt>("state");
        
        public static readonly Column<SqlNVarchar> StateDesc = new Column<SqlNVarchar>("state_desc");
        
        public static readonly Column<SqlNVarchar> TableDirectoryName = new Column<SqlNVarchar>("table_directory_name");
        
        public static readonly Column<SqlBit> WriteAccess = new Column<SqlBit>("write_access");
    }
}
