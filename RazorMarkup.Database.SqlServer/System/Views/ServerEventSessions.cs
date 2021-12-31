using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ServerEventSessions
    {
        public static readonly ViewName ViewName = new("sys.server_event_sessions");

        public static readonly Column<SqlChar> EventRetentionMode = new("event_retention_mode");

        public static readonly Column<SqlNVarchar> EventRetentionModeDesc = new("event_retention_mode_desc");

        public static readonly Column<SqlInt> EventSessionId = new("event_session_id");

        public static readonly Column<SqlInt> MaxDispatchLatency = new("max_dispatch_latency");

        public static readonly Column<SqlInt> MaxEventSize = new("max_event_size");

        public static readonly Column<SqlInt> MaxMemory = new("max_memory");

        public static readonly Column<SqlChar> MemoryPartitionMode = new("memory_partition_mode");

        public static readonly Column<SqlNVarchar> MemoryPartitionModeDesc = new("memory_partition_mode_desc");

        public static readonly Column<SqlNVarchar> Name = new("name");

        public static readonly Column<SqlBit> StartupState = new("startup_state");

        public static readonly Column<SqlBit> TrackCausality = new("track_causality");
    }
}
