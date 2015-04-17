using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmExecQueryStats
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_exec_query_stats");
        
        public static readonly Column<SqlDateTime> CreationTime = new Column<SqlDateTime>("creation_time");
        
        public static readonly Column<SqlBigInt> ExecutionCount = new Column<SqlBigInt>("execution_count");
        
        public static readonly Column<SqlBigInt> LastClrTime = new Column<SqlBigInt>("last_clr_time");
        
        public static readonly Column<SqlBigInt> LastElapsedTime = new Column<SqlBigInt>("last_elapsed_time");
        
        public static readonly Column<SqlDateTime> LastExecutionTime = new Column<SqlDateTime>("last_execution_time");
        
        public static readonly Column<SqlBigInt> LastLogicalReads = new Column<SqlBigInt>("last_logical_reads");
        
        public static readonly Column<SqlBigInt> LastLogicalWrites = new Column<SqlBigInt>("last_logical_writes");
        
        public static readonly Column<SqlBigInt> LastPhysicalReads = new Column<SqlBigInt>("last_physical_reads");
        
        public static readonly Column<SqlBigInt> LastRows = new Column<SqlBigInt>("last_rows");
        
        public static readonly Column<SqlBigInt> LastWorkerTime = new Column<SqlBigInt>("last_worker_time");
        
        public static readonly Column<SqlBigInt> MaxClrTime = new Column<SqlBigInt>("max_clr_time");
        
        public static readonly Column<SqlBigInt> MaxElapsedTime = new Column<SqlBigInt>("max_elapsed_time");
        
        public static readonly Column<SqlBigInt> MaxLogicalReads = new Column<SqlBigInt>("max_logical_reads");
        
        public static readonly Column<SqlBigInt> MaxLogicalWrites = new Column<SqlBigInt>("max_logical_writes");
        
        public static readonly Column<SqlBigInt> MaxPhysicalReads = new Column<SqlBigInt>("max_physical_reads");
        
        public static readonly Column<SqlBigInt> MaxRows = new Column<SqlBigInt>("max_rows");
        
        public static readonly Column<SqlBigInt> MaxWorkerTime = new Column<SqlBigInt>("max_worker_time");
        
        public static readonly Column<SqlBigInt> MinClrTime = new Column<SqlBigInt>("min_clr_time");
        
        public static readonly Column<SqlBigInt> MinElapsedTime = new Column<SqlBigInt>("min_elapsed_time");
        
        public static readonly Column<SqlBigInt> MinLogicalReads = new Column<SqlBigInt>("min_logical_reads");
        
        public static readonly Column<SqlBigInt> MinLogicalWrites = new Column<SqlBigInt>("min_logical_writes");
        
        public static readonly Column<SqlBigInt> MinPhysicalReads = new Column<SqlBigInt>("min_physical_reads");
        
        public static readonly Column<SqlBigInt> MinRows = new Column<SqlBigInt>("min_rows");
        
        public static readonly Column<SqlBigInt> MinWorkerTime = new Column<SqlBigInt>("min_worker_time");
        
        public static readonly Column<SqlBigInt> PlanGenerationNum = new Column<SqlBigInt>("plan_generation_num");
        
        public static readonly Column<SqlVarbinary> PlanHandle = new Column<SqlVarbinary>("plan_handle");
        
        public static readonly Column<SqlBinary> QueryHash = new Column<SqlBinary>("query_hash");
        
        public static readonly Column<SqlBinary> QueryPlanHash = new Column<SqlBinary>("query_plan_hash");
        
        public static readonly Column<SqlVarbinary> SqlHandle = new Column<SqlVarbinary>("sql_handle");
        
        public static readonly Column<SqlInt> StatementEndOffset = new Column<SqlInt>("statement_end_offset");
        
        public static readonly Column<SqlInt> StatementStartOffset = new Column<SqlInt>("statement_start_offset");
        
        public static readonly Column<SqlBigInt> TotalClrTime = new Column<SqlBigInt>("total_clr_time");
        
        public static readonly Column<SqlBigInt> TotalElapsedTime = new Column<SqlBigInt>("total_elapsed_time");
        
        public static readonly Column<SqlBigInt> TotalLogicalReads = new Column<SqlBigInt>("total_logical_reads");
        
        public static readonly Column<SqlBigInt> TotalLogicalWrites = new Column<SqlBigInt>("total_logical_writes");
        
        public static readonly Column<SqlBigInt> TotalPhysicalReads = new Column<SqlBigInt>("total_physical_reads");
        
        public static readonly Column<SqlBigInt> TotalRows = new Column<SqlBigInt>("total_rows");
        
        public static readonly Column<SqlBigInt> TotalWorkerTime = new Column<SqlBigInt>("total_worker_time");
    }
}
