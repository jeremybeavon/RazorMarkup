using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public abstract class DestinationDataSpaces
    {
        public static readonly ViewName ViewName = new ViewName("sys.destination_data_spaces");

        public static readonly Column<SqlInt> PartitionSchemeId = new Column<SqlInt>("partition_scheme_id");

        public static readonly Column<SqlInt> DestinationId = new Column<SqlInt>("destination_id");

        public static readonly Column<SqlInt> DataSpaceId = new Column<SqlInt>("data_space_id");
    }
}
