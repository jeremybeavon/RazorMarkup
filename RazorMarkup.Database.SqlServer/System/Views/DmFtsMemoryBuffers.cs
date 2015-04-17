using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmFtsMemoryBuffers
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_fts_memory_buffers");
        
        public static readonly Column<SqlInt> BytesUsed = new Column<SqlInt>("bytes_used");
        
        public static readonly Column<SqlBit> IsFree = new Column<SqlBit>("is_free");
        
        public static readonly Column<SqlVarbinary> MemoryAddress = new Column<SqlVarbinary>("memory_address");
        
        public static readonly Column<SqlNVarchar> Name = new Column<SqlNVarchar>("name");
        
        public static readonly Column<SqlInt> PercentUsed = new Column<SqlInt>("percent_used");
        
        public static readonly Column<SqlInt> PoolId = new Column<SqlInt>("pool_id");
        
        public static readonly Column<SqlInt> RowCount = new Column<SqlInt>("row_count");
    }
}
