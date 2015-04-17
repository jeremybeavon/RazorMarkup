using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsMemoryObjects
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_memory_objects");
        
        public static readonly Column<SqlBigInt> BytesUsed = new Column<SqlBigInt>("bytes_used");
        
        public static readonly Column<SqlInt> CreationOptions = new Column<SqlInt>("creation_options");
        
        public static readonly Column<SqlVarbinary> CreationStackAddress = new Column<SqlVarbinary>("creation_stack_address");
        
        public static readonly Column<SqlDateTime> CreationTime = new Column<SqlDateTime>("creation_time");
        
        public static readonly Column<SqlBigInt> MaxPagesInBytes = new Column<SqlBigInt>("max_pages_in_bytes");
        
        public static readonly Column<SqlSmallInt> MemoryNodeId = new Column<SqlSmallInt>("memory_node_id");
        
        public static readonly Column<SqlVarbinary> MemoryObjectAddress = new Column<SqlVarbinary>("memory_object_address");
        
        public static readonly Column<SqlVarchar> Name = new Column<SqlVarchar>("name");
        
        public static readonly Column<SqlVarbinary> PageAllocatorAddress = new Column<SqlVarbinary>("page_allocator_address");
        
        public static readonly Column<SqlInt> PageSizeInBytes = new Column<SqlInt>("page_size_in_bytes");
        
        public static readonly Column<SqlBigInt> PagesInBytes = new Column<SqlBigInt>("pages_in_bytes");
        
        public static readonly Column<SqlVarbinary> ParentAddress = new Column<SqlVarbinary>("parent_address");
        
        public static readonly Column<SqlInt> SequenceNum = new Column<SqlInt>("sequence_num");
        
        public static readonly Column<SqlNVarchar> Type = new Column<SqlNVarchar>("type");
    }
}
