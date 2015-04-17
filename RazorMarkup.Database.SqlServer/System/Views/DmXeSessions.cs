using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmXeSessions
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_xe_sessions");
        
        public static readonly Column<SqlVarbinary> Address = new Column<SqlVarbinary>("address");
        
        public static readonly Column<SqlInt> BlockedEventFireTime = new Column<SqlInt>("blocked_event_fire_time");
        
        public static readonly Column<SqlNVarchar> BufferPolicyDesc = new Column<SqlNVarchar>("buffer_policy_desc");
        
        public static readonly Column<SqlInt> BufferPolicyFlags = new Column<SqlInt>("buffer_policy_flags");
        
        public static readonly Column<SqlDateTime> CreateTime = new Column<SqlDateTime>("create_time");
        
        public static readonly Column<SqlInt> DroppedBufferCount = new Column<SqlInt>("dropped_buffer_count");
        
        public static readonly Column<SqlInt> DroppedEventCount = new Column<SqlInt>("dropped_event_count");
        
        public static readonly Column<SqlNVarchar> FlagDesc = new Column<SqlNVarchar>("flag_desc");
        
        public static readonly Column<SqlInt> Flags = new Column<SqlInt>("flags");
        
        public static readonly Column<SqlBigInt> LargeBufferSize = new Column<SqlBigInt>("large_buffer_size");
        
        public static readonly Column<SqlInt> LargestEventDroppedSize = new Column<SqlInt>("largest_event_dropped_size");
        
        public static readonly Column<SqlNVarchar> Name = new Column<SqlNVarchar>("name");
        
        public static readonly Column<SqlInt> PendingBuffers = new Column<SqlInt>("pending_buffers");
        
        public static readonly Column<SqlBigInt> RegularBufferSize = new Column<SqlBigInt>("regular_buffer_size");
        
        public static readonly Column<SqlBigInt> TotalBufferSize = new Column<SqlBigInt>("total_buffer_size");
        
        public static readonly Column<SqlInt> TotalLargeBuffers = new Column<SqlInt>("total_large_buffers");
        
        public static readonly Column<SqlInt> TotalRegularBuffers = new Column<SqlInt>("total_regular_buffers");
    }
}
