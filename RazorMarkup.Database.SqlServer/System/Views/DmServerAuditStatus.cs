using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmServerAuditStatus
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_server_audit_status");
        
        public static readonly Column<SqlNVarchar> AuditFilePath = new Column<SqlNVarchar>("audit_file_path");
        
        public static readonly Column<SqlBigInt> AuditFileSize = new Column<SqlBigInt>("audit_file_size");
        
        public static readonly Column<SqlInt> AuditId = new Column<SqlInt>("audit_id");
        
        public static readonly Column<SqlVarbinary> EventSessionAddress = new Column<SqlVarbinary>("event_session_address");
        
        public static readonly Column<SqlNVarchar> Name = new Column<SqlNVarchar>("name");
        
        public static readonly Column<SqlSmallInt> Status = new Column<SqlSmallInt>("status");
        
        public static readonly Column<SqlNVarchar> StatusDesc = new Column<SqlNVarchar>("status_desc");
        
        public static readonly Column<SqlDateTime2> StatusTime = new Column<SqlDateTime2>("status_time");
    }
}
