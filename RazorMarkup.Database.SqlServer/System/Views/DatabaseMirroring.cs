using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DatabaseMirroring
    {
        public static readonly ViewName ViewName = new("sys.database_mirroring");

        public static readonly Column<SqlInt> DatabaseId = new("database_id");

        public static readonly Column<SqlInt> MirroringConnectionTimeout = new("mirroring_connection_timeout");

        public static readonly Column<SqlNumeric> MirroringEndOfLogLsn = new("mirroring_end_of_log_lsn");

        public static readonly Column<SqlNumeric> MirroringFailoverLsn = new("mirroring_failover_lsn");

        public static readonly Column<SqlUniqueIdentifier> MirroringGuid = new("mirroring_guid");

        public static readonly Column<SqlNVarchar> MirroringPartnerInstance = new("mirroring_partner_instance");

        public static readonly Column<SqlNVarchar> MirroringPartnerName = new("mirroring_partner_name");

        public static readonly Column<SqlInt> MirroringRedoQueue = new("mirroring_redo_queue");

        public static readonly Column<SqlNVarchar> MirroringRedoQueueType = new("mirroring_redo_queue_type");

        public static readonly Column<SqlNumeric> MirroringReplicationLsn = new("mirroring_replication_lsn");

        public static readonly Column<SqlTinyInt> MirroringRole = new("mirroring_role");

        public static readonly Column<SqlNVarchar> MirroringRoleDesc = new("mirroring_role_desc");

        public static readonly Column<SqlInt> MirroringRoleSequence = new("mirroring_role_sequence");

        public static readonly Column<SqlTinyInt> MirroringSafetyLevel = new("mirroring_safety_level");

        public static readonly Column<SqlNVarchar> MirroringSafetyLevelDesc = new("mirroring_safety_level_desc");

        public static readonly Column<SqlInt> MirroringSafetySequence = new("mirroring_safety_sequence");

        public static readonly Column<SqlTinyInt> MirroringState = new("mirroring_state");

        public static readonly Column<SqlNVarchar> MirroringStateDesc = new("mirroring_state_desc");

        public static readonly Column<SqlNVarchar> MirroringWitnessName = new("mirroring_witness_name");

        public static readonly Column<SqlTinyInt> MirroringWitnessState = new("mirroring_witness_state");

        public static readonly Column<SqlNVarchar> MirroringWitnessStateDesc = new("mirroring_witness_state_desc");
    }
}
