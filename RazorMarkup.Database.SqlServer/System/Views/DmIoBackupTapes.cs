using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmIoBackupTapes
    {
        public static readonly ViewName ViewName = new("sys.dm_io_backup_tapes");

        public static readonly Column<SqlInt> Command = new("command");

        public static readonly Column<SqlNVarchar> CommandDesc = new("command_desc");

        public static readonly Column<SqlNVarchar> DatabaseName = new("database_name");

        public static readonly Column<SqlNVarchar> LogicalDeviceName = new("logical_device_name");

        public static readonly Column<SqlInt> MediaFamilyId = new("media_family_id");

        public static readonly Column<SqlInt> MediaSequenceNumber = new("media_sequence_number");

        public static readonly Column<SqlUniqueIdentifier> MediaSetGuid = new("media_set_guid");

        public static readonly Column<SqlNVarchar> MediaSetName = new("media_set_name");

        public static readonly Column<SqlDateTime> MountExpirationTime = new("mount_expiration_time");

        public static readonly Column<SqlDateTime> MountRequestTime = new("mount_request_time");

        public static readonly Column<SqlInt> MountRequestType = new("mount_request_type");

        public static readonly Column<SqlNVarchar> MountRequestTypeDesc = new("mount_request_type_desc");

        public static readonly Column<SqlNVarchar> PhysicalDeviceName = new("physical_device_name");

        public static readonly Column<SqlInt> Spid = new("spid");

        public static readonly Column<SqlInt> Status = new("status");

        public static readonly Column<SqlNVarchar> StatusDesc = new("status_desc");

        public static readonly Column<SqlInt> TapeOperation = new("tape_operation");

        public static readonly Column<SqlNVarchar> TapeOperationDesc = new("tape_operation_desc");
    }
}
