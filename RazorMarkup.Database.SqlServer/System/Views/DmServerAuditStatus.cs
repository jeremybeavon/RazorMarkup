using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmServerAuditStatus
    {
        public static readonly ViewName ViewName = new("sys.dm_server_audit_status");

        public static readonly Column<SqlNVarchar> AuditFilePath = new("audit_file_path");

        public static readonly Column<SqlBigInt> AuditFileSize = new("audit_file_size");

        public static readonly Column<SqlInt> AuditId = new("audit_id");

        public static readonly Column<SqlVarbinary> EventSessionAddress = new("event_session_address");

        public static readonly Column<SqlNVarchar> Name = new("name");

        public static readonly Column<SqlSmallInt> Status = new("status");

        public static readonly Column<SqlNVarchar> StatusDesc = new("status_desc");

        public static readonly Column<SqlDateTime2> StatusTime = new("status_time");
    }
}
