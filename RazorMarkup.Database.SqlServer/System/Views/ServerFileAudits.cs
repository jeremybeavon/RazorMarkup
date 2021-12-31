using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ServerFileAudits
    {
        public static readonly ViewName ViewName = new("sys.server_file_audits");

        public static readonly Column<SqlUniqueIdentifier> AuditGuid = new("audit_guid");

        public static readonly Column<SqlInt> AuditId = new("audit_id");

        public static readonly Column<SqlDateTime> CreateDate = new("create_date");

        public static readonly Column<SqlBit> IsStateEnabled = new("is_state_enabled");

        public static readonly Column<SqlNVarchar> LogFileName = new("log_file_name");

        public static readonly Column<SqlNVarchar> LogFilePath = new("log_file_path");

        public static readonly Column<SqlBigInt> MaxFileSize = new("max_file_size");

        public static readonly Column<SqlInt> MaxFiles = new("max_files");

        public static readonly Column<SqlInt> MaxRolloverFiles = new("max_rollover_files");

        public static readonly Column<SqlDateTime> ModifyDate = new("modify_date");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlTinyInt> OnFailure = new("on_failure");

        public static readonly Column<SqlNVarchar> OnFailureDesc = new("on_failure_desc");

        public static readonly Column<SqlNVarchar> Predicate = new("predicate");

        public static readonly Column<SqlInt> PrincipalId = new("principal_id");

        public static readonly Column<SqlInt> QueueDelay = new("queue_delay");

        public static readonly Column<SqlBit> ReserveDiskSpace = new("reserve_disk_space");

        public static readonly Column<SqlChar> Type = new("type");

        public static readonly Column<SqlNVarchar> TypeDesc = new("type_desc");
    }
}
