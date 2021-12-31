using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Partitions
    {
        public static readonly ViewName ViewName = new("sys.partitions");

        public static readonly Column<SqlTinyInt> DataCompression = new("data_compression");

        public static readonly Column<SqlNVarchar> DataCompressionDesc = new("data_compression_desc");

        public static readonly Column<SqlSmallInt> FilestreamFilegroupId = new("filestream_filegroup_id");

        public static readonly Column<SqlBigInt> HobtId = new("hobt_id");

        public static readonly Column<SqlInt> IndexId = new("index_id");

        public static readonly Column<SqlInt> ObjectId = new("object_id");

        public static readonly Column<SqlBigInt> PartitionId = new("partition_id");

        public static readonly Column<SqlInt> PartitionNumber = new("partition_number");

        public static readonly Column<SqlBigInt> Rows = new("rows");
    }
}
