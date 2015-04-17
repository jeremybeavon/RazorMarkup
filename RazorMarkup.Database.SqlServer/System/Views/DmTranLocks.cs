using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmTranLocks
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_tran_locks");
        
        public static readonly Column<SqlVarbinary> LockOwnerAddress = new Column<SqlVarbinary>("lock_owner_address");
        
        public static readonly Column<SqlInt> RequestExecContextId = new Column<SqlInt>("request_exec_context_id");
        
        public static readonly Column<SqlInt> RequestLifetime = new Column<SqlInt>("request_lifetime");
        
        public static readonly Column<SqlNVarchar> RequestMode = new Column<SqlNVarchar>("request_mode");
        
        public static readonly Column<SqlUniqueIdentifier> RequestOwnerGuid = new Column<SqlUniqueIdentifier>("request_owner_guid");
        
        public static readonly Column<SqlBigInt> RequestOwnerId = new Column<SqlBigInt>("request_owner_id");
        
        public static readonly Column<SqlNVarchar> RequestOwnerLockspaceId = new Column<SqlNVarchar>("request_owner_lockspace_id");
        
        public static readonly Column<SqlNVarchar> RequestOwnerType = new Column<SqlNVarchar>("request_owner_type");
        
        public static readonly Column<SqlSmallInt> RequestReferenceCount = new Column<SqlSmallInt>("request_reference_count");
        
        public static readonly Column<SqlInt> RequestRequestId = new Column<SqlInt>("request_request_id");
        
        public static readonly Column<SqlInt> RequestSessionId = new Column<SqlInt>("request_session_id");
        
        public static readonly Column<SqlNVarchar> RequestStatus = new Column<SqlNVarchar>("request_status");
        
        public static readonly Column<SqlNVarchar> RequestType = new Column<SqlNVarchar>("request_type");
        
        public static readonly Column<SqlBigInt> ResourceAssociatedEntityId = new Column<SqlBigInt>("resource_associated_entity_id");
        
        public static readonly Column<SqlInt> ResourceDatabaseId = new Column<SqlInt>("resource_database_id");
        
        public static readonly Column<SqlNVarchar> ResourceDescription = new Column<SqlNVarchar>("resource_description");
        
        public static readonly Column<SqlInt> ResourceLockPartition = new Column<SqlInt>("resource_lock_partition");
        
        public static readonly Column<SqlNVarchar> ResourceSubtype = new Column<SqlNVarchar>("resource_subtype");
        
        public static readonly Column<SqlNVarchar> ResourceType = new Column<SqlNVarchar>("resource_type");
    }
}
