using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Partitions
    {
        public static readonly ViewName ViewName = new ViewName("sys.partitions");
        
        public static readonly Column<SqlTinyInt> DataCompression = new Column<SqlTinyInt>("data_compression");
        
        public static readonly Column<SqlNVarchar> DataCompressionDesc = new Column<SqlNVarchar>("data_compression_desc");
        
        public static readonly Column<SqlSmallInt> FilestreamFilegroupId = new Column<SqlSmallInt>("filestream_filegroup_id");
        
        public static readonly Column<SqlBigInt> HobtId = new Column<SqlBigInt>("hobt_id");
        
        public static readonly Column<SqlInt> IndexId = new Column<SqlInt>("index_id");
        
        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");
        
        public static readonly Column<SqlBigInt> PartitionId = new Column<SqlBigInt>("partition_id");
        
        public static readonly Column<SqlInt> PartitionNumber = new Column<SqlInt>("partition_number");
        
        public static readonly Column<SqlBigInt> Rows = new Column<SqlBigInt>("rows");
    }
}
