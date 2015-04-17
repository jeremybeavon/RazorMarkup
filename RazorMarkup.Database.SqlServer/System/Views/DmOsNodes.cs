using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsNodes
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_nodes");
        
        public static readonly Column<SqlInt> ActiveWorkerCount = new Column<SqlInt>("active_worker_count");
        
        public static readonly Column<SqlInt> AvgLoadBalance = new Column<SqlInt>("avg_load_balance");
        
        public static readonly Column<SqlBigInt> CpuAffinityMask = new Column<SqlBigInt>("cpu_affinity_mask");
        
        public static readonly Column<SqlSmallInt> IdleSchedulerCount = new Column<SqlSmallInt>("idle_scheduler_count");
        
        public static readonly Column<SqlVarbinary> IoCompletionWorkerAddress = new Column<SqlVarbinary>("io_completion_worker_address");
        
        public static readonly Column<SqlVarbinary> MemoryClerkAddress = new Column<SqlVarbinary>("memory_clerk_address");
        
        public static readonly Column<SqlSmallInt> MemoryNodeId = new Column<SqlSmallInt>("memory_node_id");
        
        public static readonly Column<SqlVarbinary> MemoryObjectAddress = new Column<SqlVarbinary>("memory_object_address");
        
        public static readonly Column<SqlSmallInt> NodeId = new Column<SqlSmallInt>("node_id");
        
        public static readonly Column<SqlNVarchar> NodeStateDesc = new Column<SqlNVarchar>("node_state_desc");
        
        public static readonly Column<SqlSmallInt> OnlineSchedulerCount = new Column<SqlSmallInt>("online_scheduler_count");
        
        public static readonly Column<SqlBigInt> OnlineSchedulerMask = new Column<SqlBigInt>("online_scheduler_mask");
        
        public static readonly Column<SqlBigInt> PermanentTaskAffinityMask = new Column<SqlBigInt>("permanent_task_affinity_mask");
        
        public static readonly Column<SqlSmallInt> ProcessorGroup = new Column<SqlSmallInt>("processor_group");
        
        public static readonly Column<SqlBit> ResourceMonitorState = new Column<SqlBit>("resource_monitor_state");
        
        public static readonly Column<SqlBigInt> TimerTaskAffinityMask = new Column<SqlBigInt>("timer_task_affinity_mask");
    }
}
