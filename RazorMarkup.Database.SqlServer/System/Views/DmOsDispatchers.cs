using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsDispatchers
    {
        public static readonly ViewName ViewName = new("sys.dm_os_dispatchers");

        public static readonly Column<SqlBigInt> CurrentItemDuration = new("current_item_duration");

        public static readonly Column<SqlVarbinary> DispatcherPoolAddress = new("dispatcher_pool_address");

        public static readonly Column<SqlInt> FadeEndTime = new("fade_end_time");

        public static readonly Column<SqlBigInt> ItemsProcessed = new("items_processed");

        public static readonly Column<SqlNVarchar> State = new("state");

        public static readonly Column<SqlVarbinary> TaskAddress = new("task_address");

        public static readonly Column<SqlBigInt> WaitDuration = new("wait_duration");
    }
}
