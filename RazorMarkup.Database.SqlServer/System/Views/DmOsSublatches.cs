using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsSublatches
    {
        public static readonly ViewName ViewName = new("sys.dm_os_sublatches");

        public static readonly Column<SqlInt> PartitionId = new("partition_id");

        public static readonly Column<SqlVarbinary> SublatchAddress = new("sublatch_address");

        public static readonly Column<SqlVarbinary> SuperlatchAddress = new("superlatch_address");
    }
}
