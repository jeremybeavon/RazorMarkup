using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmTranLocks
    {
        public static readonly ViewName ViewName = new("sys.dm_tran_locks");

        public static readonly Column<SqlVarbinary> LockOwnerAddress = new("lock_owner_address");

        public static readonly Column<SqlInt> RequestExecContextId = new("request_exec_context_id");

        public static readonly Column<SqlInt> RequestLifetime = new("request_lifetime");

        public static readonly Column<SqlNVarchar> RequestMode = new("request_mode");

        public static readonly Column<SqlUniqueIdentifier> RequestOwnerGuid = new("request_owner_guid");

        public static readonly Column<SqlBigInt> RequestOwnerId = new("request_owner_id");

        public static readonly Column<SqlNVarchar> RequestOwnerLockspaceId = new("request_owner_lockspace_id");

        public static readonly Column<SqlNVarchar> RequestOwnerType = new("request_owner_type");

        public static readonly Column<SqlSmallInt> RequestReferenceCount = new("request_reference_count");

        public static readonly Column<SqlInt> RequestRequestId = new("request_request_id");

        public static readonly Column<SqlInt> RequestSessionId = new("request_session_id");

        public static readonly Column<SqlNVarchar> RequestStatus = new("request_status");

        public static readonly Column<SqlNVarchar> RequestType = new("request_type");

        public static readonly Column<SqlBigInt> ResourceAssociatedEntityId = new("resource_associated_entity_id");

        public static readonly Column<SqlInt> ResourceDatabaseId = new("resource_database_id");

        public static readonly Column<SqlNVarchar> ResourceDescription = new("resource_description");

        public static readonly Column<SqlInt> ResourceLockPartition = new("resource_lock_partition");

        public static readonly Column<SqlNVarchar> ResourceSubtype = new("resource_subtype");

        public static readonly Column<SqlNVarchar> ResourceType = new("resource_type");
    }
}
