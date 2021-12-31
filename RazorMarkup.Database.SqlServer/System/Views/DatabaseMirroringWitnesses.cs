using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DatabaseMirroringWitnesses
    {
        public static readonly ViewName ViewName = new("sys.database_mirroring_witnesses");

        public static readonly Column<SqlSysname> DatabaseName = new("database_name");

        public static readonly Column<SqlUniqueIdentifier> FamilyGuid = new("family_guid");

        public static readonly Column<SqlBit> IsSuspended = new("is_suspended");

        public static readonly Column<SqlInt> IsSuspendedSequenceNumber = new("is_suspended_sequence_number");

        public static readonly Column<SqlSysname> MirrorServerName = new("mirror_server_name");

        public static readonly Column<SqlUniqueIdentifier> MirroringGuid = new("mirroring_guid");

        public static readonly Column<SqlTinyInt> PartnerSyncState = new("partner_sync_state");

        public static readonly Column<SqlNVarchar> PartnerSyncStateDesc = new("partner_sync_state_desc");

        public static readonly Column<SqlSysname> PrincipalServerName = new("principal_server_name");

        public static readonly Column<SqlInt> RoleSequenceNumber = new("role_sequence_number");

        public static readonly Column<SqlTinyInt> SafetyLevel = new("safety_level");

        public static readonly Column<SqlNVarchar> SafetyLevelDesc = new("safety_level_desc");

        public static readonly Column<SqlInt> SafetySequenceNumber = new("safety_sequence_number");
    }
}
