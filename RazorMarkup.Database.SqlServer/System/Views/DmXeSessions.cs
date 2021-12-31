using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmXeSessions
    {
        public static readonly ViewName ViewName = new("sys.dm_xe_sessions");

        public static readonly Column<SqlVarbinary> Address = new("address");

        public static readonly Column<SqlInt> BlockedEventFireTime = new("blocked_event_fire_time");

        public static readonly Column<SqlNVarchar> BufferPolicyDesc = new("buffer_policy_desc");

        public static readonly Column<SqlInt> BufferPolicyFlags = new("buffer_policy_flags");

        public static readonly Column<SqlDateTime> CreateTime = new("create_time");

        public static readonly Column<SqlInt> DroppedBufferCount = new("dropped_buffer_count");

        public static readonly Column<SqlInt> DroppedEventCount = new("dropped_event_count");

        public static readonly Column<SqlNVarchar> FlagDesc = new("flag_desc");

        public static readonly Column<SqlInt> Flags = new("flags");

        public static readonly Column<SqlBigInt> LargeBufferSize = new("large_buffer_size");

        public static readonly Column<SqlInt> LargestEventDroppedSize = new("largest_event_dropped_size");

        public static readonly Column<SqlNVarchar> Name = new("name");

        public static readonly Column<SqlInt> PendingBuffers = new("pending_buffers");

        public static readonly Column<SqlBigInt> RegularBufferSize = new("regular_buffer_size");

        public static readonly Column<SqlBigInt> TotalBufferSize = new("total_buffer_size");

        public static readonly Column<SqlInt> TotalLargeBuffers = new("total_large_buffers");

        public static readonly Column<SqlInt> TotalRegularBuffers = new("total_regular_buffers");
    }
}
