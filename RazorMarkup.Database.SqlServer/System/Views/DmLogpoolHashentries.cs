using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmLogpoolHashentries
    {
        public static readonly ViewName ViewName = new("sys.dm_logpool_hashentries");

        public static readonly Column<SqlInt> BucketNo = new("bucket_no");

        public static readonly Column<SqlVarbinary> CacheBuffer = new("cache_buffer");

        public static readonly Column<SqlInt> DatabaseId = new("database_id");

        public static readonly Column<SqlBigInt> LogBlockId = new("log_block_id");

        public static readonly Column<SqlInt> RecoveryUnitId = new("recovery_unit_id");
    }
}
