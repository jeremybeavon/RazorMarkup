using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsRingBuffers
    {
        public static readonly ViewName ViewName = new("sys.dm_os_ring_buffers");

        public static readonly Column<SqlNVarchar> Record = new("record");

        public static readonly Column<SqlVarbinary> RingBufferAddress = new("ring_buffer_address");

        public static readonly Column<SqlNVarchar> RingBufferType = new("ring_buffer_type");

        public static readonly Column<SqlBigInt> Timestamp = new("timestamp");
    }
}
