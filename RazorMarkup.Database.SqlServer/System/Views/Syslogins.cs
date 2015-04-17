using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysLogins
    {
        public static readonly ViewName ViewName = new ViewName("sys.syslogins");
        
        public static readonly Column<SqlDateTime> Accdate = new Column<SqlDateTime>("accdate");
        
        public static readonly Column<SqlInt> Bulkadmin = new Column<SqlInt>("bulkadmin");
        
        public static readonly Column<SqlDateTime> Createdate = new Column<SqlDateTime>("createdate");
        
        public static readonly Column<SqlInt> Dbcreator = new Column<SqlInt>("dbcreator");
        
        public static readonly Column<SqlSysname> Dbname = new Column<SqlSysname>("dbname");
        
        public static readonly Column<SqlInt> Denylogin = new Column<SqlInt>("denylogin");
        
        public static readonly Column<SqlInt> Diskadmin = new Column<SqlInt>("diskadmin");
        
        public static readonly Column<SqlInt> Hasaccess = new Column<SqlInt>("hasaccess");
        
        public static readonly Column<SqlInt> Isntgroup = new Column<SqlInt>("isntgroup");
        
        public static readonly Column<SqlInt> Isntname = new Column<SqlInt>("isntname");
        
        public static readonly Column<SqlInt> Isntuser = new Column<SqlInt>("isntuser");
        
        public static readonly Column<SqlSysname> Language = new Column<SqlSysname>("language");
        
        public static readonly Column<SqlSysname> Loginname = new Column<SqlSysname>("loginname");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlSysname> Password = new Column<SqlSysname>("password");
        
        public static readonly Column<SqlInt> Processadmin = new Column<SqlInt>("processadmin");
        
        public static readonly Column<SqlInt> Resultlimit = new Column<SqlInt>("resultlimit");
        
        public static readonly Column<SqlInt> Securityadmin = new Column<SqlInt>("securityadmin");
        
        public static readonly Column<SqlInt> Serveradmin = new Column<SqlInt>("serveradmin");
        
        public static readonly Column<SqlInt> Setupadmin = new Column<SqlInt>("setupadmin");
        
        public static readonly Column<SqlVarbinary> Sid = new Column<SqlVarbinary>("sid");
        
        public static readonly Column<SqlInt> Spacelimit = new Column<SqlInt>("spacelimit");
        
        public static readonly Column<SqlSmallInt> Status = new Column<SqlSmallInt>("status");
        
        public static readonly Column<SqlInt> Sysadmin = new Column<SqlInt>("sysadmin");
        
        public static readonly Column<SqlInt> Timelimit = new Column<SqlInt>("timelimit");
        
        public static readonly Column<SqlInt> Totcpu = new Column<SqlInt>("totcpu");
        
        public static readonly Column<SqlInt> Totio = new Column<SqlInt>("totio");
        
        public static readonly Column<SqlDateTime> Updatedate = new Column<SqlDateTime>("updatedate");
    }
}
