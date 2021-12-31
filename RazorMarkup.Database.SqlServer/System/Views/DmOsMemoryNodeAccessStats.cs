using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsMemoryNodeAccessStats
    {
        public static readonly ViewName ViewName = new("sys.dm_os_memory_node_access_stats");

        public static readonly Column<SqlInt> LocalNode = new("local_node");

        public static readonly Column<SqlNVarchar> PageClass = new("page_class");

        public static readonly Column<SqlBigInt> ReadCount = new("read_count");

        public static readonly Column<SqlInt> RemoteNode = new("remote_node");

        public static readonly Column<SqlBigInt> WriteCount = new("write_count");
    }
}
