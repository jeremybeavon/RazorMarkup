using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmCdcErrors
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_cdc_errors");
        
        public static readonly Column<SqlNVarchar> BeginLsn = new Column<SqlNVarchar>("begin_lsn");
        
        public static readonly Column<SqlDateTime> EntryTime = new Column<SqlDateTime>("entry_time");
        
        public static readonly Column<SqlNVarchar> ErrorMessage = new Column<SqlNVarchar>("error_message");
        
        public static readonly Column<SqlInt> ErrorNumber = new Column<SqlInt>("error_number");
        
        public static readonly Column<SqlInt> ErrorSeverity = new Column<SqlInt>("error_severity");
        
        public static readonly Column<SqlInt> ErrorState = new Column<SqlInt>("error_state");
        
        public static readonly Column<SqlInt> PhaseNumber = new Column<SqlInt>("phase_number");
        
        public static readonly Column<SqlNVarchar> SequenceValue = new Column<SqlNVarchar>("sequence_value");
        
        public static readonly Column<SqlInt> SessionId = new Column<SqlInt>("session_id");
        
        public static readonly Column<SqlNVarchar> StartLsn = new Column<SqlNVarchar>("start_lsn");
    }
}
