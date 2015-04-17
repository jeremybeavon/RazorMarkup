using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmLogpoolHashentries
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_logpool_hashentries");
        
        public static readonly Column<SqlInt> BucketNo = new Column<SqlInt>("bucket_no");
        
        public static readonly Column<SqlVarbinary> CacheBuffer = new Column<SqlVarbinary>("cache_buffer");
        
        public static readonly Column<SqlInt> DatabaseId = new Column<SqlInt>("database_id");
        
        public static readonly Column<SqlBigInt> LogBlockId = new Column<SqlBigInt>("log_block_id");
        
        public static readonly Column<SqlInt> RecoveryUnitId = new Column<SqlInt>("recovery_unit_id");
    }
}
