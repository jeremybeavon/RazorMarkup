using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Credentials
    {
        public static readonly ViewName ViewName = new("sys.credentials");

        public static readonly Column<SqlDateTime> CreateDate = new("create_date");

        public static readonly Column<SqlInt> CredentialId = new("credential_id");

        public static readonly Column<SqlNVarchar> CredentialIdentity = new("credential_identity");

        public static readonly Column<SqlDateTime> ModifyDate = new("modify_date");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlInt> TargetId = new("target_id");

        public static readonly Column<SqlNVarchar> TargetType = new("target_type");
    }
}
