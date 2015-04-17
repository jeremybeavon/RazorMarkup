using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmDbTaskSpaceUsage
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_db_task_space_usage");
        
        public static readonly Column<SqlInt> DatabaseId = new Column<SqlInt>("database_id");
        
        public static readonly Column<SqlInt> ExecContextId = new Column<SqlInt>("exec_context_id");
        
        public static readonly Column<SqlBigInt> InternalObjectsAllocPageCount = new Column<SqlBigInt>("internal_objects_alloc_page_count");
        
        public static readonly Column<SqlBigInt> InternalObjectsDeallocPageCount = new Column<SqlBigInt>("internal_objects_dealloc_page_count");
        
        public static readonly Column<SqlBit> IsRemoteTask = new Column<SqlBit>("is_remote_task");
        
        public static readonly Column<SqlInt> RequestId = new Column<SqlInt>("request_id");
        
        public static readonly Column<SqlSmallInt> SessionId = new Column<SqlSmallInt>("session_id");
        
        public static readonly Column<SqlVarbinary> TaskAddress = new Column<SqlVarbinary>("task_address");
        
        public static readonly Column<SqlBigInt> UserObjectsAllocPageCount = new Column<SqlBigInt>("user_objects_alloc_page_count");
        
        public static readonly Column<SqlBigInt> UserObjectsDeallocPageCount = new Column<SqlBigInt>("user_objects_dealloc_page_count");
    }
}
