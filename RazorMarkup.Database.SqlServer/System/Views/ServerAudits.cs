using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ServerAudits
    {
        public static readonly ViewName ViewName = new("sys.server_audits");

        public static readonly Column<SqlUniqueIdentifier> AuditGuid = new("audit_guid");

        public static readonly Column<SqlInt> AuditId = new("audit_id");

        public static readonly Column<SqlDateTime> CreateDate = new("create_date");

        public static readonly Column<SqlBit> IsStateEnabled = new("is_state_enabled");

        public static readonly Column<SqlDateTime> ModifyDate = new("modify_date");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlTinyInt> OnFailure = new("on_failure");

        public static readonly Column<SqlNVarchar> OnFailureDesc = new("on_failure_desc");

        public static readonly Column<SqlNVarchar> Predicate = new("predicate");

        public static readonly Column<SqlInt> PrincipalId = new("principal_id");

        public static readonly Column<SqlInt> QueueDelay = new("queue_delay");

        public static readonly Column<SqlChar> Type = new("type");

        public static readonly Column<SqlNVarchar> TypeDesc = new("type_desc");
    }
}
