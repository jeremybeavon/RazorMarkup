using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsMemoryCacheHashTables
    {
        public static readonly ViewName ViewName = new("sys.dm_os_memory_cache_hash_tables");

        public static readonly Column<SqlInt> BucketsAvgLength = new("buckets_avg_length");

        public static readonly Column<SqlInt> BucketsAvgScanHitLength = new("buckets_avg_scan_hit_length");

        public static readonly Column<SqlInt> BucketsAvgScanMissLength = new("buckets_avg_scan_miss_length");

        public static readonly Column<SqlInt> BucketsCount = new("buckets_count");

        public static readonly Column<SqlInt> BucketsInUseCount = new("buckets_in_use_count");

        public static readonly Column<SqlInt> BucketsMaxLength = new("buckets_max_length");

        public static readonly Column<SqlInt> BucketsMaxLengthEver = new("buckets_max_length_ever");

        public static readonly Column<SqlInt> BucketsMinLength = new("buckets_min_length");

        public static readonly Column<SqlVarbinary> CacheAddress = new("cache_address");

        public static readonly Column<SqlBigInt> HitsCount = new("hits_count");

        public static readonly Column<SqlBigInt> MissesCount = new("misses_count");

        public static readonly Column<SqlNVarchar> Name = new("name");

        public static readonly Column<SqlInt> TableLevel = new("table_level");

        public static readonly Column<SqlNVarchar> Type = new("type");
    }
}
