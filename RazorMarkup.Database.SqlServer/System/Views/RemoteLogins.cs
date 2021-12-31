using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class RemoteLogins
    {
        public static readonly ViewName ViewName = new("sys.remote_logins");

        public static readonly Column<SqlInt> LocalPrincipalId = new("local_principal_id");

        public static readonly Column<SqlDateTime> ModifyDate = new("modify_date");

        public static readonly Column<SqlSysname> RemoteName = new("remote_name");

        public static readonly Column<SqlInt> ServerId = new("server_id");
    }
}
