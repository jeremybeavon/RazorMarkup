using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmCdcErrors
    {
        public static readonly ViewName ViewName = new("sys.dm_cdc_errors");

        public static readonly Column<SqlNVarchar> BeginLsn = new("begin_lsn");

        public static readonly Column<SqlDateTime> EntryTime = new("entry_time");

        public static readonly Column<SqlNVarchar> ErrorMessage = new("error_message");

        public static readonly Column<SqlInt> ErrorNumber = new("error_number");

        public static readonly Column<SqlInt> ErrorSeverity = new("error_severity");

        public static readonly Column<SqlInt> ErrorState = new("error_state");

        public static readonly Column<SqlInt> PhaseNumber = new("phase_number");

        public static readonly Column<SqlNVarchar> SequenceValue = new("sequence_value");

        public static readonly Column<SqlInt> SessionId = new("session_id");

        public static readonly Column<SqlNVarchar> StartLsn = new("start_lsn");
    }
}
