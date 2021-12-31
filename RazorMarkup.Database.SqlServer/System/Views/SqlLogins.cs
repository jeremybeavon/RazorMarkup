using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SqlLogins
    {
        public static readonly ViewName ViewName = new("sys.sql_logins");

        public static readonly Column<SqlDateTime> CreateDate = new("create_date");

        public static readonly Column<SqlInt> CredentialId = new("credential_id");

        public static readonly Column<SqlSysname> DefaultDatabaseName = new("default_database_name");

        public static readonly Column<SqlSysname> DefaultLanguageName = new("default_language_name");

        public static readonly Column<SqlBit> IsDisabled = new("is_disabled");

        public static readonly Column<SqlBit> IsExpirationChecked = new("is_expiration_checked");

        public static readonly Column<SqlBit> IsPolicyChecked = new("is_policy_checked");

        public static readonly Column<SqlDateTime> ModifyDate = new("modify_date");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlVarbinary> PasswordHash = new("password_hash");

        public static readonly Column<SqlInt> PrincipalId = new("principal_id");

        public static readonly Column<SqlVarbinary> Sid = new("sid");

        public static readonly Column<SqlChar> Type = new("type");

        public static readonly Column<SqlNVarchar> TypeDesc = new("type_desc");
    }
}
