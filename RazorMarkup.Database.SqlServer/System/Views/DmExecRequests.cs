using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmExecRequests
    {
        public static readonly ViewName ViewName = new("sys.dm_exec_requests");

        public static readonly Column<SqlBit> AnsiDefaults = new("ansi_defaults");

        public static readonly Column<SqlBit> AnsiNullDfltOn = new("ansi_null_dflt_on");

        public static readonly Column<SqlBit> AnsiNulls = new("ansi_nulls");

        public static readonly Column<SqlBit> AnsiPadding = new("ansi_padding");

        public static readonly Column<SqlBit> AnsiWarnings = new("ansi_warnings");

        public static readonly Column<SqlBit> Arithabort = new("arithabort");

        public static readonly Column<SqlSmallInt> BlockingSessionId = new("blocking_session_id");

        public static readonly Column<SqlNVarchar> Command = new("command");

        public static readonly Column<SqlBit> ConcatNullYieldsNull = new("concat_null_yields_null");

        public static readonly Column<SqlUniqueIdentifier> ConnectionId = new("connection_id");

        public static readonly Column<SqlVarbinary> ContextInfo = new("context_info");

        public static readonly Column<SqlInt> CpuTime = new("cpu_time");

        public static readonly Column<SqlSmallInt> DatabaseId = new("database_id");

        public static readonly Column<SqlSmallInt> DateFirst = new("date_first");

        public static readonly Column<SqlNVarchar> DateFormat = new("date_format");

        public static readonly Column<SqlInt> DeadlockPriority = new("deadlock_priority");

        public static readonly Column<SqlBigInt> EstimatedCompletionTime = new("estimated_completion_time");

        public static readonly Column<SqlBit> ExecutingManagedCode = new("executing_managed_code");

        public static readonly Column<SqlInt> GrantedQueryMemory = new("granted_query_memory");

        public static readonly Column<SqlInt> GroupId = new("group_id");

        public static readonly Column<SqlNVarchar> Language = new("language");

        public static readonly Column<SqlNVarchar> LastWaitType = new("last_wait_type");

        public static readonly Column<SqlInt> LockTimeout = new("lock_timeout");

        public static readonly Column<SqlBigInt> LogicalReads = new("logical_reads");

        public static readonly Column<SqlInt> NestLevel = new("nest_level");

        public static readonly Column<SqlInt> OpenResultsetCount = new("open_resultset_count");

        public static readonly Column<SqlInt> OpenTransactionCount = new("open_transaction_count");

        public static readonly Column<SqlReal> PercentComplete = new("percent_complete");

        public static readonly Column<SqlVarbinary> PlanHandle = new("plan_handle");

        public static readonly Column<SqlInt> PrevError = new("prev_error");

        public static readonly Column<SqlBinary> QueryHash = new("query_hash");

        public static readonly Column<SqlBinary> QueryPlanHash = new("query_plan_hash");

        public static readonly Column<SqlBit> QuotedIdentifier = new("quoted_identifier");

        public static readonly Column<SqlBigInt> Reads = new("reads");

        public static readonly Column<SqlInt> RequestId = new("request_id");

        public static readonly Column<SqlBigInt> RowCount = new("row_count");

        public static readonly Column<SqlInt> SchedulerId = new("scheduler_id");

        public static readonly Column<SqlSmallInt> SessionId = new("session_id");

        public static readonly Column<SqlVarbinary> SqlHandle = new("sql_handle");

        public static readonly Column<SqlDateTime> StartTime = new("start_time");

        public static readonly Column<SqlInt> StatementEndOffset = new("statement_end_offset");

        public static readonly Column<SqlInt> StatementStartOffset = new("statement_start_offset");

        public static readonly Column<SqlNVarchar> Status = new("status");

        public static readonly Column<SqlVarbinary> TaskAddress = new("task_address");

        public static readonly Column<SqlInt> TextSize = new("text_size");

        public static readonly Column<SqlInt> TotalElapsedTime = new("total_elapsed_time");

        public static readonly Column<SqlBigInt> TransactionId = new("transaction_id");

        public static readonly Column<SqlSmallInt> TransactionIsolationLevel = new("transaction_isolation_level");

        public static readonly Column<SqlInt> UserId = new("user_id");

        public static readonly Column<SqlNVarchar> WaitResource = new("wait_resource");

        public static readonly Column<SqlInt> WaitTime = new("wait_time");

        public static readonly Column<SqlNVarchar> WaitType = new("wait_type");

        public static readonly Column<SqlBigInt> Writes = new("writes");
    }
}
