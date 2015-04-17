using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ServerPermissions
    {
        public static readonly ViewName ViewName = new ViewName("sys.server_permissions");
        
        public static readonly Column<SqlTinyInt> Class = new Column<SqlTinyInt>("class");
        
        public static readonly Column<SqlNVarchar> ClassDesc = new Column<SqlNVarchar>("class_desc");
        
        public static readonly Column<SqlInt> GranteePrincipalId = new Column<SqlInt>("grantee_principal_id");
        
        public static readonly Column<SqlInt> GrantorPrincipalId = new Column<SqlInt>("grantor_principal_id");
        
        public static readonly Column<SqlInt> MajorId = new Column<SqlInt>("major_id");
        
        public static readonly Column<SqlInt> MinorId = new Column<SqlInt>("minor_id");
        
        public static readonly Column<SqlNVarchar> PermissionName = new Column<SqlNVarchar>("permission_name");
        
        public static readonly Column<SqlChar> State = new Column<SqlChar>("state");
        
        public static readonly Column<SqlNVarchar> StateDesc = new Column<SqlNVarchar>("state_desc");
        
        public static readonly Column<SqlChar> Type = new Column<SqlChar>("type");
    }
}
