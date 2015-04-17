using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmExecBackgroundJobQueue
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_exec_background_job_queue");
        
        public static readonly Column<SqlInt> DatabaseId = new Column<SqlInt>("database_id");
        
        public static readonly Column<SqlInt> ErrorCode = new Column<SqlInt>("error_code");
        
        public static readonly Column<SqlSmallInt> InProgress = new Column<SqlSmallInt>("in_progress");
        
        public static readonly Column<SqlInt> JobId = new Column<SqlInt>("job_id");
        
        public static readonly Column<SqlInt> ObjectId1 = new Column<SqlInt>("object_id1");
        
        public static readonly Column<SqlInt> ObjectId2 = new Column<SqlInt>("object_id2");
        
        public static readonly Column<SqlInt> ObjectId3 = new Column<SqlInt>("object_id3");
        
        public static readonly Column<SqlInt> ObjectId4 = new Column<SqlInt>("object_id4");
        
        public static readonly Column<SqlSmallInt> RequestType = new Column<SqlSmallInt>("request_type");
        
        public static readonly Column<SqlSmallInt> RetryCount = new Column<SqlSmallInt>("retry_count");
        
        public static readonly Column<SqlSmallInt> SessionId = new Column<SqlSmallInt>("session_id");
        
        public static readonly Column<SqlDateTime> TimeQueued = new Column<SqlDateTime>("time_queued");
    }
}
