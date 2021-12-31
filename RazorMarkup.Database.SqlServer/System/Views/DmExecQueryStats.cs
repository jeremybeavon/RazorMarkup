using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmExecQueryStats
    {
        public static readonly ViewName ViewName = new("sys.dm_exec_query_stats");

        public static readonly Column<SqlDateTime> CreationTime = new("creation_time");

        public static readonly Column<SqlBigInt> ExecutionCount = new("execution_count");

        public static readonly Column<SqlBigInt> LastClrTime = new("last_clr_time");

        public static readonly Column<SqlBigInt> LastElapsedTime = new("last_elapsed_time");

        public static readonly Column<SqlDateTime> LastExecutionTime = new("last_execution_time");

        public static readonly Column<SqlBigInt> LastLogicalReads = new("last_logical_reads");

        public static readonly Column<SqlBigInt> LastLogicalWrites = new("last_logical_writes");

        public static readonly Column<SqlBigInt> LastPhysicalReads = new("last_physical_reads");

        public static readonly Column<SqlBigInt> LastRows = new("last_rows");

        public static readonly Column<SqlBigInt> LastWorkerTime = new("last_worker_time");

        public static readonly Column<SqlBigInt> MaxClrTime = new("max_clr_time");

        public static readonly Column<SqlBigInt> MaxElapsedTime = new("max_elapsed_time");

        public static readonly Column<SqlBigInt> MaxLogicalReads = new("max_logical_reads");

        public static readonly Column<SqlBigInt> MaxLogicalWrites = new("max_logical_writes");

        public static readonly Column<SqlBigInt> MaxPhysicalReads = new("max_physical_reads");

        public static readonly Column<SqlBigInt> MaxRows = new("max_rows");

        public static readonly Column<SqlBigInt> MaxWorkerTime = new("max_worker_time");

        public static readonly Column<SqlBigInt> MinClrTime = new("min_clr_time");

        public static readonly Column<SqlBigInt> MinElapsedTime = new("min_elapsed_time");

        public static readonly Column<SqlBigInt> MinLogicalReads = new("min_logical_reads");

        public static readonly Column<SqlBigInt> MinLogicalWrites = new("min_logical_writes");

        public static readonly Column<SqlBigInt> MinPhysicalReads = new("min_physical_reads");

        public static readonly Column<SqlBigInt> MinRows = new("min_rows");

        public static readonly Column<SqlBigInt> MinWorkerTime = new("min_worker_time");

        public static readonly Column<SqlBigInt> PlanGenerationNum = new("plan_generation_num");

        public static readonly Column<SqlVarbinary> PlanHandle = new("plan_handle");

        public static readonly Column<SqlBinary> QueryHash = new("query_hash");

        public static readonly Column<SqlBinary> QueryPlanHash = new("query_plan_hash");

        public static readonly Column<SqlVarbinary> SqlHandle = new("sql_handle");

        public static readonly Column<SqlInt> StatementEndOffset = new("statement_end_offset");

        public static readonly Column<SqlInt> StatementStartOffset = new("statement_start_offset");

        public static readonly Column<SqlBigInt> TotalClrTime = new("total_clr_time");

        public static readonly Column<SqlBigInt> TotalElapsedTime = new("total_elapsed_time");

        public static readonly Column<SqlBigInt> TotalLogicalReads = new("total_logical_reads");

        public static readonly Column<SqlBigInt> TotalLogicalWrites = new("total_logical_writes");

        public static readonly Column<SqlBigInt> TotalPhysicalReads = new("total_physical_reads");

        public static readonly Column<SqlBigInt> TotalRows = new("total_rows");

        public static readonly Column<SqlBigInt> TotalWorkerTime = new("total_worker_time");
    }
}
