using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmFtsMemoryPools
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_fts_memory_pools");
        
        public static readonly Column<SqlInt> BufferCount = new Column<SqlInt>("buffer_count");
        
        public static readonly Column<SqlInt> BufferSize = new Column<SqlInt>("buffer_size");
        
        public static readonly Column<SqlInt> MaxBufferLimit = new Column<SqlInt>("max_buffer_limit");
        
        public static readonly Column<SqlInt> MinBufferLimit = new Column<SqlInt>("min_buffer_limit");
        
        public static readonly Column<SqlInt> PoolId = new Column<SqlInt>("pool_id");
    }
}
