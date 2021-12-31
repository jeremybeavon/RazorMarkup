using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DatabaseRecoveryStatus
    {
        public static readonly ViewName ViewName = new("sys.database_recovery_status");

        public static readonly Column<SqlUniqueIdentifier> DatabaseGuid = new("database_guid");

        public static readonly Column<SqlInt> DatabaseId = new("database_id");

        public static readonly Column<SqlUniqueIdentifier> FamilyGuid = new("family_guid");

        public static readonly Column<SqlUniqueIdentifier> FirstRecoveryForkGuid = new("first_recovery_fork_guid");

        public static readonly Column<SqlNumeric> ForkPointLsn = new("fork_point_lsn");

        public static readonly Column<SqlNumeric> LastLogBackupLsn = new("last_log_backup_lsn");

        public static readonly Column<SqlUniqueIdentifier> RecoveryForkGuid = new("recovery_fork_guid");
    }
}
