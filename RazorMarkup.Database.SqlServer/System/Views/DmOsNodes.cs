using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsNodes
    {
        public static readonly ViewName ViewName = new("sys.dm_os_nodes");

        public static readonly Column<SqlInt> ActiveWorkerCount = new("active_worker_count");

        public static readonly Column<SqlInt> AvgLoadBalance = new("avg_load_balance");

        public static readonly Column<SqlBigInt> CpuAffinityMask = new("cpu_affinity_mask");

        public static readonly Column<SqlSmallInt> IdleSchedulerCount = new("idle_scheduler_count");

        public static readonly Column<SqlVarbinary> IoCompletionWorkerAddress = new("io_completion_worker_address");

        public static readonly Column<SqlVarbinary> MemoryClerkAddress = new("memory_clerk_address");

        public static readonly Column<SqlSmallInt> MemoryNodeId = new("memory_node_id");

        public static readonly Column<SqlVarbinary> MemoryObjectAddress = new("memory_object_address");

        public static readonly Column<SqlSmallInt> NodeId = new("node_id");

        public static readonly Column<SqlNVarchar> NodeStateDesc = new("node_state_desc");

        public static readonly Column<SqlSmallInt> OnlineSchedulerCount = new("online_scheduler_count");

        public static readonly Column<SqlBigInt> OnlineSchedulerMask = new("online_scheduler_mask");

        public static readonly Column<SqlBigInt> PermanentTaskAffinityMask = new("permanent_task_affinity_mask");

        public static readonly Column<SqlSmallInt> ProcessorGroup = new("processor_group");

        public static readonly Column<SqlBit> ResourceMonitorState = new("resource_monitor_state");

        public static readonly Column<SqlBigInt> TimerTaskAffinityMask = new("timer_task_affinity_mask");
    }
}
