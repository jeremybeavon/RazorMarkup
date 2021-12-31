using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DatabaseRoleMembers
    {
        public static readonly ViewName ViewName = new("sys.database_role_members");

        public static readonly Column<SqlInt> MemberPrincipalId = new("member_principal_id");

        public static readonly Column<SqlInt> RolePrincipalId = new("role_principal_id");
    }
}
