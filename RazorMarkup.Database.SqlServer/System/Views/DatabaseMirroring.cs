using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DatabaseMirroring
    {
        public static readonly ViewName ViewName = new ViewName("sys.database_mirroring");
        
        public static readonly Column<SqlInt> DatabaseId = new Column<SqlInt>("database_id");
        
        public static readonly Column<SqlInt> MirroringConnectionTimeout = new Column<SqlInt>("mirroring_connection_timeout");
        
        public static readonly Column<SqlNumeric> MirroringEndOfLogLsn = new Column<SqlNumeric>("mirroring_end_of_log_lsn");
        
        public static readonly Column<SqlNumeric> MirroringFailoverLsn = new Column<SqlNumeric>("mirroring_failover_lsn");
        
        public static readonly Column<SqlUniqueIdentifier> MirroringGuid = new Column<SqlUniqueIdentifier>("mirroring_guid");
        
        public static readonly Column<SqlNVarchar> MirroringPartnerInstance = new Column<SqlNVarchar>("mirroring_partner_instance");
        
        public static readonly Column<SqlNVarchar> MirroringPartnerName = new Column<SqlNVarchar>("mirroring_partner_name");
        
        public static readonly Column<SqlInt> MirroringRedoQueue = new Column<SqlInt>("mirroring_redo_queue");
        
        public static readonly Column<SqlNVarchar> MirroringRedoQueueType = new Column<SqlNVarchar>("mirroring_redo_queue_type");
        
        public static readonly Column<SqlNumeric> MirroringReplicationLsn = new Column<SqlNumeric>("mirroring_replication_lsn");
        
        public static readonly Column<SqlTinyInt> MirroringRole = new Column<SqlTinyInt>("mirroring_role");
        
        public static readonly Column<SqlNVarchar> MirroringRoleDesc = new Column<SqlNVarchar>("mirroring_role_desc");
        
        public static readonly Column<SqlInt> MirroringRoleSequence = new Column<SqlInt>("mirroring_role_sequence");
        
        public static readonly Column<SqlTinyInt> MirroringSafetyLevel = new Column<SqlTinyInt>("mirroring_safety_level");
        
        public static readonly Column<SqlNVarchar> MirroringSafetyLevelDesc = new Column<SqlNVarchar>("mirroring_safety_level_desc");
        
        public static readonly Column<SqlInt> MirroringSafetySequence = new Column<SqlInt>("mirroring_safety_sequence");
        
        public static readonly Column<SqlTinyInt> MirroringState = new Column<SqlTinyInt>("mirroring_state");
        
        public static readonly Column<SqlNVarchar> MirroringStateDesc = new Column<SqlNVarchar>("mirroring_state_desc");
        
        public static readonly Column<SqlNVarchar> MirroringWitnessName = new Column<SqlNVarchar>("mirroring_witness_name");
        
        public static readonly Column<SqlTinyInt> MirroringWitnessState = new Column<SqlTinyInt>("mirroring_witness_state");
        
        public static readonly Column<SqlNVarchar> MirroringWitnessStateDesc = new Column<SqlNVarchar>("mirroring_witness_state_desc");
    }
}
