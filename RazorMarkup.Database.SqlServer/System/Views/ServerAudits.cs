using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ServerAudits
    {
        public static readonly ViewName ViewName = new ViewName("sys.server_audits");
        
        public static readonly Column<SqlUniqueIdentifier> AuditGuid = new Column<SqlUniqueIdentifier>("audit_guid");
        
        public static readonly Column<SqlInt> AuditId = new Column<SqlInt>("audit_id");
        
        public static readonly Column<SqlDateTime> CreateDate = new Column<SqlDateTime>("create_date");
        
        public static readonly Column<SqlBit> IsStateEnabled = new Column<SqlBit>("is_state_enabled");
        
        public static readonly Column<SqlDateTime> ModifyDate = new Column<SqlDateTime>("modify_date");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlTinyInt> OnFailure = new Column<SqlTinyInt>("on_failure");
        
        public static readonly Column<SqlNVarchar> OnFailureDesc = new Column<SqlNVarchar>("on_failure_desc");
        
        public static readonly Column<SqlNVarchar> Predicate = new Column<SqlNVarchar>("predicate");
        
        public static readonly Column<SqlInt> PrincipalId = new Column<SqlInt>("principal_id");
        
        public static readonly Column<SqlInt> QueueDelay = new Column<SqlInt>("queue_delay");
        
        public static readonly Column<SqlChar> Type = new Column<SqlChar>("type");
        
        public static readonly Column<SqlNVarchar> TypeDesc = new Column<SqlNVarchar>("type_desc");
    }
}
