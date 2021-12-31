using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DatabasePermissions
    {
        public static readonly ViewName ViewName = new("sys.database_permissions");

        public static readonly Column<SqlTinyInt> Class = new("class");

        public static readonly Column<SqlNVarchar> ClassDesc = new("class_desc");

        public static readonly Column<SqlInt> GranteePrincipalId = new("grantee_principal_id");

        public static readonly Column<SqlInt> GrantorPrincipalId = new("grantor_principal_id");

        public static readonly Column<SqlInt> MajorId = new("major_id");

        public static readonly Column<SqlInt> MinorId = new("minor_id");

        public static readonly Column<SqlNVarchar> PermissionName = new("permission_name");

        public static readonly Column<SqlChar> State = new("state");

        public static readonly Column<SqlNVarchar> StateDesc = new("state_desc");

        public static readonly Column<SqlChar> Type = new("type");
    }
}
