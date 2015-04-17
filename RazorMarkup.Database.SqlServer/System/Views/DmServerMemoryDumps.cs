using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmServerMemoryDumps
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_server_memory_dumps");
        
        public static readonly Column<SqlDateTimeOffset> CreationTime = new Column<SqlDateTimeOffset>("creation_time");
        
        public static readonly Column<SqlNVarchar> Filename = new Column<SqlNVarchar>("filename");
        
        public static readonly Column<SqlBigInt> SizeInBytes = new Column<SqlBigInt>("size_in_bytes");
    }
}
