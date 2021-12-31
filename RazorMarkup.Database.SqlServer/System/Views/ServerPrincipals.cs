using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ServerPrincipals
    {
        public static readonly ViewName ViewName = new("sys.server_principals");

        public static readonly Column<SqlDateTime> CreateDate = new("create_date");

        public static readonly Column<SqlInt> CredentialId = new("credential_id");

        public static readonly Column<SqlSysname> DefaultDatabaseName = new("default_database_name");

        public static readonly Column<SqlSysname> DefaultLanguageName = new("default_language_name");

        public static readonly Column<SqlBit> IsDisabled = new("is_disabled");

        public static readonly Column<SqlBit> IsFixedRole = new("is_fixed_role");

        public static readonly Column<SqlDateTime> ModifyDate = new("modify_date");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlInt> OwningPrincipalId = new("owning_principal_id");

        public static readonly Column<SqlInt> PrincipalId = new("principal_id");

        public static readonly Column<SqlVarbinary> Sid = new("sid");

        public static readonly Column<SqlChar> Type = new("type");

        public static readonly Column<SqlNVarchar> TypeDesc = new("type_desc");
    }
}
