using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmExecBackgroundJobQueueStats
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_exec_background_job_queue_stats");
        
        public static readonly Column<SqlInt> ElapsedAvgMs = new Column<SqlInt>("elapsed_avg_ms");
        
        public static readonly Column<SqlInt> ElapsedMaxMs = new Column<SqlInt>("elapsed_max_ms");
        
        public static readonly Column<SqlInt> EndedCount = new Column<SqlInt>("ended_count");
        
        public static readonly Column<SqlInt> EnqueueFailedDuplicateCount = new Column<SqlInt>("enqueue_failed_duplicate_count");
        
        public static readonly Column<SqlInt> EnqueueFailedFullCount = new Column<SqlInt>("enqueue_failed_full_count");
        
        public static readonly Column<SqlInt> EnqueuedCount = new Column<SqlInt>("enqueued_count");
        
        public static readonly Column<SqlInt> FailedGiveupCount = new Column<SqlInt>("failed_giveup_count");
        
        public static readonly Column<SqlInt> FailedLockCount = new Column<SqlInt>("failed_lock_count");
        
        public static readonly Column<SqlInt> FailedOtherCount = new Column<SqlInt>("failed_other_count");
        
        public static readonly Column<SqlInt> QueueMaxLen = new Column<SqlInt>("queue_max_len");
        
        public static readonly Column<SqlInt> StartedCount = new Column<SqlInt>("started_count");
    }
}
