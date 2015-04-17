using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsMemoryAllocations
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_memory_allocations");
        
        public static readonly Column<SqlVarbinary> AllocatorStackAddress = new Column<SqlVarbinary>("allocator_stack_address");
        
        public static readonly Column<SqlDateTime> CreationTime = new Column<SqlDateTime>("creation_time");
        
        public static readonly Column<SqlInt> LineNum = new Column<SqlInt>("line_num");
        
        public static readonly Column<SqlVarbinary> MemoryAllocationAddress = new Column<SqlVarbinary>("memory_allocation_address");
        
        public static readonly Column<SqlSmallInt> MemoryNodeId = new Column<SqlSmallInt>("memory_node_id");
        
        public static readonly Column<SqlVarbinary> MemoryObjectAddress = new Column<SqlVarbinary>("memory_object_address");
        
        public static readonly Column<SqlInt> SequenceNum = new Column<SqlInt>("sequence_num");
        
        public static readonly Column<SqlBigInt> SizeInBytes = new Column<SqlBigInt>("size_in_bytes");
        
        public static readonly Column<SqlVarchar> SourceFile = new Column<SqlVarchar>("source_file");
        
        public static readonly Column<SqlInt> Tag = new Column<SqlInt>("tag");
    }
}
