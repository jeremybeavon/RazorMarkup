using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DatabasePrincipals
    {
        public static readonly ViewName ViewName = new("sys.database_principals");

        public static readonly Column<SqlInt> AuthenticationType = new("authentication_type");

        public static readonly Column<SqlNVarchar> AuthenticationTypeDesc = new("authentication_type_desc");

        public static readonly Column<SqlDateTime> CreateDate = new("create_date");

        public static readonly Column<SqlInt> DefaultLanguageLcid = new("default_language_lcid");

        public static readonly Column<SqlSysname> DefaultLanguageName = new("default_language_name");

        public static readonly Column<SqlSysname> DefaultSchemaName = new("default_schema_name");

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
