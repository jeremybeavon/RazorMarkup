using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsSublatches
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_sublatches");
        
        public static readonly Column<SqlInt> PartitionId = new Column<SqlInt>("partition_id");
        
        public static readonly Column<SqlVarbinary> SublatchAddress = new Column<SqlVarbinary>("sublatch_address");
        
        public static readonly Column<SqlVarbinary> SuperlatchAddress = new Column<SqlVarbinary>("superlatch_address");
    }
}
