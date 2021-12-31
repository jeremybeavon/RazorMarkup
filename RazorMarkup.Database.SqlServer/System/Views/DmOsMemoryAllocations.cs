using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsMemoryAllocations
    {
        public static readonly ViewName ViewName = new("sys.dm_os_memory_allocations");

        public static readonly Column<SqlVarbinary> AllocatorStackAddress = new("allocator_stack_address");

        public static readonly Column<SqlDateTime> CreationTime = new("creation_time");

        public static readonly Column<SqlInt> LineNum = new("line_num");

        public static readonly Column<SqlVarbinary> MemoryAllocationAddress = new("memory_allocation_address");

        public static readonly Column<SqlSmallInt> MemoryNodeId = new("memory_node_id");

        public static readonly Column<SqlVarbinary> MemoryObjectAddress = new("memory_object_address");

        public static readonly Column<SqlInt> SequenceNum = new("sequence_num");

        public static readonly Column<SqlBigInt> SizeInBytes = new("size_in_bytes");

        public static readonly Column<SqlVarchar> SourceFile = new("source_file");

        public static readonly Column<SqlInt> Tag = new("tag");
    }
}
