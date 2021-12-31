using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmLogpoolStats
    {
        public static readonly ViewName ViewName = new("sys.dm_logpool_stats");

        public static readonly Column<SqlInt> HashBucketCount = new("hash_bucket_count");

        public static readonly Column<SqlBigInt> HashHitTotalSearchLength = new("hash_hit_total_search_length");

        public static readonly Column<SqlBigInt> HashHits = new("hash_hits");

        public static readonly Column<SqlBigInt> HashMissTotalSearchLength = new("hash_miss_total_search_length");

        public static readonly Column<SqlBigInt> HashMisses = new("hash_misses");

        public static readonly Column<SqlInt> LogpoolmgrCount = new("logpoolmgr_count");

        public static readonly Column<SqlInt> MemStatus = new("mem_status");

        public static readonly Column<SqlBigInt> MemStatusStamp = new("mem_status_stamp");
    }
}
