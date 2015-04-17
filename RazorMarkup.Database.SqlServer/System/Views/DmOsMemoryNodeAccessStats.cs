using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsMemoryNodeAccessStats
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_memory_node_access_stats");
        
        public static readonly Column<SqlInt> LocalNode = new Column<SqlInt>("local_node");
        
        public static readonly Column<SqlNVarchar> PageClass = new Column<SqlNVarchar>("page_class");
        
        public static readonly Column<SqlBigInt> ReadCount = new Column<SqlBigInt>("read_count");
        
        public static readonly Column<SqlInt> RemoteNode = new Column<SqlInt>("remote_node");
        
        public static readonly Column<SqlBigInt> WriteCount = new Column<SqlBigInt>("write_count");
    }
}
