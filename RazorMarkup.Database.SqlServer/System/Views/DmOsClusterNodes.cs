using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsClusterNodes
    {
        public static readonly ViewName ViewName = new("sys.dm_os_cluster_nodes");

        public static readonly Column<SqlBit> IsCurrentOwner = new("is_current_owner");

        public static readonly Column<SqlNVarchar> Nodename = new("NodeName");

        public static readonly Column<SqlInt> Status = new("status");

        public static readonly Column<SqlVarchar> StatusDescription = new("status_description");
    }
}
