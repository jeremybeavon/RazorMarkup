using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmTranTopVersionGenerators
    {
        public static readonly ViewName ViewName = new("sys.dm_tran_top_version_generators");

        public static readonly Column<SqlInt> AggregatedRecordLengthInBytes = new("aggregated_record_length_in_bytes");

        public static readonly Column<SqlSmallInt> DatabaseId = new("database_id");

        public static readonly Column<SqlBigInt> RowsetId = new("rowset_id");
    }
}
