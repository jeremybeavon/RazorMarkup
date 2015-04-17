using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class UserToken
    {
        public static readonly ViewName ViewName = new ViewName("sys.user_token");
        
        public static readonly Column<SqlNVarchar> Name = new Column<SqlNVarchar>("name");
        
        public static readonly Column<SqlInt> PrincipalId = new Column<SqlInt>("principal_id");
        
        public static readonly Column<SqlVarbinary> Sid = new Column<SqlVarbinary>("sid");
        
        public static readonly Column<SqlNVarchar> Type = new Column<SqlNVarchar>("type");
        
        public static readonly Column<SqlNVarchar> Usage = new Column<SqlNVarchar>("usage");
    }
}
