using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysUsers
    {
        public static readonly ViewName ViewName = new ViewName("sys.sysusers");
        
        public static readonly Column<SqlSmallInt> Altuid = new Column<SqlSmallInt>("altuid");
        
        public static readonly Column<SqlDateTime> Createdate = new Column<SqlDateTime>("createdate");
        
        public static readonly Column<SqlVarchar> Environ = new Column<SqlVarchar>("environ");
        
        public static readonly Column<SqlSmallInt> Gid = new Column<SqlSmallInt>("gid");
        
        public static readonly Column<SqlInt> Hasdbaccess = new Column<SqlInt>("hasdbaccess");
        
        public static readonly Column<SqlInt> Isaliased = new Column<SqlInt>("isaliased");
        
        public static readonly Column<SqlInt> Isapprole = new Column<SqlInt>("isapprole");
        
        public static readonly Column<SqlInt> Islogin = new Column<SqlInt>("islogin");
        
        public static readonly Column<SqlInt> Isntgroup = new Column<SqlInt>("isntgroup");
        
        public static readonly Column<SqlInt> Isntname = new Column<SqlInt>("isntname");
        
        public static readonly Column<SqlInt> Isntuser = new Column<SqlInt>("isntuser");
        
        public static readonly Column<SqlInt> Issqlrole = new Column<SqlInt>("issqlrole");
        
        public static readonly Column<SqlInt> Issqluser = new Column<SqlInt>("issqluser");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlVarbinary> Password = new Column<SqlVarbinary>("password");
        
        public static readonly Column<SqlVarbinary> Roles = new Column<SqlVarbinary>("roles");
        
        public static readonly Column<SqlVarbinary> Sid = new Column<SqlVarbinary>("sid");
        
        public static readonly Column<SqlSmallInt> Status = new Column<SqlSmallInt>("status");
        
        public static readonly Column<SqlSmallInt> Uid = new Column<SqlSmallInt>("uid");
        
        public static readonly Column<SqlDateTime> Updatedate = new Column<SqlDateTime>("updatedate");
    }
}
