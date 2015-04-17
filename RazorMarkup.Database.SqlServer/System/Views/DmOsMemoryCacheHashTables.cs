using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsMemoryCacheHashTables
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_memory_cache_hash_tables");
        
        public static readonly Column<SqlInt> BucketsAvgLength = new Column<SqlInt>("buckets_avg_length");
        
        public static readonly Column<SqlInt> BucketsAvgScanHitLength = new Column<SqlInt>("buckets_avg_scan_hit_length");
        
        public static readonly Column<SqlInt> BucketsAvgScanMissLength = new Column<SqlInt>("buckets_avg_scan_miss_length");
        
        public static readonly Column<SqlInt> BucketsCount = new Column<SqlInt>("buckets_count");
        
        public static readonly Column<SqlInt> BucketsInUseCount = new Column<SqlInt>("buckets_in_use_count");
        
        public static readonly Column<SqlInt> BucketsMaxLength = new Column<SqlInt>("buckets_max_length");
        
        public static readonly Column<SqlInt> BucketsMaxLengthEver = new Column<SqlInt>("buckets_max_length_ever");
        
        public static readonly Column<SqlInt> BucketsMinLength = new Column<SqlInt>("buckets_min_length");
        
        public static readonly Column<SqlVarbinary> CacheAddress = new Column<SqlVarbinary>("cache_address");
        
        public static readonly Column<SqlBigInt> HitsCount = new Column<SqlBigInt>("hits_count");
        
        public static readonly Column<SqlBigInt> MissesCount = new Column<SqlBigInt>("misses_count");
        
        public static readonly Column<SqlNVarchar> Name = new Column<SqlNVarchar>("name");
        
        public static readonly Column<SqlInt> TableLevel = new Column<SqlInt>("table_level");
        
        public static readonly Column<SqlNVarchar> Type = new Column<SqlNVarchar>("type");
    }
}
