using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsBufferDescriptors
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_buffer_descriptors");
        
        public static readonly Column<SqlBigInt> AllocationUnitId = new Column<SqlBigInt>("allocation_unit_id");
        
        public static readonly Column<SqlInt> DatabaseId = new Column<SqlInt>("database_id");
        
        public static readonly Column<SqlInt> FileId = new Column<SqlInt>("file_id");
        
        public static readonly Column<SqlInt> FreeSpaceInBytes = new Column<SqlInt>("free_space_in_bytes");
        
        public static readonly Column<SqlBit> IsModified = new Column<SqlBit>("is_modified");
        
        public static readonly Column<SqlInt> NumaNode = new Column<SqlInt>("numa_node");
        
        public static readonly Column<SqlInt> PageId = new Column<SqlInt>("page_id");
        
        public static readonly Column<SqlInt> PageLevel = new Column<SqlInt>("page_level");
        
        public static readonly Column<SqlNVarchar> PageType = new Column<SqlNVarchar>("page_type");
        
        public static readonly Column<SqlBigInt> ReadMicrosec = new Column<SqlBigInt>("read_microsec");
        
        public static readonly Column<SqlInt> RowCount = new Column<SqlInt>("row_count");
    }
}
