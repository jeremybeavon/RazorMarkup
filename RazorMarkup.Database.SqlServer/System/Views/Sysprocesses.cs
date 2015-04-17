using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Sysprocesses
    {
        public static readonly ViewName ViewName = new ViewName("sys.sysprocesses");
        
        public static readonly Column<SqlSmallInt> Blocked = new Column<SqlSmallInt>("blocked");
        
        public static readonly Column<SqlNChar> Cmd = new Column<SqlNChar>("cmd");
        
        public static readonly Column<SqlBinary> ContextInfo = new Column<SqlBinary>("context_info");
        
        public static readonly Column<SqlInt> Cpu = new Column<SqlInt>("cpu");
        
        public static readonly Column<SqlSmallInt> Dbid = new Column<SqlSmallInt>("dbid");
        
        public static readonly Column<SqlSmallInt> Ecid = new Column<SqlSmallInt>("ecid");
        
        public static readonly Column<SqlNChar> Hostname = new Column<SqlNChar>("hostname");
        
        public static readonly Column<SqlNChar> Hostprocess = new Column<SqlNChar>("hostprocess");
        
        public static readonly Column<SqlSmallInt> Kpid = new Column<SqlSmallInt>("kpid");
        
        public static readonly Column<SqlDateTime> LastBatch = new Column<SqlDateTime>("last_batch");
        
        public static readonly Column<SqlNChar> Lastwaittype = new Column<SqlNChar>("lastwaittype");
        
        public static readonly Column<SqlDateTime> LoginTime = new Column<SqlDateTime>("login_time");
        
        public static readonly Column<SqlNChar> Loginame = new Column<SqlNChar>("loginame");
        
        public static readonly Column<SqlInt> Memusage = new Column<SqlInt>("memusage");
        
        public static readonly Column<SqlNChar> NetAddress = new Column<SqlNChar>("net_address");
        
        public static readonly Column<SqlNChar> NetLibrary = new Column<SqlNChar>("net_library");
        
        public static readonly Column<SqlNChar> NtDomain = new Column<SqlNChar>("nt_domain");
        
        public static readonly Column<SqlNChar> NtUsername = new Column<SqlNChar>("nt_username");
        
        public static readonly Column<SqlSmallInt> OpenTran = new Column<SqlSmallInt>("open_tran");
        
        public static readonly Column<SqlBigInt> PhysicalIo = new Column<SqlBigInt>("physical_io");
        
        public static readonly Column<SqlNChar> ProgramName = new Column<SqlNChar>("program_name");
        
        public static readonly Column<SqlInt> RequestId = new Column<SqlInt>("request_id");
        
        public static readonly Column<SqlBinary> Sid = new Column<SqlBinary>("sid");
        
        public static readonly Column<SqlSmallInt> Spid = new Column<SqlSmallInt>("spid");
        
        public static readonly Column<SqlBinary> SqlHandle = new Column<SqlBinary>("sql_handle");
        
        public static readonly Column<SqlNChar> Status = new Column<SqlNChar>("status");
        
        public static readonly Column<SqlInt> StmtEnd = new Column<SqlInt>("stmt_end");
        
        public static readonly Column<SqlInt> StmtStart = new Column<SqlInt>("stmt_start");
        
        public static readonly Column<SqlSmallInt> Uid = new Column<SqlSmallInt>("uid");
        
        public static readonly Column<SqlNChar> Waitresource = new Column<SqlNChar>("waitresource");
        
        public static readonly Column<SqlBigInt> Waittime = new Column<SqlBigInt>("waittime");
        
        public static readonly Column<SqlBinary> Waittype = new Column<SqlBinary>("waittype");
    }
}
