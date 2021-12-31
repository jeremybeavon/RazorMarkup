using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public abstract class DestinationDataSpaces
    {
        public static readonly ViewName ViewName = new("sys.destination_data_spaces");

        public static readonly Column<SqlInt> PartitionSchemeId = new("partition_scheme_id");

        public static readonly Column<SqlInt> DestinationId = new("destination_id");

        public static readonly Column<SqlInt> DataSpaceId = new("data_space_id");
    }
}
