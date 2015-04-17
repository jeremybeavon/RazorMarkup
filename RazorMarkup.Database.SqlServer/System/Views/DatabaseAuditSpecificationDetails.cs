using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DatabaseAuditSpecificationDetails
    {
        public static readonly ViewName ViewName = new ViewName("sys.database_audit_specification_details");
        
        public static readonly Column<SqlChar> AuditActionId = new Column<SqlChar>("audit_action_id");
        
        public static readonly Column<SqlNVarchar> AuditActionName = new Column<SqlNVarchar>("audit_action_name");
        
        public static readonly Column<SqlInt> AuditedPrincipalId = new Column<SqlInt>("audited_principal_id");
        
        public static readonly Column<SqlNVarchar> AuditedResult = new Column<SqlNVarchar>("audited_result");
        
        public static readonly Column<SqlTinyInt> Class = new Column<SqlTinyInt>("class");
        
        public static readonly Column<SqlNVarchar> ClassDesc = new Column<SqlNVarchar>("class_desc");
        
        public static readonly Column<SqlInt> DatabaseSpecificationId = new Column<SqlInt>("database_specification_id");
        
        public static readonly Column<SqlBit> IsGroup = new Column<SqlBit>("is_group");
        
        public static readonly Column<SqlInt> MajorId = new Column<SqlInt>("major_id");
        
        public static readonly Column<SqlInt> MinorId = new Column<SqlInt>("minor_id");
    }
}
