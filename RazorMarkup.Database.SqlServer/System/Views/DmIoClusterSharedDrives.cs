using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmIoClusterSharedDrives
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_io_cluster_shared_drives");
        
        public static readonly Column<SqlNChar> Drivename = new Column<SqlNChar>("DriveName");
    }
}
