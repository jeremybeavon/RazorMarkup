using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmDbMissingIndexGroups
    {
        public static readonly ViewName ViewName = new("sys.dm_db_missing_index_groups");

        public static readonly Column<SqlInt> IndexGroupHandle = new("index_group_handle");

        public static readonly Column<SqlInt> IndexHandle = new("index_handle");
    }
}
