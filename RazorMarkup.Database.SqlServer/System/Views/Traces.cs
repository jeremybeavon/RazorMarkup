using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Traces
    {
        public static readonly ViewName ViewName = new("sys.traces");

        public static readonly Column<SqlInt> BufferCount = new("buffer_count");

        public static readonly Column<SqlInt> BufferSize = new("buffer_size");

        public static readonly Column<SqlInt> DroppedEventCount = new("dropped_event_count");

        public static readonly Column<SqlBigInt> EventCount = new("event_count");

        public static readonly Column<SqlBigInt> FilePosition = new("file_position");

        public static readonly Column<SqlInt> Id = new("id");

        public static readonly Column<SqlBit> IsDefault = new("is_default");

        public static readonly Column<SqlBit> IsRollover = new("is_rollover");

        public static readonly Column<SqlBit> IsRowset = new("is_rowset");

        public static readonly Column<SqlBit> IsShutdown = new("is_shutdown");

        public static readonly Column<SqlDateTime> LastEventTime = new("last_event_time");

        public static readonly Column<SqlInt> MaxFiles = new("max_files");

        public static readonly Column<SqlBigInt> MaxSize = new("max_size");

        public static readonly Column<SqlNVarchar> Path = new("path");

        public static readonly Column<SqlInt> ReaderSpid = new("reader_spid");

        public static readonly Column<SqlDateTime> StartTime = new("start_time");

        public static readonly Column<SqlInt> Status = new("status");

        public static readonly Column<SqlDateTime> StopTime = new("stop_time");
    }
}
