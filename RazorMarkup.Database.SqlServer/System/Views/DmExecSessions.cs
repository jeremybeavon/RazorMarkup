using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmExecSessions
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_exec_sessions");
        
        public static readonly Column<SqlBit> AnsiDefaults = new Column<SqlBit>("ansi_defaults");
        
        public static readonly Column<SqlBit> AnsiNullDfltOn = new Column<SqlBit>("ansi_null_dflt_on");
        
        public static readonly Column<SqlBit> AnsiNulls = new Column<SqlBit>("ansi_nulls");
        
        public static readonly Column<SqlBit> AnsiPadding = new Column<SqlBit>("ansi_padding");
        
        public static readonly Column<SqlBit> AnsiWarnings = new Column<SqlBit>("ansi_warnings");
        
        public static readonly Column<SqlBit> Arithabort = new Column<SqlBit>("arithabort");
        
        public static readonly Column<SqlInt> AuthenticatingDatabaseId = new Column<SqlInt>("authenticating_database_id");
        
        public static readonly Column<SqlNVarchar> ClientInterfaceName = new Column<SqlNVarchar>("client_interface_name");
        
        public static readonly Column<SqlInt> ClientVersion = new Column<SqlInt>("client_version");
        
        public static readonly Column<SqlBit> ConcatNullYieldsNull = new Column<SqlBit>("concat_null_yields_null");
        
        public static readonly Column<SqlVarbinary> ContextInfo = new Column<SqlVarbinary>("context_info");
        
        public static readonly Column<SqlInt> CpuTime = new Column<SqlInt>("cpu_time");
        
        public static readonly Column<SqlSmallInt> DatabaseId = new Column<SqlSmallInt>("database_id");
        
        public static readonly Column<SqlSmallInt> DateFirst = new Column<SqlSmallInt>("date_first");
        
        public static readonly Column<SqlNVarchar> DateFormat = new Column<SqlNVarchar>("date_format");
        
        public static readonly Column<SqlInt> DeadlockPriority = new Column<SqlInt>("deadlock_priority");
        
        public static readonly Column<SqlInt> EndpointId = new Column<SqlInt>("endpoint_id");
        
        public static readonly Column<SqlInt> GroupId = new Column<SqlInt>("group_id");
        
        public static readonly Column<SqlNVarchar> HostName = new Column<SqlNVarchar>("host_name");
        
        public static readonly Column<SqlInt> HostProcessId = new Column<SqlInt>("host_process_id");
        
        public static readonly Column<SqlBit> IsUserProcess = new Column<SqlBit>("is_user_process");
        
        public static readonly Column<SqlNVarchar> Language = new Column<SqlNVarchar>("language");
        
        public static readonly Column<SqlDateTime> LastRequestEndTime = new Column<SqlDateTime>("last_request_end_time");
        
        public static readonly Column<SqlDateTime> LastRequestStartTime = new Column<SqlDateTime>("last_request_start_time");
        
        public static readonly Column<SqlDateTime> LastSuccessfulLogon = new Column<SqlDateTime>("last_successful_logon");
        
        public static readonly Column<SqlDateTime> LastUnsuccessfulLogon = new Column<SqlDateTime>("last_unsuccessful_logon");
        
        public static readonly Column<SqlInt> LockTimeout = new Column<SqlInt>("lock_timeout");
        
        public static readonly Column<SqlBigInt> LogicalReads = new Column<SqlBigInt>("logical_reads");
        
        public static readonly Column<SqlNVarchar> LoginName = new Column<SqlNVarchar>("login_name");
        
        public static readonly Column<SqlDateTime> LoginTime = new Column<SqlDateTime>("login_time");
        
        public static readonly Column<SqlInt> MemoryUsage = new Column<SqlInt>("memory_usage");
        
        public static readonly Column<SqlNVarchar> NtDomain = new Column<SqlNVarchar>("nt_domain");
        
        public static readonly Column<SqlNVarchar> NtUserName = new Column<SqlNVarchar>("nt_user_name");
        
        public static readonly Column<SqlInt> OpenTransactionCount = new Column<SqlInt>("open_transaction_count");
        
        public static readonly Column<SqlNVarchar> OriginalLoginName = new Column<SqlNVarchar>("original_login_name");
        
        public static readonly Column<SqlVarbinary> OriginalSecurityId = new Column<SqlVarbinary>("original_security_id");
        
        public static readonly Column<SqlInt> PrevError = new Column<SqlInt>("prev_error");
        
        public static readonly Column<SqlNVarchar> ProgramName = new Column<SqlNVarchar>("program_name");
        
        public static readonly Column<SqlBit> QuotedIdentifier = new Column<SqlBit>("quoted_identifier");
        
        public static readonly Column<SqlBigInt> Reads = new Column<SqlBigInt>("reads");
        
        public static readonly Column<SqlBigInt> RowCount = new Column<SqlBigInt>("row_count");
        
        public static readonly Column<SqlVarbinary> SecurityId = new Column<SqlVarbinary>("security_id");
        
        public static readonly Column<SqlSmallInt> SessionId = new Column<SqlSmallInt>("session_id");
        
        public static readonly Column<SqlNVarchar> Status = new Column<SqlNVarchar>("status");
        
        public static readonly Column<SqlInt> TextSize = new Column<SqlInt>("text_size");
        
        public static readonly Column<SqlInt> TotalElapsedTime = new Column<SqlInt>("total_elapsed_time");
        
        public static readonly Column<SqlInt> TotalScheduledTime = new Column<SqlInt>("total_scheduled_time");
        
        public static readonly Column<SqlSmallInt> TransactionIsolationLevel = new Column<SqlSmallInt>("transaction_isolation_level");
        
        public static readonly Column<SqlBigInt> UnsuccessfulLogons = new Column<SqlBigInt>("unsuccessful_logons");
        
        public static readonly Column<SqlBigInt> Writes = new Column<SqlBigInt>("writes");
    }
}
