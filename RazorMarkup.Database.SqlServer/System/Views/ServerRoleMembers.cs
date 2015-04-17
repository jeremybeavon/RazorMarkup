using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ServerRoleMembers
    {
        public static readonly ViewName ViewName = new ViewName("sys.server_role_members");
        
        public static readonly Column<SqlInt> MemberPrincipalId = new Column<SqlInt>("member_principal_id");
        
        public static readonly Column<SqlInt> RolePrincipalId = new Column<SqlInt>("role_principal_id");
    }
}
