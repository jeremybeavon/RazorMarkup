using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class LoginToken
    {
        public static readonly ViewName ViewName = new("sys.login_token");

        public static readonly Column<SqlNVarchar> Name = new("name");

        public static readonly Column<SqlInt> PrincipalId = new("principal_id");

        public static readonly Column<SqlVarbinary> Sid = new("sid");

        public static readonly Column<SqlNVarchar> Type = new("type");

        public static readonly Column<SqlNVarchar> Usage = new("usage");
    }
}
