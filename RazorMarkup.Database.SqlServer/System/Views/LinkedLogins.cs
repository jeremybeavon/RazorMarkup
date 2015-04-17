using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class LinkedLogins
    {
        public static readonly ViewName ViewName = new ViewName("sys.linked_logins");
        
        public static readonly Column<SqlInt> LocalPrincipalId = new Column<SqlInt>("local_principal_id");
        
        public static readonly Column<SqlDateTime> ModifyDate = new Column<SqlDateTime>("modify_date");
        
        public static readonly Column<SqlSysname> RemoteName = new Column<SqlSysname>("remote_name");
        
        public static readonly Column<SqlInt> ServerId = new Column<SqlInt>("server_id");
        
        public static readonly Column<SqlBit> UsesSelfCredential = new Column<SqlBit>("uses_self_credential");
    }
}
