using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DatabaseAuditSpecifications
    {
        public static readonly ViewName ViewName = new("sys.database_audit_specifications");

        public static readonly Column<SqlUniqueIdentifier> AuditGuid = new("audit_guid");

        public static readonly Column<SqlDateTime> CreateDate = new("create_date");

        public static readonly Column<SqlInt> DatabaseSpecificationId = new("database_specification_id");

        public static readonly Column<SqlBit> IsStateEnabled = new("is_state_enabled");

        public static readonly Column<SqlDateTime> ModifyDate = new("modify_date");

        public static readonly Column<SqlSysname> Name = new("name");
    }
}
