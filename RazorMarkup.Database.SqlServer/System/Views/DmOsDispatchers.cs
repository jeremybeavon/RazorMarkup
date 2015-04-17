using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsDispatchers
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_dispatchers");
        
        public static readonly Column<SqlBigInt> CurrentItemDuration = new Column<SqlBigInt>("current_item_duration");
        
        public static readonly Column<SqlVarbinary> DispatcherPoolAddress = new Column<SqlVarbinary>("dispatcher_pool_address");
        
        public static readonly Column<SqlInt> FadeEndTime = new Column<SqlInt>("fade_end_time");
        
        public static readonly Column<SqlBigInt> ItemsProcessed = new Column<SqlBigInt>("items_processed");
        
        public static readonly Column<SqlNVarchar> State = new Column<SqlNVarchar>("state");
        
        public static readonly Column<SqlVarbinary> TaskAddress = new Column<SqlVarbinary>("task_address");
        
        public static readonly Column<SqlBigInt> WaitDuration = new Column<SqlBigInt>("wait_duration");
    }
}
