using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsStacks
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_stacks");
        
        public static readonly Column<SqlVarbinary> FrameAddress = new Column<SqlVarbinary>("frame_address");
        
        public static readonly Column<SqlInt> FrameIndex = new Column<SqlInt>("frame_index");
        
        public static readonly Column<SqlVarbinary> StackAddress = new Column<SqlVarbinary>("stack_address");
    }
}
