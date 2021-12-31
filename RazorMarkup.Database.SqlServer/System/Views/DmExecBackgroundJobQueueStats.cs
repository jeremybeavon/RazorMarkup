using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmExecBackgroundJobQueueStats
    {
        public static readonly ViewName ViewName = new("sys.dm_exec_background_job_queue_stats");

        public static readonly Column<SqlInt> ElapsedAvgMs = new("elapsed_avg_ms");

        public static readonly Column<SqlInt> ElapsedMaxMs = new("elapsed_max_ms");

        public static readonly Column<SqlInt> EndedCount = new("ended_count");

        public static readonly Column<SqlInt> EnqueueFailedDuplicateCount = new("enqueue_failed_duplicate_count");

        public static readonly Column<SqlInt> EnqueueFailedFullCount = new("enqueue_failed_full_count");

        public static readonly Column<SqlInt> EnqueuedCount = new("enqueued_count");

        public static readonly Column<SqlInt> FailedGiveupCount = new("failed_giveup_count");

        public static readonly Column<SqlInt> FailedLockCount = new("failed_lock_count");

        public static readonly Column<SqlInt> FailedOtherCount = new("failed_other_count");

        public static readonly Column<SqlInt> QueueMaxLen = new("queue_max_len");

        public static readonly Column<SqlInt> StartedCount = new("started_count");
    }
}
