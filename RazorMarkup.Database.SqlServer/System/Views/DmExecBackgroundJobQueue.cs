using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmExecBackgroundJobQueue
    {
        public static readonly ViewName ViewName = new("sys.dm_exec_background_job_queue");

        public static readonly Column<SqlInt> DatabaseId = new("database_id");

        public static readonly Column<SqlInt> ErrorCode = new("error_code");

        public static readonly Column<SqlSmallInt> InProgress = new("in_progress");

        public static readonly Column<SqlInt> JobId = new("job_id");

        public static readonly Column<SqlInt> ObjectId1 = new("object_id1");

        public static readonly Column<SqlInt> ObjectId2 = new("object_id2");

        public static readonly Column<SqlInt> ObjectId3 = new("object_id3");

        public static readonly Column<SqlInt> ObjectId4 = new("object_id4");

        public static readonly Column<SqlSmallInt> RequestType = new("request_type");

        public static readonly Column<SqlSmallInt> RetryCount = new("retry_count");

        public static readonly Column<SqlSmallInt> SessionId = new("session_id");

        public static readonly Column<SqlDateTime> TimeQueued = new("time_queued");
    }
}
