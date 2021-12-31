using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmExecSessions
    {
        public static readonly ViewName ViewName = new("sys.dm_exec_sessions");

        public static readonly Column<SqlBit> AnsiDefaults = new("ansi_defaults");

        public static readonly Column<SqlBit> AnsiNullDfltOn = new("ansi_null_dflt_on");

        public static readonly Column<SqlBit> AnsiNulls = new("ansi_nulls");

        public static readonly Column<SqlBit> AnsiPadding = new("ansi_padding");

        public static readonly Column<SqlBit> AnsiWarnings = new("ansi_warnings");

        public static readonly Column<SqlBit> Arithabort = new("arithabort");

        public static readonly Column<SqlInt> AuthenticatingDatabaseId = new("authenticating_database_id");

        public static readonly Column<SqlNVarchar> ClientInterfaceName = new("client_interface_name");

        public static readonly Column<SqlInt> ClientVersion = new("client_version");

        public static readonly Column<SqlBit> ConcatNullYieldsNull = new("concat_null_yields_null");

        public static readonly Column<SqlVarbinary> ContextInfo = new("context_info");

        public static readonly Column<SqlInt> CpuTime = new("cpu_time");

        public static readonly Column<SqlSmallInt> DatabaseId = new("database_id");

        public static readonly Column<SqlSmallInt> DateFirst = new("date_first");

        public static readonly Column<SqlNVarchar> DateFormat = new("date_format");

        public static readonly Column<SqlInt> DeadlockPriority = new("deadlock_priority");

        public static readonly Column<SqlInt> EndpointId = new("endpoint_id");

        public static readonly Column<SqlInt> GroupId = new("group_id");

        public static readonly Column<SqlNVarchar> HostName = new("host_name");

        public static readonly Column<SqlInt> HostProcessId = new("host_process_id");

        public static readonly Column<SqlBit> IsUserProcess = new("is_user_process");

        public static readonly Column<SqlNVarchar> Language = new("language");

        public static readonly Column<SqlDateTime> LastRequestEndTime = new("last_request_end_time");

        public static readonly Column<SqlDateTime> LastRequestStartTime = new("last_request_start_time");

        public static readonly Column<SqlDateTime> LastSuccessfulLogon = new("last_successful_logon");

        public static readonly Column<SqlDateTime> LastUnsuccessfulLogon = new("last_unsuccessful_logon");

        public static readonly Column<SqlInt> LockTimeout = new("lock_timeout");

        public static readonly Column<SqlBigInt> LogicalReads = new("logical_reads");

        public static readonly Column<SqlNVarchar> LoginName = new("login_name");

        public static readonly Column<SqlDateTime> LoginTime = new("login_time");

        public static readonly Column<SqlInt> MemoryUsage = new("memory_usage");

        public static readonly Column<SqlNVarchar> NtDomain = new("nt_domain");

        public static readonly Column<SqlNVarchar> NtUserName = new("nt_user_name");

        public static readonly Column<SqlInt> OpenTransactionCount = new("open_transaction_count");

        public static readonly Column<SqlNVarchar> OriginalLoginName = new("original_login_name");

        public static readonly Column<SqlVarbinary> OriginalSecurityId = new("original_security_id");

        public static readonly Column<SqlInt> PrevError = new("prev_error");

        public static readonly Column<SqlNVarchar> ProgramName = new("program_name");

        public static readonly Column<SqlBit> QuotedIdentifier = new("quoted_identifier");

        public static readonly Column<SqlBigInt> Reads = new("reads");

        public static readonly Column<SqlBigInt> RowCount = new("row_count");

        public static readonly Column<SqlVarbinary> SecurityId = new("security_id");

        public static readonly Column<SqlSmallInt> SessionId = new("session_id");

        public static readonly Column<SqlNVarchar> Status = new("status");

        public static readonly Column<SqlInt> TextSize = new("text_size");

        public static readonly Column<SqlInt> TotalElapsedTime = new("total_elapsed_time");

        public static readonly Column<SqlInt> TotalScheduledTime = new("total_scheduled_time");

        public static readonly Column<SqlSmallInt> TransactionIsolationLevel = new("transaction_isolation_level");

        public static readonly Column<SqlBigInt> UnsuccessfulLogons = new("unsuccessful_logons");

        public static readonly Column<SqlBigInt> Writes = new("writes");
    }
}
