using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmCdcLogScanSessions
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_cdc_log_scan_sessions");
        
        public static readonly Column<SqlBigInt> CommandCount = new Column<SqlBigInt>("command_count");
        
        public static readonly Column<SqlNVarchar> CurrentLsn = new Column<SqlNVarchar>("current_lsn");
        
        public static readonly Column<SqlInt> Duration = new Column<SqlInt>("duration");
        
        public static readonly Column<SqlInt> EmptyScanCount = new Column<SqlInt>("empty_scan_count");
        
        public static readonly Column<SqlNVarchar> EndLsn = new Column<SqlNVarchar>("end_lsn");
        
        public static readonly Column<SqlDateTime> EndTime = new Column<SqlDateTime>("end_time");
        
        public static readonly Column<SqlInt> ErrorCount = new Column<SqlInt>("error_count");
        
        public static readonly Column<SqlInt> FailedSessionsCount = new Column<SqlInt>("failed_sessions_count");
        
        public static readonly Column<SqlNVarchar> FirstBeginCdcLsn = new Column<SqlNVarchar>("first_begin_cdc_lsn");
        
        public static readonly Column<SqlNVarchar> LastCommitCdcLsn = new Column<SqlNVarchar>("last_commit_cdc_lsn");
        
        public static readonly Column<SqlDateTime> LastCommitCdcTime = new Column<SqlDateTime>("last_commit_cdc_time");
        
        public static readonly Column<SqlNVarchar> LastCommitLsn = new Column<SqlNVarchar>("last_commit_lsn");
        
        public static readonly Column<SqlDateTime> LastCommitTime = new Column<SqlDateTime>("last_commit_time");
        
        public static readonly Column<SqlInt> Latency = new Column<SqlInt>("latency");
        
        public static readonly Column<SqlBigInt> LogRecordCount = new Column<SqlBigInt>("log_record_count");
        
        public static readonly Column<SqlNVarchar> ScanPhase = new Column<SqlNVarchar>("scan_phase");
        
        public static readonly Column<SqlInt> SchemaChangeCount = new Column<SqlInt>("schema_change_count");
        
        public static readonly Column<SqlInt> SessionId = new Column<SqlInt>("session_id");
        
        public static readonly Column<SqlNVarchar> StartLsn = new Column<SqlNVarchar>("start_lsn");
        
        public static readonly Column<SqlDateTime> StartTime = new Column<SqlDateTime>("start_time");
        
        public static readonly Column<SqlBigInt> TranCount = new Column<SqlBigInt>("tran_count");
    }
}
