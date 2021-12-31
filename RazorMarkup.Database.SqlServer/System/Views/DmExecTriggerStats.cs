using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmExecTriggerStats
    {
        public static readonly ViewName ViewName = new("sys.dm_exec_trigger_stats");

        public static readonly Column<SqlDateTime> CachedTime = new("cached_time");

        public static readonly Column<SqlInt> DatabaseId = new("database_id");

        public static readonly Column<SqlBigInt> ExecutionCount = new("execution_count");

        public static readonly Column<SqlBigInt> LastElapsedTime = new("last_elapsed_time");

        public static readonly Column<SqlDateTime> LastExecutionTime = new("last_execution_time");

        public static readonly Column<SqlBigInt> LastLogicalReads = new("last_logical_reads");

        public static readonly Column<SqlBigInt> LastLogicalWrites = new("last_logical_writes");

        public static readonly Column<SqlBigInt> LastPhysicalReads = new("last_physical_reads");

        public static readonly Column<SqlBigInt> LastWorkerTime = new("last_worker_time");

        public static readonly Column<SqlBigInt> MaxElapsedTime = new("max_elapsed_time");

        public static readonly Column<SqlBigInt> MaxLogicalReads = new("max_logical_reads");

        public static readonly Column<SqlBigInt> MaxLogicalWrites = new("max_logical_writes");

        public static readonly Column<SqlBigInt> MaxPhysicalReads = new("max_physical_reads");

        public static readonly Column<SqlBigInt> MaxWorkerTime = new("max_worker_time");

        public static readonly Column<SqlBigInt> MinElapsedTime = new("min_elapsed_time");

        public static readonly Column<SqlBigInt> MinLogicalReads = new("min_logical_reads");

        public static readonly Column<SqlBigInt> MinLogicalWrites = new("min_logical_writes");

        public static readonly Column<SqlBigInt> MinPhysicalReads = new("min_physical_reads");

        public static readonly Column<SqlBigInt> MinWorkerTime = new("min_worker_time");

        public static readonly Column<SqlInt> ObjectId = new("object_id");

        public static readonly Column<SqlVarbinary> PlanHandle = new("plan_handle");

        public static readonly Column<SqlVarbinary> SqlHandle = new("sql_handle");

        public static readonly Column<SqlBigInt> TotalElapsedTime = new("total_elapsed_time");

        public static readonly Column<SqlBigInt> TotalLogicalReads = new("total_logical_reads");

        public static readonly Column<SqlBigInt> TotalLogicalWrites = new("total_logical_writes");

        public static readonly Column<SqlBigInt> TotalPhysicalReads = new("total_physical_reads");

        public static readonly Column<SqlBigInt> TotalWorkerTime = new("total_worker_time");

        public static readonly Column<SqlChar> Type = new("type");

        public static readonly Column<SqlNVarchar> TypeDesc = new("type_desc");
    }
}
