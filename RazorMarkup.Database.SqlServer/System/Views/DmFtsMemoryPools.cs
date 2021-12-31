using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmFtsMemoryPools
    {
        public static readonly ViewName ViewName = new("sys.dm_fts_memory_pools");

        public static readonly Column<SqlInt> BufferCount = new("buffer_count");

        public static readonly Column<SqlInt> BufferSize = new("buffer_size");

        public static readonly Column<SqlInt> MaxBufferLimit = new("max_buffer_limit");

        public static readonly Column<SqlInt> MinBufferLimit = new("min_buffer_limit");

        public static readonly Column<SqlInt> PoolId = new("pool_id");
    }
}
