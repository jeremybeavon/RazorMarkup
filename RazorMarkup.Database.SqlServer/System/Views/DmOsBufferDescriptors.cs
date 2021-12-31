using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsBufferDescriptors
    {
        public static readonly ViewName ViewName = new("sys.dm_os_buffer_descriptors");

        public static readonly Column<SqlBigInt> AllocationUnitId = new("allocation_unit_id");

        public static readonly Column<SqlInt> DatabaseId = new("database_id");

        public static readonly Column<SqlInt> FileId = new("file_id");

        public static readonly Column<SqlInt> FreeSpaceInBytes = new("free_space_in_bytes");

        public static readonly Column<SqlBit> IsModified = new("is_modified");

        public static readonly Column<SqlInt> NumaNode = new("numa_node");

        public static readonly Column<SqlInt> PageId = new("page_id");

        public static readonly Column<SqlInt> PageLevel = new("page_level");

        public static readonly Column<SqlNVarchar> PageType = new("page_type");

        public static readonly Column<SqlBigInt> ReadMicrosec = new("read_microsec");

        public static readonly Column<SqlInt> RowCount = new("row_count");
    }
}
