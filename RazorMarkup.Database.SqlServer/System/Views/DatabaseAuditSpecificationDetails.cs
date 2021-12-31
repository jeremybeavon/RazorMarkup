using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DatabaseAuditSpecificationDetails
    {
        public static readonly ViewName ViewName = new("sys.database_audit_specification_details");

        public static readonly Column<SqlChar> AuditActionId = new("audit_action_id");

        public static readonly Column<SqlNVarchar> AuditActionName = new("audit_action_name");

        public static readonly Column<SqlInt> AuditedPrincipalId = new("audited_principal_id");

        public static readonly Column<SqlNVarchar> AuditedResult = new("audited_result");

        public static readonly Column<SqlTinyInt> Class = new("class");

        public static readonly Column<SqlNVarchar> ClassDesc = new("class_desc");

        public static readonly Column<SqlInt> DatabaseSpecificationId = new("database_specification_id");

        public static readonly Column<SqlBit> IsGroup = new("is_group");

        public static readonly Column<SqlInt> MajorId = new("major_id");

        public static readonly Column<SqlInt> MinorId = new("minor_id");
    }
}
