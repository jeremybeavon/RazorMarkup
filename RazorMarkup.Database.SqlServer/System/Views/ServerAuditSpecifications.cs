using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ServerAuditSpecifications
    {
        public static readonly ViewName ViewName = new ViewName("sys.server_audit_specifications");
        
        public static readonly Column<SqlUniqueIdentifier> AuditGuid = new Column<SqlUniqueIdentifier>("audit_guid");
        
        public static readonly Column<SqlDateTime> CreateDate = new Column<SqlDateTime>("create_date");
        
        public static readonly Column<SqlBit> IsStateEnabled = new Column<SqlBit>("is_state_enabled");
        
        public static readonly Column<SqlDateTime> ModifyDate = new Column<SqlDateTime>("modify_date");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlInt> ServerSpecificationId = new Column<SqlInt>("server_specification_id");
    }
}
