using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmExecRequests
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_exec_requests");
        
        public static readonly Column<SqlBit> AnsiDefaults = new Column<SqlBit>("ansi_defaults");
        
        public static readonly Column<SqlBit> AnsiNullDfltOn = new Column<SqlBit>("ansi_null_dflt_on");
        
        public static readonly Column<SqlBit> AnsiNulls = new Column<SqlBit>("ansi_nulls");
        
        public static readonly Column<SqlBit> AnsiPadding = new Column<SqlBit>("ansi_padding");
        
        public static readonly Column<SqlBit> AnsiWarnings = new Column<SqlBit>("ansi_warnings");
        
        public static readonly Column<SqlBit> Arithabort = new Column<SqlBit>("arithabort");
        
        public static readonly Column<SqlSmallInt> BlockingSessionId = new Column<SqlSmallInt>("blocking_session_id");
        
        public static readonly Column<SqlNVarchar> Command = new Column<SqlNVarchar>("command");
        
        public static readonly Column<SqlBit> ConcatNullYieldsNull = new Column<SqlBit>("concat_null_yields_null");
        
        public static readonly Column<SqlUniqueIdentifier> ConnectionId = new Column<SqlUniqueIdentifier>("connection_id");
        
        public static readonly Column<SqlVarbinary> ContextInfo = new Column<SqlVarbinary>("context_info");
        
        public static readonly Column<SqlInt> CpuTime = new Column<SqlInt>("cpu_time");
        
        public static readonly Column<SqlSmallInt> DatabaseId = new Column<SqlSmallInt>("database_id");
        
        public static readonly Column<SqlSmallInt> DateFirst = new Column<SqlSmallInt>("date_first");
        
        public static readonly Column<SqlNVarchar> DateFormat = new Column<SqlNVarchar>("date_format");
        
        public static readonly Column<SqlInt> DeadlockPriority = new Column<SqlInt>("deadlock_priority");
        
        public static readonly Column<SqlBigInt> EstimatedCompletionTime = new Column<SqlBigInt>("estimated_completion_time");
        
        public static readonly Column<SqlBit> ExecutingManagedCode = new Column<SqlBit>("executing_managed_code");
        
        public static readonly Column<SqlInt> GrantedQueryMemory = new Column<SqlInt>("granted_query_memory");
        
        public static readonly Column<SqlInt> GroupId = new Column<SqlInt>("group_id");
        
        public static readonly Column<SqlNVarchar> Language = new Column<SqlNVarchar>("language");
        
        public static readonly Column<SqlNVarchar> LastWaitType = new Column<SqlNVarchar>("last_wait_type");
        
        public static readonly Column<SqlInt> LockTimeout = new Column<SqlInt>("lock_timeout");
        
        public static readonly Column<SqlBigInt> LogicalReads = new Column<SqlBigInt>("logical_reads");
        
        public static readonly Column<SqlInt> NestLevel = new Column<SqlInt>("nest_level");
        
        public static readonly Column<SqlInt> OpenResultsetCount = new Column<SqlInt>("open_resultset_count");
        
        public static readonly Column<SqlInt> OpenTransactionCount = new Column<SqlInt>("open_transaction_count");
        
        public static readonly Column<SqlReal> PercentComplete = new Column<SqlReal>("percent_complete");
        
        public static readonly Column<SqlVarbinary> PlanHandle = new Column<SqlVarbinary>("plan_handle");
        
        public static readonly Column<SqlInt> PrevError = new Column<SqlInt>("prev_error");
        
        public static readonly Column<SqlBinary> QueryHash = new Column<SqlBinary>("query_hash");
        
        public static readonly Column<SqlBinary> QueryPlanHash = new Column<SqlBinary>("query_plan_hash");
        
        public static readonly Column<SqlBit> QuotedIdentifier = new Column<SqlBit>("quoted_identifier");
        
        public static readonly Column<SqlBigInt> Reads = new Column<SqlBigInt>("reads");
        
        public static readonly Column<SqlInt> RequestId = new Column<SqlInt>("request_id");
        
        public static readonly Column<SqlBigInt> RowCount = new Column<SqlBigInt>("row_count");
        
        public static readonly Column<SqlInt> SchedulerId = new Column<SqlInt>("scheduler_id");
        
        public static readonly Column<SqlSmallInt> SessionId = new Column<SqlSmallInt>("session_id");
        
        public static readonly Column<SqlVarbinary> SqlHandle = new Column<SqlVarbinary>("sql_handle");
        
        public static readonly Column<SqlDateTime> StartTime = new Column<SqlDateTime>("start_time");
        
        public static readonly Column<SqlInt> StatementEndOffset = new Column<SqlInt>("statement_end_offset");
        
        public static readonly Column<SqlInt> StatementStartOffset = new Column<SqlInt>("statement_start_offset");
        
        public static readonly Column<SqlNVarchar> Status = new Column<SqlNVarchar>("status");
        
        public static readonly Column<SqlVarbinary> TaskAddress = new Column<SqlVarbinary>("task_address");
        
        public static readonly Column<SqlInt> TextSize = new Column<SqlInt>("text_size");
        
        public static readonly Column<SqlInt> TotalElapsedTime = new Column<SqlInt>("total_elapsed_time");
        
        public static readonly Column<SqlBigInt> TransactionId = new Column<SqlBigInt>("transaction_id");
        
        public static readonly Column<SqlSmallInt> TransactionIsolationLevel = new Column<SqlSmallInt>("transaction_isolation_level");
        
        public static readonly Column<SqlInt> UserId = new Column<SqlInt>("user_id");
        
        public static readonly Column<SqlNVarchar> WaitResource = new Column<SqlNVarchar>("wait_resource");
        
        public static readonly Column<SqlInt> WaitTime = new Column<SqlInt>("wait_time");
        
        public static readonly Column<SqlNVarchar> WaitType = new Column<SqlNVarchar>("wait_type");
        
        public static readonly Column<SqlBigInt> Writes = new Column<SqlBigInt>("writes");
    }
}
