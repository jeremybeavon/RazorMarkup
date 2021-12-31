using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmCdcLogScanSessions
    {
        public static readonly ViewName ViewName = new("sys.dm_cdc_log_scan_sessions");

        public static readonly Column<SqlBigInt> CommandCount = new("command_count");

        public static readonly Column<SqlNVarchar> CurrentLsn = new("current_lsn");

        public static readonly Column<SqlInt> Duration = new("duration");

        public static readonly Column<SqlInt> EmptyScanCount = new("empty_scan_count");

        public static readonly Column<SqlNVarchar> EndLsn = new("end_lsn");

        public static readonly Column<SqlDateTime> EndTime = new("end_time");

        public static readonly Column<SqlInt> ErrorCount = new("error_count");

        public static readonly Column<SqlInt> FailedSessionsCount = new("failed_sessions_count");

        public static readonly Column<SqlNVarchar> FirstBeginCdcLsn = new("first_begin_cdc_lsn");

        public static readonly Column<SqlNVarchar> LastCommitCdcLsn = new("last_commit_cdc_lsn");

        public static readonly Column<SqlDateTime> LastCommitCdcTime = new("last_commit_cdc_time");

        public static readonly Column<SqlNVarchar> LastCommitLsn = new("last_commit_lsn");

        public static readonly Column<SqlDateTime> LastCommitTime = new("last_commit_time");

        public static readonly Column<SqlInt> Latency = new("latency");

        public static readonly Column<SqlBigInt> LogRecordCount = new("log_record_count");

        public static readonly Column<SqlNVarchar> ScanPhase = new("scan_phase");

        public static readonly Column<SqlInt> SchemaChangeCount = new("schema_change_count");

        public static readonly Column<SqlInt> SessionId = new("session_id");

        public static readonly Column<SqlNVarchar> StartLsn = new("start_lsn");

        public static readonly Column<SqlDateTime> StartTime = new("start_time");

        public static readonly Column<SqlBigInt> TranCount = new("tran_count");
    }
}
