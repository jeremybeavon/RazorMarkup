using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Traces
    {
        public static readonly ViewName ViewName = new ViewName("sys.traces");
        
        public static readonly Column<SqlInt> BufferCount = new Column<SqlInt>("buffer_count");
        
        public static readonly Column<SqlInt> BufferSize = new Column<SqlInt>("buffer_size");
        
        public static readonly Column<SqlInt> DroppedEventCount = new Column<SqlInt>("dropped_event_count");
        
        public static readonly Column<SqlBigInt> EventCount = new Column<SqlBigInt>("event_count");
        
        public static readonly Column<SqlBigInt> FilePosition = new Column<SqlBigInt>("file_position");
        
        public static readonly Column<SqlInt> Id = new Column<SqlInt>("id");
        
        public static readonly Column<SqlBit> IsDefault = new Column<SqlBit>("is_default");
        
        public static readonly Column<SqlBit> IsRollover = new Column<SqlBit>("is_rollover");
        
        public static readonly Column<SqlBit> IsRowset = new Column<SqlBit>("is_rowset");
        
        public static readonly Column<SqlBit> IsShutdown = new Column<SqlBit>("is_shutdown");
        
        public static readonly Column<SqlDateTime> LastEventTime = new Column<SqlDateTime>("last_event_time");
        
        public static readonly Column<SqlInt> MaxFiles = new Column<SqlInt>("max_files");
        
        public static readonly Column<SqlBigInt> MaxSize = new Column<SqlBigInt>("max_size");
        
        public static readonly Column<SqlNVarchar> Path = new Column<SqlNVarchar>("path");
        
        public static readonly Column<SqlInt> ReaderSpid = new Column<SqlInt>("reader_spid");
        
        public static readonly Column<SqlDateTime> StartTime = new Column<SqlDateTime>("start_time");
        
        public static readonly Column<SqlInt> Status = new Column<SqlInt>("status");
        
        public static readonly Column<SqlDateTime> StopTime = new Column<SqlDateTime>("stop_time");
    }
}
