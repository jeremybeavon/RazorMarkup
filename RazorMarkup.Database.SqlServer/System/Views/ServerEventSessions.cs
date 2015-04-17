using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ServerEventSessions
    {
        public static readonly ViewName ViewName = new ViewName("sys.server_event_sessions");
        
        public static readonly Column<SqlChar> EventRetentionMode = new Column<SqlChar>("event_retention_mode");
        
        public static readonly Column<SqlNVarchar> EventRetentionModeDesc = new Column<SqlNVarchar>("event_retention_mode_desc");
        
        public static readonly Column<SqlInt> EventSessionId = new Column<SqlInt>("event_session_id");
        
        public static readonly Column<SqlInt> MaxDispatchLatency = new Column<SqlInt>("max_dispatch_latency");
        
        public static readonly Column<SqlInt> MaxEventSize = new Column<SqlInt>("max_event_size");
        
        public static readonly Column<SqlInt> MaxMemory = new Column<SqlInt>("max_memory");
        
        public static readonly Column<SqlChar> MemoryPartitionMode = new Column<SqlChar>("memory_partition_mode");
        
        public static readonly Column<SqlNVarchar> MemoryPartitionModeDesc = new Column<SqlNVarchar>("memory_partition_mode_desc");
        
        public static readonly Column<SqlNVarchar> Name = new Column<SqlNVarchar>("name");
        
        public static readonly Column<SqlBit> StartupState = new Column<SqlBit>("startup_state");
        
        public static readonly Column<SqlBit> TrackCausality = new Column<SqlBit>("track_causality");
    }
}
