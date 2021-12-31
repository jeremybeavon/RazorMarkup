using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmDbMirroringPastActions
    {
        public static readonly ViewName ViewName = new("sys.dm_db_mirroring_past_actions");

        public static readonly Column<SqlInt> ActionSequence = new("action_sequence");

        public static readonly Column<SqlNVarchar> ActionType = new("action_type");

        public static readonly Column<SqlNVarchar> CurrentState = new("current_state");

        public static readonly Column<SqlUniqueIdentifier> MirroringGuid = new("mirroring_guid");

        public static readonly Column<SqlNVarchar> Name = new("name");

        public static readonly Column<SqlNVarchar> StateMachineName = new("state_machine_name");
    }
}
