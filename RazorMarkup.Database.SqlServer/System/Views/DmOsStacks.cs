using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsStacks
    {
        public static readonly ViewName ViewName = new("sys.dm_os_stacks");

        public static readonly Column<SqlVarbinary> FrameAddress = new("frame_address");

        public static readonly Column<SqlInt> FrameIndex = new("frame_index");

        public static readonly Column<SqlVarbinary> StackAddress = new("stack_address");
    }
}
