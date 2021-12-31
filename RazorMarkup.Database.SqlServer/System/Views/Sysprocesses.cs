using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysProcesses
    {
        public static readonly ViewName ViewName = new("sys.sysprocesses");

        public static readonly Column<SqlSmallInt> Blocked = new("blocked");

        public static readonly Column<SqlNChar> Cmd = new("cmd");

        public static readonly Column<SqlBinary> ContextInfo = new("context_info");

        public static readonly Column<SqlInt> Cpu = new("cpu");

        public static readonly Column<SqlSmallInt> Dbid = new("dbid");

        public static readonly Column<SqlSmallInt> Ecid = new("ecid");

        public static readonly Column<SqlNChar> Hostname = new("hostname");

        public static readonly Column<SqlNChar> Hostprocess = new("hostprocess");

        public static readonly Column<SqlSmallInt> Kpid = new("kpid");

        public static readonly Column<SqlDateTime> LastBatch = new("last_batch");

        public static readonly Column<SqlNChar> Lastwaittype = new("lastwaittype");

        public static readonly Column<SqlDateTime> LoginTime = new("login_time");

        public static readonly Column<SqlNChar> Loginame = new("loginame");

        public static readonly Column<SqlInt> Memusage = new("memusage");

        public static readonly Column<SqlNChar> NetAddress = new("net_address");

        public static readonly Column<SqlNChar> NetLibrary = new("net_library");

        public static readonly Column<SqlNChar> NtDomain = new("nt_domain");

        public static readonly Column<SqlNChar> NtUsername = new("nt_username");

        public static readonly Column<SqlSmallInt> OpenTran = new("open_tran");

        public static readonly Column<SqlBigInt> PhysicalIo = new("physical_io");

        public static readonly Column<SqlNChar> ProgramName = new("program_name");

        public static readonly Column<SqlInt> RequestId = new("request_id");

        public static readonly Column<SqlBinary> Sid = new("sid");

        public static readonly Column<SqlSmallInt> Spid = new("spid");

        public static readonly Column<SqlBinary> SqlHandle = new("sql_handle");

        public static readonly Column<SqlNChar> Status = new("status");

        public static readonly Column<SqlInt> StmtEnd = new("stmt_end");

        public static readonly Column<SqlInt> StmtStart = new("stmt_start");

        public static readonly Column<SqlSmallInt> Uid = new("uid");

        public static readonly Column<SqlNChar> Waitresource = new("waitresource");

        public static readonly Column<SqlBigInt> Waittime = new("waittime");

        public static readonly Column<SqlBinary> Waittype = new("waittype");
    }
}
