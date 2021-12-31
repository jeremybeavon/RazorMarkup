using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsMemoryObjects
    {
        public static readonly ViewName ViewName = new("sys.dm_os_memory_objects");

        public static readonly Column<SqlBigInt> BytesUsed = new("bytes_used");

        public static readonly Column<SqlInt> CreationOptions = new("creation_options");

        public static readonly Column<SqlVarbinary> CreationStackAddress = new("creation_stack_address");

        public static readonly Column<SqlDateTime> CreationTime = new("creation_time");

        public static readonly Column<SqlBigInt> MaxPagesInBytes = new("max_pages_in_bytes");

        public static readonly Column<SqlSmallInt> MemoryNodeId = new("memory_node_id");

        public static readonly Column<SqlVarbinary> MemoryObjectAddress = new("memory_object_address");

        public static readonly Column<SqlVarchar> Name = new("name");

        public static readonly Column<SqlVarbinary> PageAllocatorAddress = new("page_allocator_address");

        public static readonly Column<SqlInt> PageSizeInBytes = new("page_size_in_bytes");

        public static readonly Column<SqlBigInt> PagesInBytes = new("pages_in_bytes");

        public static readonly Column<SqlVarbinary> ParentAddress = new("parent_address");

        public static readonly Column<SqlInt> SequenceNum = new("sequence_num");

        public static readonly Column<SqlNVarchar> Type = new("type");
    }
}
