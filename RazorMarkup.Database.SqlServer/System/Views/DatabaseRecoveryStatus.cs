using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DatabaseRecoveryStatus
    {
        public static readonly ViewName ViewName = new ViewName("sys.database_recovery_status");
        
        public static readonly Column<SqlUniqueIdentifier> DatabaseGuid = new Column<SqlUniqueIdentifier>("database_guid");
        
        public static readonly Column<SqlInt> DatabaseId = new Column<SqlInt>("database_id");
        
        public static readonly Column<SqlUniqueIdentifier> FamilyGuid = new Column<SqlUniqueIdentifier>("family_guid");
        
        public static readonly Column<SqlUniqueIdentifier> FirstRecoveryForkGuid = new Column<SqlUniqueIdentifier>("first_recovery_fork_guid");
        
        public static readonly Column<SqlNumeric> ForkPointLsn = new Column<SqlNumeric>("fork_point_lsn");
        
        public static readonly Column<SqlNumeric> LastLogBackupLsn = new Column<SqlNumeric>("last_log_backup_lsn");
        
        public static readonly Column<SqlUniqueIdentifier> RecoveryForkGuid = new Column<SqlUniqueIdentifier>("recovery_fork_guid");
    }
}
