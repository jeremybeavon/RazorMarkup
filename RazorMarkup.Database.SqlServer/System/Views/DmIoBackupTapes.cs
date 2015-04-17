using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmIoBackupTapes
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_io_backup_tapes");
        
        public static readonly Column<SqlInt> Command = new Column<SqlInt>("command");
        
        public static readonly Column<SqlNVarchar> CommandDesc = new Column<SqlNVarchar>("command_desc");
        
        public static readonly Column<SqlNVarchar> DatabaseName = new Column<SqlNVarchar>("database_name");
        
        public static readonly Column<SqlNVarchar> LogicalDeviceName = new Column<SqlNVarchar>("logical_device_name");
        
        public static readonly Column<SqlInt> MediaFamilyId = new Column<SqlInt>("media_family_id");
        
        public static readonly Column<SqlInt> MediaSequenceNumber = new Column<SqlInt>("media_sequence_number");
        
        public static readonly Column<SqlUniqueIdentifier> MediaSetGuid = new Column<SqlUniqueIdentifier>("media_set_guid");
        
        public static readonly Column<SqlNVarchar> MediaSetName = new Column<SqlNVarchar>("media_set_name");
        
        public static readonly Column<SqlDateTime> MountExpirationTime = new Column<SqlDateTime>("mount_expiration_time");
        
        public static readonly Column<SqlDateTime> MountRequestTime = new Column<SqlDateTime>("mount_request_time");
        
        public static readonly Column<SqlInt> MountRequestType = new Column<SqlInt>("mount_request_type");
        
        public static readonly Column<SqlNVarchar> MountRequestTypeDesc = new Column<SqlNVarchar>("mount_request_type_desc");
        
        public static readonly Column<SqlNVarchar> PhysicalDeviceName = new Column<SqlNVarchar>("physical_device_name");
        
        public static readonly Column<SqlInt> Spid = new Column<SqlInt>("spid");
        
        public static readonly Column<SqlInt> Status = new Column<SqlInt>("status");
        
        public static readonly Column<SqlNVarchar> StatusDesc = new Column<SqlNVarchar>("status_desc");
        
        public static readonly Column<SqlInt> TapeOperation = new Column<SqlInt>("tape_operation");
        
        public static readonly Column<SqlNVarchar> TapeOperationDesc = new Column<SqlNVarchar>("tape_operation_desc");
    }
}
