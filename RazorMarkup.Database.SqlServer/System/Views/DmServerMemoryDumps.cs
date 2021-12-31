using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmServerMemoryDumps
    {
        public static readonly ViewName ViewName = new("sys.dm_server_memory_dumps");

        public static readonly Column<SqlDateTimeOffset> CreationTime = new("creation_time");

        public static readonly Column<SqlNVarchar> Filename = new("filename");

        public static readonly Column<SqlBigInt> SizeInBytes = new("size_in_bytes");
    }
}
