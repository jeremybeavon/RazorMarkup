using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmExecTriggerStats
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_exec_trigger_stats");
        
        public static readonly Column<SqlDateTime> CachedTime = new Column<SqlDateTime>("cached_time");
        
        public static readonly Column<SqlInt> DatabaseId = new Column<SqlInt>("database_id");
        
        public static readonly Column<SqlBigInt> ExecutionCount = new Column<SqlBigInt>("execution_count");
        
        public static readonly Column<SqlBigInt> LastElapsedTime = new Column<SqlBigInt>("last_elapsed_time");
        
        public static readonly Column<SqlDateTime> LastExecutionTime = new Column<SqlDateTime>("last_execution_time");
        
        public static readonly Column<SqlBigInt> LastLogicalReads = new Column<SqlBigInt>("last_logical_reads");
        
        public static readonly Column<SqlBigInt> LastLogicalWrites = new Column<SqlBigInt>("last_logical_writes");
        
        public static readonly Column<SqlBigInt> LastPhysicalReads = new Column<SqlBigInt>("last_physical_reads");
        
        public static readonly Column<SqlBigInt> LastWorkerTime = new Column<SqlBigInt>("last_worker_time");
        
        public static readonly Column<SqlBigInt> MaxElapsedTime = new Column<SqlBigInt>("max_elapsed_time");
        
        public static readonly Column<SqlBigInt> MaxLogicalReads = new Column<SqlBigInt>("max_logical_reads");
        
        public static readonly Column<SqlBigInt> MaxLogicalWrites = new Column<SqlBigInt>("max_logical_writes");
        
        public static readonly Column<SqlBigInt> MaxPhysicalReads = new Column<SqlBigInt>("max_physical_reads");
        
        public static readonly Column<SqlBigInt> MaxWorkerTime = new Column<SqlBigInt>("max_worker_time");
        
        public static readonly Column<SqlBigInt> MinElapsedTime = new Column<SqlBigInt>("min_elapsed_time");
        
        public static readonly Column<SqlBigInt> MinLogicalReads = new Column<SqlBigInt>("min_logical_reads");
        
        public static readonly Column<SqlBigInt> MinLogicalWrites = new Column<SqlBigInt>("min_logical_writes");
        
        public static readonly Column<SqlBigInt> MinPhysicalReads = new Column<SqlBigInt>("min_physical_reads");
        
        public static readonly Column<SqlBigInt> MinWorkerTime = new Column<SqlBigInt>("min_worker_time");
        
        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");
        
        public static readonly Column<SqlVarbinary> PlanHandle = new Column<SqlVarbinary>("plan_handle");
        
        public static readonly Column<SqlVarbinary> SqlHandle = new Column<SqlVarbinary>("sql_handle");
        
        public static readonly Column<SqlBigInt> TotalElapsedTime = new Column<SqlBigInt>("total_elapsed_time");
        
        public static readonly Column<SqlBigInt> TotalLogicalReads = new Column<SqlBigInt>("total_logical_reads");
        
        public static readonly Column<SqlBigInt> TotalLogicalWrites = new Column<SqlBigInt>("total_logical_writes");
        
        public static readonly Column<SqlBigInt> TotalPhysicalReads = new Column<SqlBigInt>("total_physical_reads");
        
        public static readonly Column<SqlBigInt> TotalWorkerTime = new Column<SqlBigInt>("total_worker_time");
        
        public static readonly Column<SqlChar> Type = new Column<SqlChar>("type");
        
        public static readonly Column<SqlNVarchar> TypeDesc = new Column<SqlNVarchar>("type_desc");
    }
}
