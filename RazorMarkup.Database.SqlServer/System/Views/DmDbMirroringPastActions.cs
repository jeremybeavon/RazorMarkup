using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmDbMirroringPastActions
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_db_mirroring_past_actions");
        
        public static readonly Column<SqlInt> ActionSequence = new Column<SqlInt>("action_sequence");
        
        public static readonly Column<SqlNVarchar> ActionType = new Column<SqlNVarchar>("action_type");
        
        public static readonly Column<SqlNVarchar> CurrentState = new Column<SqlNVarchar>("current_state");
        
        public static readonly Column<SqlUniqueIdentifier> MirroringGuid = new Column<SqlUniqueIdentifier>("mirroring_guid");
        
        public static readonly Column<SqlNVarchar> Name = new Column<SqlNVarchar>("name");
        
        public static readonly Column<SqlNVarchar> StateMachineName = new Column<SqlNVarchar>("state_machine_name");
    }
}
