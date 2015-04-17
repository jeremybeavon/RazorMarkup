using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsClusterNodes
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_cluster_nodes");
        
        public static readonly Column<SqlBit> IsCurrentOwner = new Column<SqlBit>("is_current_owner");
        
        public static readonly Column<SqlNVarchar> Nodename = new Column<SqlNVarchar>("NodeName");
        
        public static readonly Column<SqlInt> Status = new Column<SqlInt>("status");
        
        public static readonly Column<SqlVarchar> StatusDescription = new Column<SqlVarchar>("status_description");
    }
}
