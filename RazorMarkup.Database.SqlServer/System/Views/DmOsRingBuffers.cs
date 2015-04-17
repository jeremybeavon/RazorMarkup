using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsRingBuffers
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_ring_buffers");
        
        public static readonly Column<SqlNVarchar> Record = new Column<SqlNVarchar>("record");
        
        public static readonly Column<SqlVarbinary> RingBufferAddress = new Column<SqlVarbinary>("ring_buffer_address");
        
        public static readonly Column<SqlNVarchar> RingBufferType = new Column<SqlNVarchar>("ring_buffer_type");
        
        public static readonly Column<SqlBigInt> Timestamp = new Column<SqlBigInt>("timestamp");
    }
}
