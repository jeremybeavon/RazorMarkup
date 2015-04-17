using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmLogpoolStats
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_logpool_stats");
        
        public static readonly Column<SqlInt> HashBucketCount = new Column<SqlInt>("hash_bucket_count");
        
        public static readonly Column<SqlBigInt> HashHitTotalSearchLength = new Column<SqlBigInt>("hash_hit_total_search_length");
        
        public static readonly Column<SqlBigInt> HashHits = new Column<SqlBigInt>("hash_hits");
        
        public static readonly Column<SqlBigInt> HashMissTotalSearchLength = new Column<SqlBigInt>("hash_miss_total_search_length");
        
        public static readonly Column<SqlBigInt> HashMisses = new Column<SqlBigInt>("hash_misses");
        
        public static readonly Column<SqlInt> LogpoolmgrCount = new Column<SqlInt>("logpoolmgr_count");
        
        public static readonly Column<SqlInt> MemStatus = new Column<SqlInt>("mem_status");
        
        public static readonly Column<SqlBigInt> MemStatusStamp = new Column<SqlBigInt>("mem_status_stamp");
    }
}
