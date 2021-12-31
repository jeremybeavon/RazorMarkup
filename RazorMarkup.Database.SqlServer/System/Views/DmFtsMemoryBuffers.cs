using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmFtsMemoryBuffers
    {
        public static readonly ViewName ViewName = new("sys.dm_fts_memory_buffers");

        public static readonly Column<SqlInt> BytesUsed = new("bytes_used");

        public static readonly Column<SqlBit> IsFree = new("is_free");

        public static readonly Column<SqlVarbinary> MemoryAddress = new("memory_address");

        public static readonly Column<SqlNVarchar> Name = new("name");

        public static readonly Column<SqlInt> PercentUsed = new("percent_used");

        public static readonly Column<SqlInt> PoolId = new("pool_id");

        public static readonly Column<SqlInt> RowCount = new("row_count");
    }
}
